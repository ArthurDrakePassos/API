using API.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpPost]
        public int ValidaLogin(string login, string senha)
        {
            return Facade.ValidaLogin(login, senha);
        }

        [HttpPost]
        public int RetornarPadAcess(string login)
        {
            return Facade.RetornarPadAcess(login);
        }
    }
}
