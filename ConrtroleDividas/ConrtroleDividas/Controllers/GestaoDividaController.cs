using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConrtroleDividas.Repositorio;
using ConrtroleDividas.Models;


namespace ConrtroleDividas.Controllers
{
    public class GestaoDividaController : Controller
    {
        // GET: GestaoDivida


        public IActionResult ListarDividas()
        {
            var DividaRepositorio = new GestaoDividas();
            ModelState.Clear();

            return View(DividaRepositorio.SelecionarTodos());
        }


        public IActionResult CadastrarDivida()
        {
            return View();
            
        }

        [HttpPost]
        public IActionResult CadastrarDivida(Dividas CadastroDivida)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var DividaRepositorio = new GestaoDividas();

                    if (DividaRepositorio.CadastrarDivida(CadastroDivida))
                    {
                        ViewBag.Message = "Cadastrado com sucesso";
                    }
                }

                //return View();
                return RedirectToAction("CadastrarDivida");
            }
            catch
            {
                return View();
            }

        }



       
        public IActionResult AtualizarDivida(int id)
        {
           
            try
            {
        
                var SelecionaDivida = new GestaoDividas();

                return View(SelecionaDivida.SelecionarTodos().Find(Dividas => Dividas.id==id));
               

            }
            catch
            {
                return NotFound();
            }

        }



        [HttpPost]
  
        public IActionResult AtualizarDivida(Dividas AtualizadoDivida)
        {
           
            try
            {
               

                var DividaRepositorio = new GestaoDividas();

                DividaRepositorio.AtualizarDivida(AtualizadoDivida);



                return RedirectToAction("ListarDividas");


            }
            catch
            {
                return NotFound();
            }

        }



        public IActionResult ExcluirDivida(int id)
        {
            try
            {

                var DividaRepositorio = new GestaoDividas();


                if (DividaRepositorio.ExcluirDivida(id))
                {
                    ViewBag.AlertMsg = "Excluido com Sucesso";
                }

                return RedirectToAction("ListarDividas");

            }
            catch
            {
                return View();
            }

        }






    }

}


    
