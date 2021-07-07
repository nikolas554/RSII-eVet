using System;
using System.Collections.Generic;

#nullable disable

namespace eVet.WebAPI.Database
{
    public partial class Ljubimac
    {
        public Ljubimac()
        {
            Pregleds = new HashSet<Pregled>();
            Rezervacijes = new HashSet<Rezervacije>();
        }

        public int LjubimacId { get; set; }
        public string Ime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Rasa { get; set; }
        public string Boja { get; set; }
        public string Mikrocip { get; set; }
        public int KorisnikId { get; set; }
        public byte[] Slika { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual ICollection<Pregled> Pregleds { get; set; }
        public virtual ICollection<Rezervacije> Rezervacijes { get; set; }
    }
}
