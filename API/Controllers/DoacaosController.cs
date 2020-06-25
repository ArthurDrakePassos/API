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
    public class DoacaosController : ApiController
    {
        private static Context db = SingletonContext.GetInstance();

        // GET: api/Doacaos
        public IQueryable<Doacao> GetDoacao()
        {
            return DoacaoDAO.RetornarDoacoes();
        }

        // GET: api/Doacaos/5
        [ResponseType(typeof(Doacao))]
        public Doacao GetDoacao(int id)
        {
            return DoacaoDAO.RetornarDoacaoPorId(id);
        }

        [HttpPut]
        // PUT: api/Doacaos/5
        [ResponseType(typeof(void))]
        public void AlteraDoacao(Doacao doacao, int id)
        {
            DoacaoDAO.AlterarDoacao(doacao, id);
        }

        // POST: api/Doacaos
        [ResponseType(typeof(Doacao))]
        public void PostDoacao(Doacao doacao)
        {
            DoacaoDAO.CadastrarDoacao(doacao);
        }

        // DELETE: api/Doacaos/5
        [ResponseType(typeof(Doacao))]
        public void DeleteDoacao(int id)
        {
            DoacaoDAO.RemoverDoacao(id);
        }
    }
}