using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio;
using Entidades;

namespace Usuario.Controllers
{
    public class ClienteController : Controller
    {

        Negousuario cli = new Negousuario();

        // GET: Cliente
        public ActionResult Index(int id)
        {
            return View(id);
        }

        public ActionResult Cahorros(int id)
        {
            return View(id);
        }



        public ActionResult Balance(int id)
        {
            var Cuentas = cli.Consultar_Balance(id);
            return View(Cuentas);
        }
    
    }
}