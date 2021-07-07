using AutoMapper;
using eVet.Model.Request;
using eVet.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVet.WebAPI.Services
{
    public class VrstaUslugeService : BaseCRUDService<Model.VrstaUsluge, object, Database.VrstaUsluge, VrstaUslugeUpsertRequest, VrstaUslugeUpsertRequest>
    {
        public VrstaUslugeService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
