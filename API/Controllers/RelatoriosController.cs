using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using API.DAL;
using API.Models;

namespace API.Controllers
{
    public class RelatoriosController : ApiController
    {
        private static Context db = SingletonContext.GetInstance();

        // GET: api/Relatorios
        public IQueryable<Relatorio> GetRelatorio()
        {
            return RelatorioDAO.RetornarRelatorios();
        }

        // GET: api/Relatorios/5
        [ResponseType(typeof(Relatorio))]
        public Relatorio GetRelatorio(int id)
        {
            return RelatorioDAO.RetornarRelatorioPorId(id);
        }

        [HttpPut]
        // PUT: api/Relatorios/5
        [ResponseType(typeof(void))]
        public void AlteraRelatorio(Relatorio relatorio, int id)
        {
            RelatorioDAO.AlterarRelatorio(relatorio, id);
        }

        // POST: api/Relatorios
        [ResponseType(typeof(Relatorio))]
        public void PostRelatorio(Relatorio relatorio)
        {
            RelatorioDAO.CadastrarRelatorio(relatorio);
        }

        // DELETE: api/Relatorios/5
        [ResponseType(typeof(Relatorio))]
        public void DeleteRelatorio(int id)
        {
            RelatorioDAO.RemoverRelatorio(id);
        }
    }
}