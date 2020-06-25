using API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API.DAL
{
    public class UsuarioDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static void CadastrarUsuario(Usuario usuario)
        {
            ctx.Usuario.Add(usuario);
            ctx.SaveChanges();
        }

        public static IQueryable<Usuario> RetornarUsuarios()
        {
            return ctx.Usuario;
        }

        public static Usuario RetornarUsuarioPorId(int id)
        {
            return ctx.Usuario.Find(id);
        }
        public static int RetornarPadAcessPorId(string login)
        {
            return ctx.Usuario.Where(x => x.Email == login).Select(x => x.PadraoAcesso).FirstOrDefault();
        }

        public static int ValidaLogin(string login, string senha)
        {
            if (ctx.Usuario.Where(x => x.Email == login && x.Senha == senha).FirstOrDefault() != null)
            {
                return ctx.Usuario.Where(x => x.Email == login && x.Senha == senha).FirstOrDefault().idUsuario;
            }
            else
            {
                return 0;
            }

        }

        public static void RemoverUsuario(int id)
        {
            Usuario u = RetornarUsuarioPorId(id);
            ctx.Usuario.Remove(u);
            ctx.SaveChanges();
        }

        public static void AlterarUsuario(Usuario usuario, int id)
        {
            Usuario u = RetornarUsuarioPorId(id);

            u.Nome = usuario.Nome;
            u.Login = usuario.Login;
            u.Senha = usuario.Senha;
            u.Cpf = usuario.Cpf;
            u.Email = usuario.Email;
            u.Fone = usuario.Fone;
            u.PadraoAcesso = usuario.PadraoAcesso;

            ctx.Entry(u).State = EntityState.Modified;
            ctx.SaveChanges();
        }

    }
}