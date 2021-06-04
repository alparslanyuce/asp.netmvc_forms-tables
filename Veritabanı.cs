using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_intermediate.Models
{
    //Sanal Veritabanı
    //Uygulama arkasında fiziksel bir dosyada bilgiler saklanmıyor.
    //Bilgiler bellekte saklanır.
    //Uygulama çalıştığından sonlanana kadar bu bilgilere ulaşabiliriz.
    public static class Veritabanı
    {
        private static List<Urun> _liste;

        static Veritabanı()
        {
            _liste = new List<Urun>()
            {
                new Urun(){ UrunId=1, UrunAdi="Samsung S6",Aciklama="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries,",Fiyat=3000,Satistami=false,Resim="1.jpg"},
                new Urun(){ UrunId=2, UrunAdi="Samsung S7", Aciklama = "idare eder", Fiyat = 5000, Satistami = true,Resim="2.jpg" },
                new Urun(){ UrunId=3, UrunAdi="Samsung S8",Aciklama="iyi",Fiyat=7000,Satistami=true,Resim="3.jpg"},
                new Urun(){ UrunId=4, UrunAdi="IPhone7",Aciklama="iyi",Fiyat=4800,Satistami=true,Resim="4.jpg"},
                new Urun(){ UrunId=5, UrunAdi="IPhone11",Aciklama="çok iyi",Fiyat=8000,Satistami=true,Resim="5.jpg"}
            };
        }

        //Veritabanı.Liste
        public static List<Urun> Liste
        {
            get { return _liste; }
        }

        public static void ElemanEkle(Urun entity)
        {
            _liste.Add(entity);
        }

        //Urun entity = Veritabanı.UrunDetay(5)
        public static Urun UrunDetay(int urunid)
        {
            Urun entity = null;
            foreach (var urun in _liste)
            {
                if(urun.UrunId==urunid)
                {
                    entity = urun;
                }
            }

            return entity;

        }


       
    }
}