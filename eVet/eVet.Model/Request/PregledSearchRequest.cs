﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVet.Model.Request
{
    public class PregledSearchRequest
    {
        public int VrstaUslugeID{ get; set; }
        public DateTime Datum { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
