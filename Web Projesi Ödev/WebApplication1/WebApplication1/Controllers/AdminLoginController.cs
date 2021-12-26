using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.data;


namespace WebApplication1.Controllers
{
    public class AdminLoginController : Controller
    {
       [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Admin a)
        {
            KediDbContext k = new KediDbContext();
            var adminuserinfo = k.Admin.FirstOrDefault(x => x.isim == a.isim && x.Unvan == a.Unvan);
            if(adminuserinfo != null)
            {
                //sayfa açılacak
                return RedirectToAction("Index", "AdminLogin");
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
