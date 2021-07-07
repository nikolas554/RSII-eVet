using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model
{
    public class Ljubimac
    {
        public int LjubimacId { get; set; }
        public string Ime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Rasa { get; set; }
        public string Boja { get; set; }
        public string Mikrocip { get; set; }
        public int KorisnikId { get; set; }
        public string KorisnikLjubimacIme { get; set; }
        public byte[] Slika { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
