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

    public class PreglediController : BaseCRUDController<Model.Pregled, PregledSearchRequest, PreglediUpsertRequest, PreglediUpsertRequest>
    {
        private readonly PreglediService _service;
        public PreglediController(PreglediService service) : base(service)
        {
            _service = service;
        }
        [HttpGet("ljubimac")]
        public List<Model.Pregled> GetPreglediByKorisnik([FromQuery]int id)
        {

            var list = _service.GetLPreglediLjubimac(id);
            return list;
        }




    }
}
