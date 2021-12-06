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
                ViewBag.Message =  user.Tipo;
 
                return RedirectToAction("Index", user.Tipo == "admin" ? "Admin" : "Cliente",new {id = user.ID_user });
            }

            else
            {
                ViewBag.Message = "Datos Incorrectos";
                return View();
            }
        }

        public ActionResult Cliente()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult Registro(string nombre, string correo, string clave, string clave2)
        {
            var g = cli.Crear_cliente(nombre, correo, clave, clave2);

            if(g == "Agregado")
            {
                ViewBag.Message = "Tu cuenta ha sido creada con exito";
                return View("login");
            }
            else
            {
                ViewBag.Message = g;
                return View();
            }

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