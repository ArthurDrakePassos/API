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

            string retorno = "";
            if (valida != 0 && padaces == 0)
            {
                retorno = "mainuser.php";
            }else if(valida != 0 && padaces == 1)
            {
                retorno = "mainadmin.php";
            }
            else
            {
                retorno = "login.php";
            }

            return retorno;
        }

    }
}