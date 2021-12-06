using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio;


namespace Usuario.Controllers
{
    public class ClienteController : Controller
    {

        Negousuario cli = new Negousuario();

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cahorros()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cahorros(string id ,int monto)
        {

            return View();
        }
    }
}