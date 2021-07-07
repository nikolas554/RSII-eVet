using eVet.Model;
using eVet.Model.Request;
using eVet.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVet.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LjubimciController : BaseCRUDController<Model.Ljubimac, object, LjubimacUpsertRequest, LjubimacUpsertRequest>
    {

        private readonly LjubimciService _service;
        public LjubimciController(LjubimciService service) : base(service)
        {
            _service = service;
        }

        [HttpGet("byKorisnik")]
        public List<Model.Ljubimac> GetLjubimciByKorisnik([FromQuery]int? id)
        {
            var Userid=id;
            if (id == null)
            {
                Userid = User.GetUserId();
            }
            else {
                Userid = id;
            }
           
            var list = _service.GetLjubimciByKorisnik((int)Userid);
            return list;
        }

        [HttpPost("byKorisnik")]
        public Model.Ljubimac InsertByKorisnik(LjubimacUpsertRequest request)
        {
            var Userid = User.GetUserId();
            var list = _service.InsertByKorisnik(request, Userid);
            return list;
        }

    }
}

