using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DAL
{
    public class Facade
    {
        public static string ValidaLogin(string login, string senha)
        {
            int valida = DAL.UsuarioDAO.ValidaLogin(login, senha);
            int padaces = DAL.UsuarioDAO.RetornarPadAcessPorId(login);

            string concat = Convert.ToString(valida) + "/" + Convert.ToString(padaces);

            return concat;
        }

    }
}