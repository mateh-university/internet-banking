using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Negocio;

namespace Usuario.Controllers
{
    public class HomeController : Controller
    {

        Negousuario cli = new Negousuario();
        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(String correo, string clave)
        {

            var user = cli.validar(correo, clave);


            if (user != null)
            {
                return View("Registro");
            }

            else
            {

                ViewBag.Mensaje = "Datos Incorrectos";
                return View();
            }
        }

        public ActionResult Cliente()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Registro()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult InsertCuenta()
        {
            return View();
        }
    }
}