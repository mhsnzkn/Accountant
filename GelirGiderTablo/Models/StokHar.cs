﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelirGiderTablo.Models
{
    public class StokHar
    {
        public string StokKodu { get; set; }
        public decimal Giren { get; set; }
        public decimal Cikan { get; set; }
        public string Aciklama { get; set; }
        public long? Cahar { get; set; }
        public DateTime Tarih { get; set; }
    }
}
