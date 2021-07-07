using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model.Request
{
    public class LijekUpsertRequest
    {
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public int VrstaLijekaId { get; set; }

    }
}
