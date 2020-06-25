using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DAL
{
    public class Facade
    {
        public static int RetornarPadAcess(string login)
        {
            int padaces = DAL.UsuarioDAO.RetornarPadAcessPorId(login);
            return padaces;
        }

        public static int ValidaLogin(string login, string senha)
        {
            int valida = DAL.UsuarioDAO.ValidaLogin(login, senha);
            return valida;
        }

    }
}