using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Papel_Tesoura.Models;

namespace Papel_Tesoura.Controllers
{
    public class SpockController : Controller
    {
       

        public IActionResult Spock()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Spock(Papel papel)
        {

            papel.Ganhador();


            return View(papel);
        }










    }
}