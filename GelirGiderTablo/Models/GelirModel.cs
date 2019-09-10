using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelirGiderTablo
{
    public class GelirModel
    {
        public int Id { get; set; }
        [Required]
        public string Firma { get; set; }
        [Required]
        public decimal Borc { get; set; }
        [Required]
        public decimal Alacak { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime VadeTarihi { get; set; }
        public string Aciklama { get; set; }
        public string Tip { get; set; }
        public string ParaCinsi { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Adet { get; set; }
        public string OdemeSekli { get; set; }

    }
}
