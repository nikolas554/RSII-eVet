using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model
{
    public class Ustanovljena
    {
        public string NapomenaUzDijagnozu { get; set; }
        public int PregledId { get; set; }
        public int DijagnozaId { get; set; }

        public virtual Dijagnoza Dijagnoza { get; set; }
        public virtual Pregled Pregled { get; set; }
    }
}
