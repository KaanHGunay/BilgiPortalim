using System.ComponentModel.DataAnnotations;

namespace Bilgi.VeriTabani
{
    public class SosyalMedyaHesabi
    {
        [Key]
        public int ID { get; set; }

        public SosyalMedya SosyalMedyaTur { get; set; }
        public Kisi Kullanici { get; set; }
    }
}
