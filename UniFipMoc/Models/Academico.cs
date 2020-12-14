using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniFipMoc.Models
{
    public class Academico
    {
        [Key]
        public int Id { get; set; }
        public int CPF { get; set; }
        public string Nome { get; set; }
        public DateTime Data_nascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}