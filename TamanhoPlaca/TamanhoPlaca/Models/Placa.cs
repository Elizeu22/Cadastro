using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TamanhoPlaca.Models
{
    public class Placa
    {

        public int Dimensao01 { get; set; }
        public int Dimensao02 { get; set; }

        public int Dimensao03 { get; set; }
        public int Dimensao04 { get; set; }
         
        public string DimensaoResultado { get; set; }
     


        public string CalculaDimensao()
        {

            if(Dimensao01 >= Dimensao03 && Dimensao02 >= Dimensao04)
            {
                DimensaoResultado = "Sim";
            }

            else
            {
                DimensaoResultado = "Nao";
            }


            return DimensaoResultado;

        }

        

    }


    
}
