using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model.Request
{
    public class PreglediUpsertRequest
    {
        
      
        public DateTime Datum { get; set; }
        public int KorisnikId { get; set; }
        public int LjubimacId { get; set; }
        public int VrstaUslugeId { get; set; }
        public int? RacunId { get; set; }
        public string Napomena { get; set; }
        public int Popust { get; set; }
        public List<int> Dijagnoze { get; set; } = new List<int>();
        public List<int> Lijekovi { get; set; } = new List<int>();
        //public string VrstaUslugeNaziv { get; set; }

        //public virtual Korisnik Korisnik { get; set; }
        //public virtual Ljubimac Ljubimac { get; set; }
        //public virtual Racun Racun { get; set; }
        //public virtual VrstaUsluge VrstaUsluge { get; set; }

        //public virtual ICollection<Ustanovljena> Ustanovljenas { get; set; }


    }
}
