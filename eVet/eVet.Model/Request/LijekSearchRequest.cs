using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model.Request
{
    public class LijekSearchRequest
    {
        public int? PregledId { get; set; }
        public string Naziv { get; set; }
    }
}
