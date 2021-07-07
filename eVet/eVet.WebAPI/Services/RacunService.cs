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
    public class RacunService : BaseCRUDService<Model.Racun, RacuniSearchRequest, Database.Racun, RacuniInsertRequest, RacunUpdateRequest>
    {
        public RacunService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Racun> Get(RacuniSearchRequest search)
        {
            var query = _context.Racuns.Include(i => i.Pregled).Include(i => i.Pregled.Ljubimac.Korisnik).Include(i => i.Pregled.VrstaUsluge).AsQueryable();
            if (!string.IsNullOrWhiteSpace(search.Ime))
            {
                query = query.Where(x => x.Pregled.Ljubimac.Korisnik.Ime == search.Ime);
            }
            if (!string.IsNullOrWhiteSpace(search.Prezime))
            {
                query = query.Where(x => x.Pregled.Ljubimac.Korisnik.Prezime == search.Prezime);
            }
            if (search?.Status == 1)
            {
                query = query.Where(x => x.IsPlacen==true);
            }
            if (search?.Status == 2)
            {
                query = query.Where(x => x.IsPlacen == false);
            }
            if (search?.RacunId != 0)
            {
                query = query.Where(x => x.RacunId == search.RacunId);
            }
            if (search?.Neplaceni == true)
            {
                query = query.Where(x => x.IsPlacen==false);
            }
            if (search?.KlijentId != 0)
            {
                query = query.Where(x => x.Pregled.Ljubimac.Korisnik.KorisnikId == search.KlijentId);
            }
            var list = query.ToList().OrderByDescending(ob=>ob.DatumIzdavanja);
            var result = _mapper.Map<List<Model.Racun>>(list);
            foreach (var item in result)
            {
                item.ImePrezimeLjubimac = item.Pregled.Ljubimac.Korisnik.Ime + " " + item.Pregled.Ljubimac.Korisnik.Prezime + " ("+ item.Pregled.Ljubimac.Ime +")";
                item.Popust = item.Pregled.Popust;
                item.CijenaUsluge = item.Pregled.VrstaUsluge.Cijena;
                item.NazivVrsteUsluge = item.Pregled.VrstaUsluge.Naziv;
            }
            return result;
        }
        public override Model.Racun Insert(RacuniInsertRequest request)
        {
            var entity = _mapper.Map<Database.Racun>(request);
            var pregled = _context.Pregleds.Include(i => i.VrstaUsluge).FirstOrDefault(i => i.PregledId == request.PregledId);

            decimal snizenje = (pregled.VrstaUsluge.Cijena) - ((pregled.VrstaUsluge.Cijena * pregled.Popust) / 100);
            entity.DatumIzdavanja = DateTime.Now;
            entity.IsPlacen = false;
            entity.Iznos = snizenje;
            _context.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Racun>(entity);
        }
        public override Model.Racun Update(int id, RacunUpdateRequest request)
        {
            var entity = _context.Racuns.Find(id);
            entity.IsPlacen = request.IsPlacen;
            _context.SaveChanges();
            return _mapper.Map<Model.Racun>(entity);
        }


        public List<Model.Racun> GetPregledibyDatum(RacuniSearchRequest search)
        {

            var list = _context.Racuns.Include(i => i.Pregled.Ljubimac.Korisnik).Include(i => i.Pregled.VrstaUsluge).Where(w => w.Pregled.Datum.Year == search.Datum.Year && w.Pregled.Datum.Month == search.Datum.Month && w.Pregled.Datum.Day == search.Datum.Day).ToList();


            var result = _mapper.Map<List<Model.Racun>>(list);
            foreach (var item in result)
            {
                item.ImePrezimeLjubimac = item.Pregled.Ljubimac.Korisnik.Ime + " " + item.Pregled.Ljubimac.Korisnik.Prezime + " (" + item.Pregled.Ljubimac.Ime + ")";
                item.NazivVrsteUsluge = item.NazivVrsteUsluge;
            }
            return result;
        }
    }


}
