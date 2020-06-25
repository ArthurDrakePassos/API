using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    [Table("Cachorro")]
    public class Cachorro
    {
        [Key]
        public int IdCachorro { get; set; }
        public string NomeCachorro { get; set; }
        public int Idade { get; set; }
        public string Raca { get; set; }
        public double Peso { get; set; }
        public double Tamanho { get; set; }
        public string Doenca { get; set; }
        public string Sexo { get; set; }
        public string Cor { get; set; }
        public string TipoSanguineo { get; set; }
        public int IdUsuario { get; set; }

    }
}