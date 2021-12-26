using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;  

namespace entity_framework
{
    public class UrunContext:DbContext
    {
        //public UrunContext():base("UrunConnection")
        //{

        //}
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
