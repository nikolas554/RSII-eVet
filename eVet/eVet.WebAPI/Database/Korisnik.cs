using System;
using System.Collections.Generic;

#nullable disable

namespace eVet.WebAPI.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            KorisniciUloges = new HashSet<KorisniciUloge>();
            Ljubimacs = new HashSet<Ljubimac>();
            Pregleds = new HashSet<Pregled>();
        }

        public int KorisnikId { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Mobilni { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Status { get; set; }
        public byte[] Slika { get; set; }

        public virtual ICollection<KorisniciUloge> KorisniciUloges { get; set; }
        public virtual ICollection<Ljubimac> Ljubimacs { get; set; }
        public virtual ICollection<Pregled> Pregleds { get; set; }
    }
}
