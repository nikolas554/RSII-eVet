using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model
{
    public class Uloge
    {
        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<KorisniciUloge> KorisniciUloges { get; set; }

    }
}
