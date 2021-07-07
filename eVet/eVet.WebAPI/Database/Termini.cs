using System;
using System.Collections.Generic;

#nullable disable

namespace eVet.WebAPI.Database
{
    public partial class Termini
    {
        public Termini()
        {
            Rezervacijes = new HashSet<Rezervacije>();
        }

        public int TerminId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Rezervacije> Rezervacijes { get; set; }
    }
}
