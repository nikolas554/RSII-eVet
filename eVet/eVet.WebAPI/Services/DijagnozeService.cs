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
    public class DijagnozeService : BaseCRUDService<Model.Dijagnoza, DijagnozaSearchRequest, Database.Dijagnoza, DijagnozaUpsertRequest, DijagnozaUpsertRequest>
    {
        public DijagnozeService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Dijagnoza> Get(DijagnozaSearchRequest search)
        {
            if (search?.PregledId.HasValue == true)
            {
                var query = _context.Set<Database.Ustanovljena>().Where(x => x.PregledId == search.PregledId)
                    .Include(x => x.Dijagnoza)
                    .Select(x => new { x.DijagnozaId, x.Dijagnoza.Naziv })
                    .OrderBy(x => x.Naziv)
                    .ToList();
                var list1 = new List<Model.Dijagnoza>();
                foreach(var item in query)
                {
                    list1.Add(new Model.Dijagnoza { 
                    DijagnozaId=item.DijagnozaId,
                    Naziv=item.Naziv
                    });
                }
                return list1;
            }
            var list = _context.Set<Database.Dijagnoza>().OrderBy(x=>x.Naziv).ToList();
            return _mapper.Map<List<Model.Dijagnoza>>(list);
        }
    }
}
