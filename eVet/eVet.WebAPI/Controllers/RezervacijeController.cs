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

    public class RezervacijeController : BaseCRUDController<Model.Rezervacije, RezervacijeSearchRequest, RezervacijeUpsertRequest, RezervacijeUpsertRequest>
    {
        private readonly RezervacijeService _service;
        public RezervacijeController(RezervacijeService service) : base(service)
        {
            _service = service;
        }
        [HttpGet("Vrste")]
        public List<Model.Rezervacije> GetRezervacije([FromHeader] RezervacijeSearchRequest search = default)
        {
            var Userid = User.GetUserId();
            var list = _service.GetRezervacije((int)Userid, search);
            return list;
        }

        [HttpPut("UpdateStatus/{id}")]
        public Model.Rezervacije UpdateStatus(int id, [FromBody]bool promjena)
        {
            return _service.UpdateStatus(id, promjena);
        }

   
    }
}
