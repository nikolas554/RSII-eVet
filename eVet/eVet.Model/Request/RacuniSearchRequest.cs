using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model.Request
{
    public class RacuniSearchRequest
    {
        public int RacunId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Status { get; set; }
        public bool IsUplatio { get; set; }
        public DateTime Datum { get; set; }
        public bool? Neplaceni { get; set; }
        public int KlijentId { get; set; }

    }
}
