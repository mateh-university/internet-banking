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

        [HttpPost]
        public ActionResult Clientes(string nombre, string correo, string clave, string clave2)
        {
            var g = negocio.Crear_cliente(nombre, correo, clave, clave2);

            if (g == "Agregado")
            {
                ViewBag.Message = "El cliente ha sido creada con exito";
                return View();
            }
            else
            {
                ViewBag.Message = g;
                return View();
            }
        }
        [HttpPut]
        public ActionResult Clientes(int ID, string nombre, string correo, string clave, string clave2)
        {
            //var g = negocio.Crear_cliente(nombre, correo, clave, clave2);

            //if (g == "Agregado")
            //{
            //    ViewBag.Message = "El cliente ha sido creada con exito";
            //    return View();
            //}
            //else
            //{
            //    ViewBag.Message = g;
                return View();
            //}
        }

        [HttpDelete]
        public ActionResult Clientes(int ID)
        {
            //var g = negocio.Crear_cliente(nombre, correo, clave, clave2);

            //if (g == "Agregado")
            //{
            //    ViewBag.Message = "El cliente ha sido creada con exito";
            //    return View();
            //}
            //else
            //{
              //  ViewBag.Message = g;
               return View();
            //}
        }
    }

}