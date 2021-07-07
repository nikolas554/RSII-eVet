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
    public class LijekService : BaseCRUDService<Model.Lijek, LijekSearchRequest, Database.Lijekovi, LijekUpsertRequest, LijekUpsertRequest>
    {
        public LijekService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Lijek> Get(LijekSearchRequest search)
        {
            var query = _context.Lijekovis.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }

            if(search?.PregledId.HasValue==true)
            {
                var query1 = _context.Set<Database.LijekoviPregled>().Where(x => x.PregledId == search.PregledId)
                    .Include(x => x.Lijek)
                    .Select(x => new { x.LijekId, x.Lijek.Naziv })
                    .OrderBy(x => x.Naziv)
                    .ToList();


                var list1 = new List<Model.Lijek>();
                foreach (var item in query1)
                {
                    list1.Add(new Model.Lijek
                    {
                        LijekID=item.LijekId,
                        Naziv=item.Naziv
                    });
                }
                return list1;
            }
        
            var list = query.ToList();


            var result= _mapper.Map<List<Model.Lijek>>(list);
           
            return result;

        }
        public override Lijek GetById(int id)
        {
            return base.GetById(id);
        }
    }

}
