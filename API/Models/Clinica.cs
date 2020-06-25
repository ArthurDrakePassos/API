using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    [Table("Clinica")]
    public class Clinica
    {
        [Key]
        public int IdClinica { get; set; }
        public string NomeClinica { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
    }
}