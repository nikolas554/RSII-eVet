using System;
using System.Collections.Generic;

#nullable disable

namespace eVet.WebAPI.Database
{
    public partial class Lijekovi
    {
        public Lijekovi()
        {
            LijekoviPregleds = new HashSet<LijekoviPregled>();
        }

        public int LijekId { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }

        public virtual ICollection<LijekoviPregled> LijekoviPregleds { get; set; }
    }
}
