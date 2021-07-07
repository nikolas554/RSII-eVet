using System;
using System.Collections.Generic;

#nullable disable

namespace eVet.WebAPI.Database
{
    public partial class Dijagnoza
    {
        public Dijagnoza()
        {
            Ustanovljenas = new HashSet<Ustanovljena>();
        }

        public int DijagnozaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Ustanovljena> Ustanovljenas { get; set; }
    }
}
