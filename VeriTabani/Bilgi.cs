using System;
using System.ComponentModel.DataAnnotations;

namespace Bilgi.VeriTabani
{
    public class Bilgi
    {
        [Key]
        public int ID { get; set; }
        public Kisi HakkindaOlanKisi { get; set; }
        public string Metin { get; set; }
        public string Kaynak { get; set; }
        public DateTime Tarih { get; set; }
    }
}
