using AutoMapper;
using eVet.Model.Request;
using eVet.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVet.WebAPI.Services
{
    public class PreglediService : BaseCRUDService<Model.Pregled, PregledSearchRequest, Database.Pregled, PreglediUpsertRequest, PreglediUpsertRequest>
    {
        public PreglediService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Pregled> Get(PregledSearchRequest search)
        {
            var query = _context.Pregleds.Include(i => i.Ustanovljenas).ThenInclude(i => i.Dijagnoza).Include(i => i.Korisnik).Include(i => i.Ljubimac).ThenInclude(i => i.Korisnik).Include(i => i.VrstaUsluge).AsQueryable();
            if (search?.VrstaUslugeID != 0)
            {
                query = query.Where(w => w.VrstaUsluge.VrstaUslugeId == search.VrstaUslugeID);
            }
            if (!string.IsNullOrWhiteSpace(search.Ime))
            {
                query = query.Where(w => w.Ljubimac.Korisnik.Ime == search.Ime);
            }
            if (!string.IsNullOrWhiteSpace(search.Prezime))
            {
                query = query.Where(w => w.Ljubimac.Korisnik.Prezime == search.Prezime);
            }

            var list = query.ToList().OrderByDescending(ob=>ob.Datum);
            var result = _mapper.Map<List<Model.Pregled>>(list);
            foreach (var item in result)
            {
                item.KorisnikIme = item.Korisnik.Ime + " " + item.Korisnik.Prezime;
                item.VrstaUslugeNaziv = item.VrstaUsluge.Naziv;
                item.Ljubimac.Ime = item.Ljubimac.Ime;
                item.KorisnikLljubimacIme = item.Ljubimac.Korisnik.Ime + " " + item.Korisnik.Prezime + " (" + item.Ljubimac.Ime + ")";
            }
            return result;
        }
        public List<Model.Pregled> GetLPreglediLjubimac(int pregledid)
        {
            var list = _context.Pregleds.Include(i => i.Ustanovljenas).ThenInclude(i => i.Dijagnoza).Include(i => i.Korisnik).Include(i => i.Ljubimac).Include(i => i.VrstaUsluge).Include(i=>i.LijekoviPregleds).ThenInclude(i=>i.Lijek).Where(w => w.LjubimacId == pregledid).ToList();
            var result = _mapper.Map<List<Model.Pregled>>(list);
            foreach (var item in result)
            {
                item.KorisnikIme = item.Korisnik.Ime + " " + item.Korisnik.Prezime;
                item.VrstaUslugeNaziv = item.VrstaUsluge.Naziv;
                item.Ljubimac.Ime = item.Ljubimac.Ime;
            }
            return result;
        }
        public override Model.Pregled Insert(PreglediUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Pregled>(request);
            _context.Pregleds.Add(entity);
            _context.SaveChanges();

            foreach (var dijagnoza in request.Dijagnoze)
            {
                Database.Ustanovljena ustanovljenadijagnoza = new Database.Ustanovljena();
                ustanovljenadijagnoza.DijagnozaId = dijagnoza;
                ustanovljenadijagnoza.PregledId = entity.PregledId;
                _context.Ustanovljenas.Add(ustanovljenadijagnoza);



            }

            foreach (var lijekovi in request.Lijekovi)
            {
                Database.LijekoviPregled lijekovipregled = new Database.LijekoviPregled();
                lijekovipregled.LijekId = lijekovi;
                lijekovipregled.PregledId = entity.PregledId;
                _context.LijekoviPregleds.Add(lijekovipregled);
            }
            _context.SaveChanges();
            return _mapper.Map<Model.Pregled>(entity);

        }

        public override Model.Pregled Update(int id, PreglediUpsertRequest request)
        {
            var entity = _context.Pregleds.Include(x => x.Ustanovljenas).Include(x => x.LijekoviPregleds).FirstOrDefault(x => x.PregledId == id);
            _context.Pregleds.Attach(entity);
            _context.Pregleds.Update(entity);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            var ustanovljenaDijagnoza = _context.Ustanovljenas.Where(w => w.PregledId == entity.PregledId);
            if (request.Dijagnoze.Count() < ustanovljenaDijagnoza.Count())
            {
                foreach (var dijagnoza in ustanovljenaDijagnoza)
                {
                    if (!request.Dijagnoze.Contains(dijagnoza.DijagnozaId))
                    {
                        _context.Ustanovljenas.Remove(dijagnoza);
                    }
                }
            }

            if (request.Dijagnoze != null && request.Dijagnoze.Count() > 0 && request.Dijagnoze[0] != 0)
            {

                foreach (var dijagnoza in request.Dijagnoze)
                {
                    if (!_context.Ustanovljenas.Any(x => x.PregledId == entity.PregledId && x.DijagnozaId == dijagnoza))
                    {
                        _context.Ustanovljenas.Add(new Ustanovljena
                        {
                            DijagnozaId = dijagnoza,
                            PregledId = entity.PregledId,


                        });
                    }
                }
               
            }


            var lijekoviPregled = _context.LijekoviPregleds.Where(w => w.PregledId == entity.PregledId);
            if (request.Lijekovi.Count() < lijekoviPregled.Count())
            {
                foreach (var lijek in lijekoviPregled)
                {
                    if (!request.Lijekovi.Contains(lijek.PregledId))
                    {
                        _context.LijekoviPregleds.Remove(lijek);
                    }
                }
            }


            if (request.Lijekovi != null && request.Lijekovi.Count() > 0 && request.Lijekovi[0] != 0)
            {

                foreach (var lijek in request.Lijekovi)
                {
                    if (!_context.LijekoviPregleds.Any(x => x.PregledId == entity.PregledId && x.PregledId == lijek))
                    {
                        _context.LijekoviPregleds.Add(new LijekoviPregled
                        {
                            
                          PregledId=entity.PregledId,
                          LijekId=lijek
                            

                        });
                    }
                }

            }
            _context.SaveChanges();
            return _mapper.Map<Model.Pregled>(entity);
        }

    }
}
