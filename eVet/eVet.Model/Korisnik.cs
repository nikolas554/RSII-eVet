using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model
{
    public class Korisnik
    {
        public int KorisnikId { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Mobilni { get; set; }
        public string KorisnickoIme { get; set; }
        public bool Status { get; set; }
        public int BrojUsluga { get; set; }
        public byte[] Slika { get; set; }
        public ICollection<KorisniciUloge> KorisniciUloges { get; set; }
    }
}
