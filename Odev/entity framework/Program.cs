﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace entity_framework
{
    class Program
    {
        static void Main(string[] args)
        {
            UrunContext urunContext = new UrunContext();
            // List<Urun> uruns = new List<Urun> {
            // new Urun (){UrunAdi="samsung galaxy s6",fiyat=2000,stokAdedi=200},
            // new Urun (){UrunAdi="samsung galaxy s7",fiyat=3000,stokAdedi=300},
            // new Urun (){UrunAdi="samsung galaxy s8",fiyat=4000,stokAdedi=400},
            // new Urun (){UrunAdi="samsung galaxy s9",fiyat=5000,stokAdedi=500},
            // };
            // foreach (var urun in uruns)
            // {
            //     urunContext.Urunler.Add(urun);
            // }
            // urunContext.SaveChanges();
            // Console.WriteLine("işlem tamamlandı");
            //// Console.ReadLine();

            var kategoriler = urunContext.Kategoriler.ToList();
            var uruun = urunContext.Urunler.FirstOrDefault();

            foreach (var item in kategoriler)
            {
                Console.WriteLine("ktegori id : {0}  kategori adi : {1}", item.Id, item.KategoriAdi);

            }
            //Console.WriteLine("md");
            //var urun = urunContext.Kategoriler.Find(1);
            //Console.WriteLine("ktegori id : {0}  kategori adi : {1}", urun.Id, urun.KategoriAdi);
            var urun = urunContext.Kategoriler.Find(1);
            if (urun!=null)
            {
                urunContext.Kategoriler.Remove(urun);

            }
            //urunContext.Kategoriler.Remove(urun);


            foreach (var item in kategoriler)
            {
                Console.WriteLine("ktegori id : {0}  kategori adi : {1}", item.Id, item.KategoriAdi);

            }
            Console.ReadLine();
        }
    }
}
