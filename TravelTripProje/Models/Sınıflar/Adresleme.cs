using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    //BUNLAR SQLDE'Kİ TABLE YERİNE GEÇİYOR
    public class Adresleme
    {
        [Key]
        public  int ID { get; set; }
        public string Baslık { get; set; }
        public string Acıklama { get; set; }
        public string Adres { get; set; }
        public string Mail { get; set; }
        public string Telefom { get; set; }
        public string Konum { get; set; }
    }
}