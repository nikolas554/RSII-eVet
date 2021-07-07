using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model.Request
{
    public class RezervacijeSearchRequest
    {
        public bool? IsStatus { get; set; }
        public bool IsKorisnik { get; set; }
    }
}
