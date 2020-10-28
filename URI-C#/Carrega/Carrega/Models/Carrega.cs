using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrega.Models
{
    public class Circuito
    {
        public int Bit1 { get; set; }
        public int Bit2 { get; set; }
        public int Bit3 { get; set; }
        public int Bit4 { get; set; }
        public int Bit5 { get; set; }


        public int ConverteBinario()
        {

            Bit1 = Bit2 - Bit3;

            return Bit1;

        }



    }
}

