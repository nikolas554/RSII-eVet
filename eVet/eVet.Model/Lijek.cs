using System;
using System.Collections.Generic;

namespace eVet.Model
{
    public class Lijek
    {
        public int LijekID { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public virtual ICollection<LijekoviPregled> LijekoviPregleds { get; set; }
    }
}
