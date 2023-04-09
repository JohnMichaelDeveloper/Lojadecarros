using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Loja_de_carros.Models
{
    [Table("Tabela de Cliente")]
    public class Cliente
    {

        [Display(Name = "Identificador")]
        public int Id { get; set; }


        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "Telefone")]
        public String Telefone { get; set; }

        [Display(Name = "E-mail")]
        public String Email { get; set; }
    }
}
