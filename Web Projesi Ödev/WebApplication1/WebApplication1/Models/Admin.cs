using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Profil { get; set; }
        public string Unvan { get; set; }
        public string Acıklama { get; set; }
        public string isim { get; set; }
    }
}
