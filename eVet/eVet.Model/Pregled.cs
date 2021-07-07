using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model
{
    public class Pregled
    {
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
        public string KorisnikIme { get; set; }
        public string VrstaUslugeNaziv { get; set; }
        public string KorisnikLljubimacIme { get; set; }

        public virtual ICollection<Ustanovljena> Ustanovljenas { get; set; }
        public virtual ICollection<LijekoviPregled> LijekoviPregleds { get; set; }
    }
}
