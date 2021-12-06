using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio;
namespace Usuario.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Negousuario negocio = new Negousuario();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Clientes()
        {
            var lista = negocio.ListClientes();
            return View(lista);
        }

        //[HttpPost]
        //public ActionResult Clientes()
        //{

        //    return View();
        //}
    }
}