using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Carrega.Models;

namespace Carrega.Controllers
{
    public class CarregaController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

   
        public IActionResult Carregando()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Carregando(Circuito carregando)
        {
            carregando.ConverteBinario();

            return View(carregando);
        }






    }
}