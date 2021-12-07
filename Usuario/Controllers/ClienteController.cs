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

        public ActionResult Tarjeta(int id)
        {
            var Cuentas = cli.Consultar_Tarjeta(id);
            return View(Cuentas);
        }

        public ActionResult Prestamo(int id)
        {
            var Cuentas = cli.Consultar_Prestamo(id);
            return View(Cuentas);
        }
        [HttpPost]
        public ActionResult Retitocuenta(int monto,int id)
        {
            var Cuentas = cli.Retirocahorros(id,monto);
            return View(Cuentas);
        }
        
        public ActionResult Retitocuenta()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AvanceTarjeta(int monto, int id)
        {
            var Cuentas = cli.AvanceTarjeta(id, monto);
            return View(Cuentas);
        }
        public ActionResult AvanceTarjeta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PagoTarjeta(int monto, int id)
        {
            var Cuentas = cli.Pagotarjeta(id, monto);
            return View(Cuentas);
        }
        public ActionResult PagoTarjeta()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PagoPrestamo(int monto, int id)
        {
            var Cuentas = cli.PagoPrestamo(id, monto);
            return View(Cuentas);
        }
        public ActionResult PagoPrestamo()
        {
            return View();
        }

    }
}