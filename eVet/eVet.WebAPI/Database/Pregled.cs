using System;
using System.Collections.Generic;

#nullable disable

namespace eVet.WebAPI.Database
{
    public partial class Pregled
    {
        public Pregled()
        {
            LijekoviPregleds = new HashSet<LijekoviPregled>();
            Racuns = new HashSet<Racun>();
            Ustanovljenas = new HashSet<Ustanovljena>();
        }

        public int PregledId { get; set; }
        public DateTime Datum { get; set; }
        public int KorisnikId { get; set; }
        public int LjubimacId { get; set; }
        public int VrstaUslugeId { get; set; }
        public string Napomena { get; set; }
        public int Popust { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Ljubimac Ljubimac { get; set; }
        public virtual VrstaUsluge VrstaUsluge { get; set; }
        public virtual ICollection<LijekoviPregled> LijekoviPregleds { get; set; }
        public virtual ICollection<Racun> Racuns { get; set; }
        public virtual ICollection<Ustanovljena> Ustanovljenas { get; set; }
    }
}
