using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    [Table("Relatorio")]
    public class Relatorio
    {
        [Key]
        public int IdRelatorio { get; set; }
        public int IdDoacao { get; set; }
        public int IdCachorroDoador { get; set; }
        public int IdCachorroReceptor { get; set; }
        public string Descricao { get; set; }
    }
}