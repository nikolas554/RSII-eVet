using AutoMapper;
using eVet.Model.Request;
using eVet.WebAPI.Database;
using eVet.WebAPI.Exceptions;
using eVet.WebAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eVet.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly VeterinarskaStanicaContext _context;
        private readonly IMapper _mapper;
        public KorisniciService(VeterinarskaStanicaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public List<Model.Korisnik> Get(KorisniciSearchRequest request)
        {


            var query = _context.Korisniks.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }

            var list = query.ToList();


            return _mapper.Map<List<Model.Korisnik>>(list);
        }

        public Model.Korisnik GetById(int id)
        {
            var entity = _context.Korisniks.Find(id);
            return _mapper.Map<Model.Korisnik>(entity);
        }

        public Model.Korisnik Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnik>(request);
            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = HashGenerator.GenerateSalt();
            entity.LozinkaHash = HashGenerator.GenerateHash(entity.LozinkaSalt, request.Password);
            _context.Korisniks.Add(entity);
            _context.SaveChanges();


            foreach (var uloga in request.Uloge)
            {
                Database.KorisniciUloge korisniciUloge = new Database.KorisniciUloge();
            
                korisniciUloge.KorisnikId = entity.KorisnikId;
                korisniciUloge.UlogaId = uloga;
                korisniciUloge.DatumIzmjene = DateTime.Now;

                _context.KorisniciUloges.Add(korisniciUloge);
            }


            _context.SaveChanges();
            return _mapper.Map<Model.Korisnik>(entity);
        }

        public Model.Korisnik Update(int id, KorisniciInsertRequest request)
        {
            var entity = _context.Korisniks.Find(id);
            _context.Korisniks.Attach(entity);
            _context.Korisniks.Update(entity);
            _mapper.Map(request, entity);
            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new UserException("Passdwordi se ne slažu");
                }
                entity.LozinkaSalt = HashGenerator.GenerateSalt();
                entity.LozinkaHash = HashGenerator.GenerateHash(entity.LozinkaSalt, request.Password);
            }
     
            _context.SaveChanges();


            var korisnikUloge = _context.KorisniciUloges.Where(x => x.KorisnikId == entity.KorisnikId);
            if (request.Uloge.Count() < korisnikUloge.Count())
            {
                foreach (var uloga in korisnikUloge)
                {
                    if (!request.Uloge.Contains(uloga.UlogaId))
                    {
                        _context.KorisniciUloges.Remove(uloga);
                    }
                }
            }

            if (request.Uloge != null && request.Uloge.Count() > 0 && request.Uloge[0] != 0)
            {
                foreach (var uloga in request.Uloge)
                {
                    if (!_context.KorisniciUloges.Any(x => x.KorisnikId == entity.KorisnikId && x.UlogaId == uloga))
                    {
                        _context.KorisniciUloges.Add(new KorisniciUloge
                        {
                            UlogaId = uloga,
                            KorisnikId = entity.KorisnikId,
                            DatumIzmjene = DateTime.Now
                        });
                    }
                }
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Korisnik>(entity);
        }

        public Model.Korisnik Authenticiraj(string username, string password)
        {

            var user = _context.Korisniks.Include(i=>i.KorisniciUloges).ThenInclude(j=>j.Uloga).FirstOrDefault(x => x.KorisnickoIme == username);
         

            if (user != null)
            {
                var newHash = HashGenerator.GenerateHash(user.LozinkaSalt, password); 
                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnik>(user);
                }
            }
            return null;
        }

        public List<Model.Korisnik> GetTopKorisnici()
        {
            List<Model.Korisnik> podaci = _context.Korisniks.Select(x => new Model.Korisnik
            {
                Ime=x.Ime,
                Prezime=x.Prezime,
                Adresa=x.Adresa,
                BrojUsluga=_context.Pregleds.Include(i=>i.Ljubimac).Where(w=>w.Ljubimac.KorisnikId==x.KorisnikId).Count()

            }).Take(10).OrderByDescending(ob=>ob.BrojUsluga).ToList();
            return podaci;
        }
    }
}
