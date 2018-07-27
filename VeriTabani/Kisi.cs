using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bilgi.VeriTabani
{
    public class Kisi
    {
        [Key]
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Boolean Cinsiyet { get; set; }

        public Sehir Sehir { get; set; }
        public ICollection<TelefonNumarasi> TelefonNumaralari { get; set; }
        public ICollection<SosyalMedyaHesabi> SosyalMedyaHesaplari { get; set; }
        public ICollection<Bilgi> Bilgiler { get; set; }
    }
}
