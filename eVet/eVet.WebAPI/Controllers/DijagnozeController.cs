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

    public class DijagnozeController : BaseCRUDController<Model.Dijagnoza, DijagnozaSearchRequest, DijagnozaUpsertRequest, DijagnozaUpsertRequest>
    {
        private readonly DijagnozeService _service;
        public DijagnozeController(DijagnozeService service):base(service)
        {
            _service = service;
        }
    }
}
