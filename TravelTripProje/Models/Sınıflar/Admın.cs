using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class Admın
    {
        [Key]
        public int ID { get; set; } 
        public string Kulanıcı{ get; set; } 
        public string Sifre { get; set; } 
    }
}