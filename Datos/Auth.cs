using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Datos
{
    public class Auth
    {
        DBProEntities1 db = new DBProEntities1();
        public Inicio_Result IniciarSesion(String correo, String clave)
        {

            return db.Inicio(correo, clave).FirstOrDefault();
        }


        public Cliente Crear_cliente(Cliente cliente)
        {

            var existe = db.Usuario.FirstOrDefault(a => a.Correo == cliente.Correo);

            if (existe == null)
            {
                Usuario _usuario = new Usuario();
                _usuario.Nombre = cliente.Nombre;
                _usuario.Correo = cliente.Correo;
                _usuario.Passw = cliente.Passw;
                _usuario.Tipo = "cliente";

                var x = db.Usuario.Add(_usuario);
                cliente.ID_user = x.ID;
                var Cliente_agregado = db.Cliente.Add(cliente);
                db.SaveChanges();
                return Cliente_agregado;
            }

            return null;

        }
        public Cuenta_Ahorros Cahorros(Cliente cliente)
        {
            Cuenta_Ahorros ahorros = new Cuenta_Ahorros();

            ahorros.ID_propietario = cliente.ID;


            var x = db.Cuenta_Ahorros.Add(ahorros);
            db.SaveChanges();

            return ahorros;


        }

        public List<Cliente> MostrarCliente()
        {
            return db.Cliente.ToList();
        }

        public List<Cuenta_Ahorros> MostrarCuentas()
        {
            return db.Cuenta_Ahorros.ToList();
        }

        public List<Tarjeta_credito> MostrarTarjetas()
        {
            return db.Tarjeta_credito.ToList();
        }

        public List<Prestamo> MostrarPrestamos()
        {
            return db.Prestamo.ToList();
        }

        public List<ConsultaCahorros_Result> Consultar_Balance(int id)
        {

            return db.ConsultaCahorros(id).ToList();
        }

        public List<ConsultaTarjeta_Result> Consultar_Tarjeta(int id)
        {

            return db.ConsultaTarjeta(id).ToList();
        }
        public List<ConsultaPrestamo_Result> Consultar_Prestamo(int id)
        {

            return db.ConsultaPrestamo(id).ToList();
        }

        public int Retirocahorros(int id, int monto)
        {
            return db.RetiroCahorros(id, monto);
        }

        public int AvanceTarjeta(int id, int monto)
        {
            return db.AvanceTarjeta(id, monto);
        }
        public int Pagotarjeta(int id, int monto)
        {
            return db.PagoTarjeta(id, monto);
        }
        public int PagoPrestamo(int id, int monto)
        {
            return db.PagoPrestamo(id, monto);
        }



        public void EditCliente(Cliente c)
        {

            var cliente = db.Cliente.Where(x => x.ID == c.ID).First<Cliente>();
            cliente.Nombre = c.Nombre;
            cliente.Correo = c.Correo;
            cliente.Passw = c.Correo;
            db.SaveChanges();
        }


    }
}
