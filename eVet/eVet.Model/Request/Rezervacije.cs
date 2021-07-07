using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model.Request
{
    public class Rezervacije
    {
        public int RezervacijaId { get; set; }
        public DateTime Datum { get; set; }
        public int TerminId { get; set; }
        public int VrstaUslugeId { get; set; }
        public int LjubimacId { get; set; }
        public string Napomena { get; set; }
        public virtual Ljubimac Ljubimac { get; set; }
        public virtual Termini Termin { get; set; }
        public virtual VrstaUsluge VrstaUsluge { get; set; }
    }
}
