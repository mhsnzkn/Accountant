using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelirGiderTablo
{
    public class Cari
    {
        [Required]
        public string CariKod { get; set; }
        [Required]
        public string Ad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Ilce { get; set; }
        public string Il { get; set; }
        public string Email { get; set; }
    }
}
