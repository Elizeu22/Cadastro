using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TesteCibergestion.Models
{
    public class DadoCadastral
    {

        public int Id { get; set; }


        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        public string Nome { get; set; }

        [Phone]
        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo Tipo é obrigatório.")]
        public string Tipo { get; set; }

     

    }


    public enum Tipo
    {
        Celular,
        Residencial,
        Trabalho,
        WhatsApp
    }


}

