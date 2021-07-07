using eVet.Model;
using eVet.Model.Request;
using eVet.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVet.WebAPI.Controllers
{

    public class VrstaUslugeController : BaseCRUDController<Model.VrstaUsluge, object, VrstaUslugeUpsertRequest, VrstaUslugeUpsertRequest>
    {
        public VrstaUslugeController(ICRUDService<VrstaUsluge, object, VrstaUslugeUpsertRequest, VrstaUslugeUpsertRequest> service) : base(service)
        {
        }
    }
}
