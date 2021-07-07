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
    public class UlogeService:BaseService<Model.Uloge, UlogeSearchRequest, Database.Uloge>
    {
        public UlogeService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
        {
            
        }
        public override List<Model.Uloge> Get(UlogeSearchRequest search)
        {
            if (search?.KorisnikId.HasValue == true)
            {
                var query = _context.Set<Database.KorisniciUloge>().Where(x => x.KorisnikId == search.KorisnikId)
                    .Include(x => x.Uloga)
                    .Select(x => new { x.UlogaId, x.Uloga.Naziv })
                    .OrderBy(x => x.Naziv)
                    .ToList();

                var list = new List<Model.Uloge>();
                foreach (var item in query)
                {
                    list.Add(new Model.Uloge { 
                    Naziv=item.Naziv,
                    UlogaId=item.UlogaId
                    
                    });
                }
                return list;
            }
            var entity = _context.Set<Database.Uloge>().OrderBy(x => x.Naziv).ToList();
            return _mapper.Map<List<Model.Uloge>>(entity);
        }
    }
}
