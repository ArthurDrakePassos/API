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
    public class UsuariosController : ApiController
    {
        private static Context db = SingletonContext.GetInstance();

        // GET: api/Usuarios
        public IQueryable<Usuario> GetUsuario()
        {
            return UsuarioDAO.RetornarUsuarios();
        }

        // GET: api/Usuarios/5
        [ResponseType(typeof(Usuario))]
        public Usuario GetUsuario(int id)
        {
            return UsuarioDAO.RetornarUsuarioPorId(id);
        }

        [HttpPut]
        // PUT: api/Usuarios/5
        [ResponseType(typeof(void))]
        public void AlteraUsuario(int id, Usuario usuario)
        {
            UsuarioDAO.AlterarUsuario(usuario, id);
        }

        // POST: api/Usuarios
        [ResponseType(typeof(Usuario))]
        public void PostUsuario(Usuario usuario)
        {
            UsuarioDAO.CadastrarUsuario(usuario);
        }

        // DELETE: api/Usuarios/5
        [ResponseType(typeof(Usuario))]
        public void DeleteUsuario(int id)
        {
            UsuarioDAO.RemoverUsuario(id);
        }
    }
}