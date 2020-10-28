using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Papel_Tesoura.Models
{
    public class Papel
{

        public string PrimeiraEscolha { get; set; }
        public string SegundaEscolha { get; set; }
        public string QuemGanhou { get; set; }
        public const string Rajesh = "Rajesh";
        public const string Sheldon = "Sheldon";
        public const string Empate = "Empate";
        public const string Erro = "Nao definido";
      
        
        




        public string Ganhador()
        {


            if ((PrimeiraEscolha.Contains("tesoura")|| PrimeiraEscolha.Contains("Tesoura")) && (SegundaEscolha.Contains("papel")|| SegundaEscolha.Contains("Papel")))
            {
                QuemGanhou = Rajesh;
            }

            else if ((PrimeiraEscolha.Contains("tesoura") || PrimeiraEscolha.Contains("Tesoura")) && (SegundaEscolha.Contains("tesoura") || SegundaEscolha.Contains("Tesoura")))
            {
                QuemGanhou = Empate;
            }

            else if ((SegundaEscolha.Contains("tesoura") || SegundaEscolha.Contains("Tesoura")) && (PrimeiraEscolha.Contains("papel") || PrimeiraEscolha.Contains("Papel")))
            {
                QuemGanhou = Sheldon;
            }


            else if ((PrimeiraEscolha.Contains("papel") || PrimeiraEscolha.Contains("Papel")) && (SegundaEscolha.Contains("papel") || SegundaEscolha.Contains("Papel")))
            {
                QuemGanhou = Empate;
            }



            else if ((PrimeiraEscolha.Contains("papel") || PrimeiraEscolha.Contains("Papel")) && (SegundaEscolha.Contains("pedra") || SegundaEscolha.Contains("Pedra")))
            {
                QuemGanhou = Rajesh;
            }

         

            else if ((SegundaEscolha.Contains("papel") || SegundaEscolha.Contains("Papel")) && (PrimeiraEscolha.Contains("pedra")|| PrimeiraEscolha.Contains("Pedra")))
            {
                QuemGanhou = Sheldon;
            }

            else if ((PrimeiraEscolha.Contains("pedra") || PrimeiraEscolha.Contains("Pedra")) && (SegundaEscolha.Contains("pedra") || SegundaEscolha.Contains("Pedra")))
            {
                QuemGanhou = Empate;
            }






            else if ((PrimeiraEscolha.Contains("pedra") || PrimeiraEscolha.Contains("Pedra")) && (SegundaEscolha.Contains("lagarto") || SegundaEscolha.Contains("Lagarto")))
            {
                QuemGanhou = Rajesh;
            }


            else if ((SegundaEscolha.Contains("pedra") || SegundaEscolha.Contains("Pedra")) && (PrimeiraEscolha.Contains("lagarto") || PrimeiraEscolha.Contains("Lagarto")))
            {
                QuemGanhou = Sheldon;
            }

            else if ((PrimeiraEscolha.Contains("lagarto") || PrimeiraEscolha.Contains("Lagarto")) && (SegundaEscolha.Contains("lagarto") || SegundaEscolha.Contains("Lagarto")))
            {
                QuemGanhou = Empate;
            }



            else if ((PrimeiraEscolha.Contains("lagarto") || PrimeiraEscolha.Contains("Lagarto")) && (SegundaEscolha.Contains("spock") || SegundaEscolha.Contains("Spock")))
            {
                QuemGanhou = Rajesh;
            }


            else if ((SegundaEscolha.Contains("lagarto") || SegundaEscolha.Contains("Lagarto")) && (PrimeiraEscolha.Contains("spock") || PrimeiraEscolha.Contains("Spock")))
            {
                QuemGanhou = Sheldon;
            }

            else if ((PrimeiraEscolha.Contains("spock") || PrimeiraEscolha.Contains("Spock")) && (SegundaEscolha.Contains("spock") || SegundaEscolha.Contains("Spock")))
            {
                QuemGanhou = Empate;
            }




            else if ((PrimeiraEscolha.Contains("spock") || PrimeiraEscolha.Contains("Spock")) && (SegundaEscolha.Contains("tesoura") || SegundaEscolha.Contains("Tesoura")))
            {
                QuemGanhou = Rajesh;
            }


            else if ((SegundaEscolha.Contains("spock") || SegundaEscolha.Contains("Spock")) && (PrimeiraEscolha.Contains("tesoura") || PrimeiraEscolha.Contains("Tesoura")))
            {
                QuemGanhou = Sheldon;
            }




            else if ((PrimeiraEscolha.Contains("tesoura") || PrimeiraEscolha.Contains("Tesoura")) && (SegundaEscolha.Contains("lagarto")|| SegundaEscolha.Contains("Lagarto")))
            {
                QuemGanhou = Rajesh;
            }


            else if ((SegundaEscolha.Contains("tesoura") || SegundaEscolha.Contains("Tesoura")) && (PrimeiraEscolha.Contains("lagarto")|| PrimeiraEscolha.Contains("Lagarto")))
            {
                QuemGanhou = Sheldon;
            }

        




            else if ((PrimeiraEscolha.Contains("lagarto") || PrimeiraEscolha.Contains("Lagarto")) && (SegundaEscolha.Contains("papel")|| SegundaEscolha.Contains("Papel")))
            {
                QuemGanhou = Rajesh;
            }


            else if ((SegundaEscolha.Contains("lagarto") || SegundaEscolha.Contains("Lagarto")) && (PrimeiraEscolha.Contains("papel") || PrimeiraEscolha.Contains("Papel")))
            {
                QuemGanhou = Sheldon;
            }




            else if ((PrimeiraEscolha.Contains("papel") || PrimeiraEscolha.Contains("Papel")) && (SegundaEscolha.Contains("spock") || SegundaEscolha.Contains("Spock")))
            {
                QuemGanhou = Rajesh;
            }


            else if ((SegundaEscolha.Contains("papel") || SegundaEscolha.Contains("Papel")) && (PrimeiraEscolha.Contains("spock") || PrimeiraEscolha.Contains("Spock")))
            {
                QuemGanhou = Sheldon;
            }




            else if ((PrimeiraEscolha.Contains("spock") || PrimeiraEscolha.Contains("Spock")) && (SegundaEscolha.Contains("pedra")|| SegundaEscolha.Contains("Pedra")))
            {
                QuemGanhou = Rajesh;
            }


            else if ((SegundaEscolha.Contains("spock") || SegundaEscolha.Contains("Spock")) && (PrimeiraEscolha.Contains("pedra") || PrimeiraEscolha.Contains("Pedra")))
            {
                QuemGanhou = Sheldon;
            }




            else if ((PrimeiraEscolha.Contains("pedra") || PrimeiraEscolha.Contains("Pedra")) && (SegundaEscolha.Contains("tesoura")|| SegundaEscolha.Contains("Tesoura")))
            {
                QuemGanhou = Rajesh;
            }


            else if ((SegundaEscolha.Contains("pedra") || SegundaEscolha.Contains("Pedra")) && (PrimeiraEscolha.Contains("tesoura") || PrimeiraEscolha.Contains("Tesoura")))
            {
                QuemGanhou = Sheldon;
            }


         


            return QuemGanhou;


        }


      




    }
}
