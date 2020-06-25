using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    [Table("Doacao")]
    public class Doacao
    {
        [Key]
        public int IdDoacao { get; set; }
        public int IdUsuarioDoador { get; set; }
        public int IdCachorroDoador { get; set; }
        public int IdUsuarioReceptor { get; set; }
        public int IdCachorroReceptor { get; set; }
        public int IdClina { get; set; }
        public DateTime Data { get; set; }
        public string Observacao { get; set; }
    }
}