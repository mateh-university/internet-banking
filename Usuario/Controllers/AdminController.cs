using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio;
using Entidades;

namespace Usuario.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Negousuario negocio = new Negousuario();
        public ActionResult Index(int id)
        {
            return View(id);
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
                return RedirectToAction("Clientes");
            }
            else
            {
                ViewBag.Message = g;
                return RedirectToAction("Clientes");
            }
        }
        [HttpPut]
        public ActionResult Clientes(Cliente c)
        {
            //var c = new Cliente();
            //c.ID = ID;
            //c.Nombre = nombre;
            //c.Correo = correo;
            //c.Passw = clave;
             negocio.EditCliente(c);

            return RedirectToAction("Clientes");
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

        public ActionResult Cuentas()
        {
            var lista = negocio.ListCuentas();
            return View(lista);
        }


        public ActionResult Tarjetas()
        {
            var lista = negocio.ListTarjetas();
            return View(lista);
        }

        public ActionResult Prestamos()
        {
            var lista = negocio.ListPrestamos();
            return View(lista);
        }
        //[HttpPost]
        //public ActionResult Cuentas(string nombre, string correo, string clave, string clave2)
        //{
        //    var g = negocio.Crear_cliente(nombre, correo, clave, clave2);

        //    if (g == "Agregado")
        //    {
        //        ViewBag.Message = "El cliente ha sido creada con exito";
        //        return RedirectToAction("Clientes");
        //    }
        //    else
        //    {
        //        ViewBag.Message = g;
        //        return RedirectToAction("Clientes");
        //    }
    }
    }

