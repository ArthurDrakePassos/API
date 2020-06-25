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
    public class CachorroesController : ApiController
    {
        private static Context db = SingletonContext.GetInstance();

        // GET: api/Cachorroes
        public IQueryable<Cachorro> GetCachorro()
        {
            return CachorroDAO.RetornarCachorros();
        }

        // GET: api/Cachorroes/5
        [ResponseType(typeof(Cachorro))]
        public Cachorro GetCachorro(int id)
        {
            return CachorroDAO.RetornarCachorroPorId(id);
        }

        [HttpPut]
        // PUT: api/Cachorroes/5
        [ResponseType(typeof(void))]
        public void AlteraCachorro(Cachorro cachorro, int id)
        {
            CachorroDAO.AlterarCachorro(cachorro, id);
        }

        // POST: api/Cachorroes
        [ResponseType(typeof(Cachorro))]
        public void PostUsuario(Cachorro cachorro)
        {
            CachorroDAO.CadastrarCachorro(cachorro);
        }

        // DELETE: api/Cachorroes/5
        [ResponseType(typeof(Cachorro))]
        public void DeleteCachorro(int id)
        {
            CachorroDAO.RemoverCachorro(id);
        }
    }
}