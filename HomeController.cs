using mvc_intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_intermediate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //veritabanına bağlanır ve bilgileri getirir.
            //getirilen bilgiler bir model içerisine yani bir sınıf
            //içerisine aktarılır ve bu model view'e gönderilir.

            UrunKategoriModel model = new UrunKategoriModel();

            model.UrunSayisi = Veritabanı.Liste.Where(i => i.Satistami == true).Count();
            model.Urunler = Veritabanı.Liste.Where(i=> i.Satistami==true).ToList();
            return View(model);
        }


        public ActionResult Details(int id)
        {
          var urun =  Veritabanı.Liste.Where(i => i.UrunId == id).FirstOrDefault();




            return View(urun);
        }

        [HttpGet]
        public ActionResult UrunEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UrunEkle(/*string UrunAdi,string Aciklama,double Fiyat,string Resim,bool Satistami*/  Urun entity )
        {
            //Urun entity = new Urun();
            //entity.UrunAdi = UrunAdi;
            //entity.Aciklama = Aciklama;
            //entity.Fiyat = Fiyat;
            //entity.Resim = Resim;
            //entity.Satistami = Satistami;

            Veritabanı.ElemanEkle(entity);

            return View("UrunListe", Veritabanı.Liste);

            //bilgileri karşılayıp gerekli yere kayıt edelim.
           
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

    }
}