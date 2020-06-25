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
    public class ClinicasController : ApiController
    {
        private static Context db = SingletonContext.GetInstance();

        // GET: api/Clinicas
        public IQueryable<Clinica> GetClinica()
        {
            return ClinicaDAO.RetornarClinicas();
        }

        // GET: api/Clinicas/5
        [ResponseType(typeof(Clinica))]
        public Clinica GetClinica(int id)
        {
            return ClinicaDAO.RetornarClinicaPorId(id);
        }

        [HttpPut]
        // PUT: api/Clinicas/5
        [ResponseType(typeof(void))]
        public void AlteraClinica(Clinica clinica, int id)
        {
            ClinicaDAO.AlterarClinica(clinica, id);
        }

        // POST: api/Clinicas
        [ResponseType(typeof(Clinica))]
        public void PostUsuario(Clinica clinica)
        {
            ClinicaDAO.CadastrarClinica(clinica);
        }

        // DELETE: api/Clinicas/5
        [ResponseType(typeof(Clinica))]
        public void DeleteClinica(int id)
        {
            ClinicaDAO.RemoverClinica(id);
        }
    }
}