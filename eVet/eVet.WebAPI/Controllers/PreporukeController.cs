using eVet.WebAPI.Database;
using eVet.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVet.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreporukeController : ControllerBase
    {
        private readonly IPreporukeService _service;
        public PreporukeController(IPreporukeService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.VrstaUsluge> Get([FromQuery]int id)
        {

            return _service.Get(id);
        }
    }
}
