using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frota_Taxi.Models;

namespace Frota_Taxi.Controllers
{
    public class FrotaTaxiController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}


        public IActionResult Frota()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Frota(Frota nova)
        {
            nova.VerificaConsumo();

            return View(nova);
        }








    }
}