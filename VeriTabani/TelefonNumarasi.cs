using System.ComponentModel.DataAnnotations;

namespace Bilgi.VeriTabani
{
    public class TelefonNumarasi
    {
        [Key]
        public int ID { get; set; }
        public Kisi Kullanici { get; set; }
        public string Numara { get; set; }
    }
}
