using eVet.Model.Request;
using eVet.WebAPI.Database;
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
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }
       
        [HttpGet]
        public List<Model.Korisnik> Get([FromQuery] KorisniciSearchRequest request)
        {

            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public Model.Korisnik GetById(int id)
        {
            return _service.GetById(id);
        }
        //[Authorize(Roles ="Administrator")]
        [HttpPost]
        public Model.Korisnik Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody]KorisniciInsertRequest request)
        {
            //request.Uloge = new List<int>();
            //request.Uloge.Add(3);
            return Ok(_service.Insert(request));
        }

        [HttpPut("{id}")]
        public Model.Korisnik Update(int id, KorisniciInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("gettop")]
        public List<Model.Korisnik> GetTopKorisnici() {

            return _service.GetTopKorisnici();
        
        }
    }
}
