using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    [Table("TipoSanguineo")]
    public class TipoSanguineo
    {
        [Key]
        public int IdTipoSanguineo { get; set; }
        public string TipoSangue { get; set; }
    }
}