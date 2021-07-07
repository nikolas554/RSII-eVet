using System;
using System.Collections.Generic;

#nullable disable

namespace eVet.WebAPI.Database
{
    public partial class Racun
    {
        public int RacunId { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public decimal Iznos { get; set; }
        public bool? IsPlacen { get; set; }
        public int PregledId { get; set; }

        public virtual Pregled Pregled { get; set; }
    }
}
