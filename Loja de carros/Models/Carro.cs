using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Loja_de_carros.Models
{
    [Table("Carro do Ano")]
    public class Carro
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Display(Name = "Ano")]
        public string Ano { get; set; }

        [Display(Name = "Combustivel")]
        public string Tipo { get; set; }

        [Display(Name = "Valor")]
        public float Preco { get; set; }
    }
}
