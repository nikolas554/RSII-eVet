using AutoMapper;
using eVet.Model;
using eVet.Model.Request;
using eVet.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVet.WebAPI.Services
{
    public class LjubimciService : BaseCRUDService<Model.Ljubimac, object, Database.Ljubimac, LjubimacUpsertRequest, LjubimacUpsertRequest>
    {

        public LjubimciService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public List<Model.Ljubimac> GetLjubimciByKorisnik(int id)
        {
            var list = _context.Ljubimacs.Include(i=>i.Korisnik).Where(x => x.KorisnikId == id);
            var result= _mapper.Map<List<Model.Ljubimac>>(list);
            foreach (var item in result)
            {
                item.KorisnikLjubimacIme = item.Korisnik.Ime + " " + item.Korisnik.Prezime + " (" + item.Ime + ")"; 
            }
            return result;
        }
        public Model.Ljubimac InsertByKorisnik(LjubimacUpsertRequest request, int id)
        {
            request.KorisnikId = id;
            var entity = _mapper.Map<Database.Ljubimac>(request);
            

            _context.Set<Database.Ljubimac>().Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Ljubimac>(entity);
        }


    }
}

