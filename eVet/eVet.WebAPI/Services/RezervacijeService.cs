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
    public class RezervacijeService : BaseCRUDService<Model.Rezervacije, RezervacijeSearchRequest, Database.Rezervacije, RezervacijeUpsertRequest, RezervacijeUpsertRequest>
    {
        public RezervacijeService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public Model.Rezervacije UpdateStatus(int id, bool? promjena)
        {
            var entity = _context.Rezervacijes.Find(id);
            if (promjena == null)
            {
                entity.Prihvacena = null;
             

            }
            else
            {
                 entity.Prihvacena = promjena;
                if(promjena==true)
                entity.Odgovor = "Rezervacija je uspješno prihvaćena";
                else
                entity.Odgovor = "Rezervacija je odbijena";

            }
           
            _context.SaveChanges();
            return _mapper.Map<Model.Rezervacije>(entity);
        }

        public List<Model.Rezervacije> GetRezervacije(int korisnikid, RezervacijeSearchRequest search)
        {

            var query = _context.Rezervacijes.Include(r => r.Termin).Include(r => r.VrstaUsluge).Include(r => r.Ljubimac).ThenInclude(r => r.Korisnik).AsQueryable();
            if (search.IsKorisnik == true && search.IsStatus == null)
            {
                query = query.Where(x => x.Ljubimac.Korisnik.KorisnikId == korisnikid && x.Prihvacena == null);
            }
            if (search.IsKorisnik ==true && search.IsStatus == true)
            {
                query = query.Where(x => x.Ljubimac.Korisnik.KorisnikId == korisnikid && x.Prihvacena == true);
            }
            if (search.IsKorisnik == true && search.IsStatus == false)
            {
                query = query.Where(x => x.Ljubimac.Korisnik.KorisnikId == korisnikid && x.Prihvacena == false);
            }
            if (search.IsKorisnik == false && search.IsStatus == null)
            {
                query = query.Where(x => x.Prihvacena == null);
            }
            if (search.IsKorisnik == false && search.IsStatus == true)
            {
                query = query.Where(x => x.Prihvacena == true);
            }
            if (search.IsKorisnik == false && search.IsStatus == false)
            {
                query = query.Where(x => x.Prihvacena == false);
            }
            var list = query.OrderByDescending(i => i.Datum).ToList();
            var result = _mapper.Map<List<Model.Rezervacije>>(list);
            foreach (var item in result)
            {
                item.KlijentIme = item.Ljubimac.Ime + " (" + item.Ljubimac.Korisnik.Ime + " " + item.Ljubimac.Korisnik.Prezime + ")";
                item.VrstaUslugeNaziv = item.VrstaUsluge.Naziv;
                item.TerminIme = item.Termin.Naziv;
            }
            return result;
        }

        
    }
}
