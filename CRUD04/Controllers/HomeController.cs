using CRUD04.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CRUD03.Models;

namespace CRUD04.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           

        using (var contex = new CRUD03.Models.cer_addendasContext())
        {
               
                var b = contex.Addendas.Where(b => b.Estado == false);
                

                
                foreach (var item in b.ToList()) {

                    Console.WriteLine(item.Estado = true);
                    
                }
                ViewData["Usuario"] = b;
                ViewBag.Usuario = b;
                return View(ViewBag);
                
            }
            
    }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
