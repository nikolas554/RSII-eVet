using System;
using System.Collections.Generic;

#nullable disable

namespace eVet.WebAPI.Database
{
    public partial class VrstaUsluge
    {
        public VrstaUsluge()
        {
            Pregleds = new HashSet<Pregled>();
            Rezervacijes = new HashSet<Rezervacije>();
        }

        public int VrstaUslugeId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }

        public virtual ICollection<Pregled> Pregleds { get; set; }
        public virtual ICollection<Rezervacije> Rezervacijes { get; set; }
    }
}
