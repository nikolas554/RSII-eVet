using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model
{
    public class LijekoviPregled
    {
        public int LijekoviPregledId { get; set; }
        public int LijekId { get; set; }
        public int PregledId { get; set; }

        public virtual Lijek Lijek { get; set; }
        public virtual Pregled Pregled { get; set; }
    }
}
