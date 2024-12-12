using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    //**BURASI SQLDE'Kİ TABLO KISMINI (TBLANASAYFA) GİBİ OLUŞTURUYOR ANASAYFA CLASSI YANI
    public class AnaSayfa
    {
        [Key]
        public int ID { get; set; }
        public string Baslık { get; set; }
        public string Açıklama { get; set; }
    }
}