using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteCibergestion.Models;
using TesteCibergestion.Banco;

namespace TesteCibergestion.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(DadoCadastral Cadastro)
        {

            using (CadastroUsuariocs DadoCliente = new CadastroUsuariocs())
            {
                DadoCliente.Create(Cadastro);



                return RedirectToAction("Index");
            }
        }


        public IActionResult ListarUsuario()
        {

            using (CadastroUsuariocs DadoCli = new CadastroUsuariocs())
            {
                List<DadoCadastral> RetornaLista = DadoCli.ListaCliente();


                return View(RetornaLista);

            }
        }


      


        public IActionResult Edit(int id)
        {
            DadoCadastral dados = new DadoCadastral();
            using (CadastroUsuariocs DadoCli = new CadastroUsuariocs())
            {
                DadoCli.AtualizarDado(id);
               

                return View();
            }
        }


        [HttpPost]
        public IActionResult Edit([Bind(include: "Id,Nome,Telefone,QtdeProduto,Tipo")]DadoCadastral form)
        {
            DadoCadastral procura = new DadoCadastral();

            procura.Id = form.Id;
            procura.Nome = form.Nome;
            procura.Telefone = form.Telefone;
            procura.Tipo = form.Tipo;
          

            return View();
        }





        public ActionResult Delete(int id)

        {

            try
            {
                var cadastro = new CadastroUsuariocs();

                cadastro.Deletar(id);
                

                return RedirectToAction("Index");
            }

            catch
            {
                return View();
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
