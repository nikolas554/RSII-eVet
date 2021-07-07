using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model.Request
{
    public class KorisniciInsertRequest
    {

        [Required]
        public DateTime DatumRodjenja { get; set; }
        [Required]
        [MinLength(2)]
        public string Ime { get; set; }
        [Required]
        [MinLength(2)]
        public string Prezime { get; set; }
        public string Adresa { get; set; }

        public string Mobilni { get; set; }
        [Required]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }
        [Required]
        [MinLength(4)]
        public string Password { get; set; }
        [Required]
        [MinLength(4)]
        public string PasswordConfirmation { get; set; }
        public List<int> Uloge { get; set; } = new List<int>();
        public byte[] Slika { get; set; }
    }
}
