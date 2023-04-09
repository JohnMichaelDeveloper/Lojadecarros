using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loja_de_carros.Models
{
    public class Venda
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Modelo")]
        public String Modelo { get; set; }

        [Display(Name = "Vendedor")]
        public String Vendedor { get; set; }

        [Display(Name = "Valor Venda")]
        public float ValorVenda { get; set; }
    }
}
