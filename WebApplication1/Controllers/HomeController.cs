using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly IZaposleniService service;

        
        public HomeController(IZaposleniService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("Zap")]
        public IActionResult Zaposleni()
        {
            return View("Zaposleni", service.GetAll().ToList());
        }

        [HttpGet]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpPost]
        public IActionResult Contact([FromBody]Zaposleni zaposleni)
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        [HttpPost]
        public IActionResult Privacy([FromForm]Zaposleni zaposleni)
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
