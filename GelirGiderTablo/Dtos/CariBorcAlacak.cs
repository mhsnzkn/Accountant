using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelirGiderTablo.Dtos
{
    public class CariBorcAlacak
    {
        public string CariKod { get; set; }
        public decimal Borc { get; set; }
        public decimal Alacak { get; set; }
        public decimal Bakiye => Borc - Alacak;
        public string ParaCinsi { get; set; }
    }
}
