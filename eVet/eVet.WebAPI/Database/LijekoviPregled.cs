using System;
using System.Collections.Generic;

#nullable disable

namespace eVet.WebAPI.Database
{
    public partial class LijekoviPregled
    {
        public int LijekoviPregledId { get; set; }
        public int LijekId { get; set; }
        public int PregledId { get; set; }

        public virtual Lijekovi Lijek { get; set; }
        public virtual Pregled Pregled { get; set; }
    }
}
