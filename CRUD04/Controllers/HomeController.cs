using CRUD04.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CRUD03.Models;
using ServiceReference1;

namespace CRUD04.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public string EncodeStrToBase64(string valor)
        {
            byte[] myByte = System.Text.Encoding.UTF8.GetBytes(valor);
            string myBase64 = Convert.ToBase64String(myByte);
            return myBase64;
        }
        public static string DecodeBase64ToString(string valor)
        {
            byte[] myBase64ret = Convert.FromBase64String(valor);
            string myStr = System.Text.Encoding.UTF8.GetString(myBase64ret);
            return myStr;
        }


        public IActionResult Index()
        {
            string x, y, z, p;
            x = DecodeBase64ToString(string x);



        using (var contex = new CRUD03.Models.cer_addendasContext())
        {
                
                
                var b = contex.Addendas.Where(b => b.Usuario == "jyyk");


                foreach (var item in b.ToList()) {

                    Console.WriteLine(item);
                    MessageRequest input = new MessageRequest();
                    input.operacion(x);
                    input.rfcEmisor(y);
                    input.xmlBase64(z);
                    input.apiKey(p);

                    var send = input.xmlBase64(input);
                    WsFactClient ProcessDocument = new WsFactClient();
                    var c = ProcessDocument.ProcessDocumentAsyn(send);
                    


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
