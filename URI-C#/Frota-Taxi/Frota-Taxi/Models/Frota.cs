using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frota_Taxi.Models
{
    public class Frota
{

        public decimal alcool { get; set; }
        public decimal gasolina { get; set; }
        public decimal rendimento_alcool { get; set; }
        public decimal rendimento_gasolina { get; set; }
        public decimal VerificaAlcool { get; set; }
        public decimal VerificaGasolina { get; set; }
        public string abastece { get; set; }
        public const decimal irrelevante = 5;




        public string VerificaConsumo()
        {
            VerificaAlcool = (alcool * rendimento_alcool)+irrelevante;
            VerificaGasolina = gasolina * rendimento_gasolina;

         

            if (VerificaAlcool < VerificaGasolina)
            {
              abastece = "Viavel Abastecer com Alcool";
            }

            else
            {
                abastece = "Viavel abastecer com Gasolina";
            }



            return abastece;


        }






    }
}
