using System;
using System.Collections.Generic;

#nullable disable

namespace eVet.WebAPI.Database
{
    public partial class Rezervacije
    {
        public int RezervacijaId { get; set; }
        public DateTime Datum { get; set; }
        public int TerminId { get; set; }
        public int VrstaUslugeId { get; set; }
        public int LjubimacId { get; set; }
        public string Napomena { get; set; }
        public bool? Prihvacena { get; set; }
        public string Odgovor { get; set; }

        public virtual Ljubimac Ljubimac { get; set; }
        public virtual Termini Termin { get; set; }
        public virtual VrstaUsluge VrstaUsluge { get; set; }
    }
}
