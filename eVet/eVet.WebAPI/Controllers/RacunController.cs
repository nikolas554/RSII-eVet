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

    //[Route("api/[controller]")]
    //[ApiController]
    public class RacunController : BaseCRUDController<Model.Racun, RacuniSearchRequest, RacuniInsertRequest, RacunUpdateRequest>
    {
        private readonly RacunService _service;
        public RacunController(RacunService service) : base(service)
        {
            _service = service;
        }
        //public RacunController(ICRUDService<Model.Racun, RacuniSearchRequest, RacuniInsertRequest,RacunUpdateRequest> service) : base(service)
        //{
        //}
        [HttpGet("Vrste")]
        public List<Model.Racun> GetPregledibyDatum([FromQuery] RacuniSearchRequest search)
        {
            var list = _service.GetPregledibyDatum(search);
            return list;
        }

    }


}
