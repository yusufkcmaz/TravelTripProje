using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class Yorumlar
    {
        [Key]
        public int Id { get; set; } 
        public string KullanıcıAdı {  get; set; }
        public string Mail { get; set; }
        public string Yorum  { get; set; }
        public int blogid { get; set; }
        public virtual Blog BLOGI { get; set; }



    }
}