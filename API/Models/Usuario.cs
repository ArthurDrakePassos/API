using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Models
{
    [Table("Usuario")]
    public class Usuario
    {
            [Key]
            public int idUsuario { get; set; }

            public string Nome { get; set; }

            public string Login { get; set; }

            public string Senha { get; set; }

            public string Cpf { get; set; }

            public string Email { get; set; }

            public string Fone { get; set; }

            public int PadraoAcesso { get; set; }
    }
}