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
  
    public class LijekController : BaseCRUDController<Model.Lijek, LijekSearchRequest, LijekUpsertRequest, LijekUpsertRequest>
    {

        public LijekController(ICRUDService<Lijek, LijekSearchRequest, LijekUpsertRequest, LijekUpsertRequest> service) : base(service)
        {
        }
    }
}
