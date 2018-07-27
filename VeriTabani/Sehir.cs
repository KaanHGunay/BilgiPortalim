using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bilgi.VeriTabani
{
    public class Sehir
    {       
        [Key]
        public int ID { get; set; }
        public string Isim { get; set; }

        public ICollection<Kisi> Kisiler { get; set; }
    }
}
