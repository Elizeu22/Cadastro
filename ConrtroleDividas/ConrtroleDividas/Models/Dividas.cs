using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConrtroleDividas.Models
{
    public class Dividas
    {
        
        public int id { get; set; }
      
        public string Nome { get; set; }
       

        public decimal ValorDivida { get; set; }
       
   
        public int QtdeProduto { get; set; }
      
       
        public string DescricaoProduto { get; set; }
       
       
        public decimal ValorProduto { get; set; }


    }
}
