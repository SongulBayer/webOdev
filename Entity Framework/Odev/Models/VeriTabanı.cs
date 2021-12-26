using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odev.Models
{
    public class VeriTabanı
    {
        public static List<Urun> _liste; //elemanları Urun tipinde olan bir list oluşturup adına  _liste dedik.

        static VeriTabanı()//constructor oluşturduk.Class çağrıldığında ilk çalışacak yer burası
        {
            _liste = new List<Urun>
            {
                new Urun {id=1,adet=5,model="samsung s6",fiyat=4000},
                new Urun {id=2,adet=7,model="samsung s7",fiyat=5000},
                new Urun {id=3,adet=10,model="iphone 10",fiyat=9500},
                new Urun {id=4,adet=7,model="iphone 11",fiyat=1300},
            };
        }
        public static List<Urun> uruns //bu bir metot değil değişkendir
        {//biz uruns adlı değişkeni çağırdığımızda listenin elemanları gelicek.
            get { return _liste;}
        }
        public static void elemanEkle(Urun entity)
        {
            _liste.Add(entity);
        }
        public static Urun urunListele(int urunid)
        {
            Urun entity = null;
            foreach (var item in _liste)
            {
                if (item.id==urunid)
                {
                    entity = item;
                }
            }
            return entity;//geri dönüş Urun tipinde so yukarıda void yerine Urun yazman gerek.
        }
       public static int sayi()
        {
            return _liste.Count();
        }
    }
}
