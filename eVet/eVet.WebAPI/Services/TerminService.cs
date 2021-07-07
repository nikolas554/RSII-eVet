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
    public class TerminService : BaseCRUDService<Model.Termini, object, Database.Termini, TerminUpsertRequest, TerminUpsertRequest>
    {
        public TerminService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
