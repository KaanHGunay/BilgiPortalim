using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bilgi.VeriTabani
{
    public class SosyalMedya
    {
        [Key]
        public int ID { get; set; }
        public string Isim { get; set; }

        public ICollection<SosyalMedyaHesabi> SosyalMedyaHesaplari { get; set; }
    }
}
