using System;
using System.Collections.Generic;

#nullable disable

namespace eVet.WebAPI.Database
{
    public partial class Ustanovljena
    {
        public int PregledId { get; set; }
        public int DijagnozaId { get; set; }

        public virtual Dijagnoza Dijagnoza { get; set; }
        public virtual Pregled Pregled { get; set; }
    }
}
