using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Context : DbContext
    {
            public Context() : base("DbProjCachoSangue")
            {

            }

            public DbSet<Usuario> Usuario { get; set; }
            public DbSet<Cachorro> Cachorro { get; set; }
            public DbSet<Clinica> Clinica { get; set; }
            public DbSet<Doacao> Doacao { get; set; }
            public DbSet<Relatorio> Relatorio { get; set; }
            public DbSet<TipoSanguineo> TipoSanguineo { get; set; }
    }
}