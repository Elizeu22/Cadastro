using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TamanhoPlaca.Models;

namespace TamanhoPlaca.Controllers
{
    public class PlacaController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}



        public IActionResult PlacaDimensao()
        {
            return View();
        }


        [HttpPost]
        public IActionResult PlacaDimensao(Placa reserva)
        {

            reserva.CalculaDimensao();


            return View(reserva);
        }




    }
}