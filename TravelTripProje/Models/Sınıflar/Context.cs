using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;//=> using ifadesi veri tabanı ile çalışılann sınıfları burada yazarız 
//sınıflara erişebilmek için yani dbset.context gibi metodalrı kullanabilmek için mecburuz.

namespace TravelTripProje.Models.Sınıflar
{
    //***BURADA CONTEXT VERİTABANI BAĞLAMINDA KULLANILIR 
    //***CONTEXT: ENTİTY F. İLE VERİTABANI ETKİLEŞİMLERİNİ YÖNETİR
    //***DBCONTEXT : İSE BERİTABINII VERİ EKLEME GÜNCELLEME VE SİLME GİBİ İŞLEMLERİ YAPAR

    public class Context:DbContext
    {//dbset:Blog modelline karşılık veren veritabanı tablosu temsil eder ekleme ve silmevs..
        public DbSet<Admın> Admıns { get; set; }    
        public DbSet<Adresleme>Adreslemes { get; set; }
        public DbSet<Blog>Blogs { get; set; }
        public DbSet<Hakkımızda>Hakkımızdas { get; set; }
        public DbSet<İletişim>İletişims { get; set; }
        public DbSet<Yorumlar>Yorumlars { get; set; }
    }
    
}