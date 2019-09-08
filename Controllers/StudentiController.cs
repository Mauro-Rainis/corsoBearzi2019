using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorsoBearziWebAppMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace CorsoBearziWebAppMvc.Controllers
{
    public class StudentiController : Controller
    {
        private readonly IStudentiService myStudentiService;
        
        public StudentiController(IStudentiService _studentiService)
        {
            myStudentiService = _studentiService;
        }

        public IActionResult Index()
        {
            return View(myStudentiService.GetAll());
        }


    }
}