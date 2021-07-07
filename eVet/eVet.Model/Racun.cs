using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model
{
    public class Racun
    {
        public int RacunId { get; set; }
        public int VeterinarId { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public float Iznos { get; set; }
        public bool? IsPlacen { get; set; }
        public int PregledId { get; set; }
        public string ImePrezimeLjubimac { get; set; }
        public decimal CijenaUsluge { get; set; }
        public int Popust { get; set; }
        public virtual Pregled Pregled { get; set; }
        public string NazivVrsteUsluge { get; set; }
    }
}
