using AutoMapper;
using eVet.Model;
using eVet.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVet.WebAPI.Services
{
    public class PreporukeService : IPreporukeService
    {
        private readonly VeterinarskaStanicaContext _context;
        private readonly IMapper _mapper;
        public PreporukeService(VeterinarskaStanicaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.VrstaUsluge> Get(int id)
        {
            var prethodniPreglediList = _context.Pregleds.Include(x => x.Ljubimac)
            .ThenInclude(x=>x.Korisnik).Include(x=>x.VrstaUsluge)
            .Where(w=>w.Ljubimac.Korisnik.KorisnikId==id).ToList();
            var preporuceneUsluge = new List<Model.VrstaUsluge>();
            foreach (var item in prethodniPreglediList)
            {
                var obj = _mapper.Map<Model.VrstaUsluge>(item.VrstaUsluge);
                if (preporuceneUsluge.Find(x => x.VrstaUslugeId == obj.VrstaUslugeId) == null)
                {
                    preporuceneUsluge.Add(obj);
                }
            }
 
            if (preporuceneUsluge.Count == 0)
            {

                var listaNajKoristenijih = _context.VrstaUsluges.Select(x => new Model.VrstaUsluge
                {
                    VrstaUslugeId = x.VrstaUslugeId,
                    Cijena = x.Cijena,
                    Naziv = x.Naziv,
                    Opis = x.Opis,
                    Brojac = _context.Pregleds.Where(w=>w.VrstaUslugeId== x.VrstaUslugeId).Count()

                }).OrderByDescending(ob => ob.Brojac).Take(3).ToList();


                return listaNajKoristenijih;



            }
            return preporuceneUsluge;
        }
    }
}
