using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CorsoBearziWebAppMvc.Models;
using CorsoBearziWebAppMvc.Services;

namespace CorsoBearziWebAppMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentiService myStudentiService;

        public HomeController(IStudentiService _studentiService)
        {
            myStudentiService = _studentiService;
        }
        public IActionResult Index()
        {
            var lista = myStudentiService.GetAll();
            return View(lista);
        }

        public IActionResult Docente()
        {
            return View();
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
