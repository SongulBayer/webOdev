using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_framework
{
    public class Urun
    {
        public  int Id { get; set; }
        public string UrunAdi { get; set; }
        public double fiyat { get; set; }
        public int stokAdedi { get; set; }
    }
}
