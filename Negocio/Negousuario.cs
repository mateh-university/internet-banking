using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class Negousuario
    {

        Auth auth = new Auth();
        public Inicio_Result validar(string correo, string clave)
        {
            return auth.IniciarSesion(correo, clave);
        }

        public string Crear_cliente(string nombre, string correo, string clave, string clave2) 
        {

            if(clave == clave2)
            {
                Cliente cliente = new Cliente();

                cliente.Nombre = nombre;
                cliente.Correo = correo;
                cliente.Passw = clave;

                var y = auth.Crear_cliente(cliente);

                return y != null ? "Agregado" : "Ya existe";
            }
            else
            {
                return "La segunda clave no coincide con la primera"; 
            }

        }

        public void Cliente_cuenta(Cliente cliente ,string id_prop, int monto)
        {

            Cuenta_Ahorros ahorros = new Cuenta_Ahorros();

            ahorros.ID_propietario = cliente.ID;
            ahorros.Cuenta_monto = monto;


            auth.Cahorros(cliente);
        }

        public List<Cliente> ListClientes()
        {
            return auth.MostrarCliente();
        }

        public List<Cuenta_Ahorros> ListCuentas()
        {
            return auth.MostrarCuentas();
        }
        public List<Tarjeta_credito> ListTarjetas()
        {
            return auth.MostrarTarjetas();
        }
        public List<Prestamo> ListPrestamos()
        {
            return auth.MostrarPrestamos();
        }

        public List<ConsultaCahorros_Result> Consultar_Balance(int id)
        {
            return auth.Consultar_Balance(id).ToList();
        }

        public List<ConsultaTarjeta_Result> Consultar_Tarjeta(int id)
        {
            return auth.Consultar_Tarjeta(id).ToList();
        }
        public List<ConsultaPrestamo_Result> Consultar_Prestamo(int id)
        {
            return auth.Consultar_Prestamo(id).ToList();
        }

        public int Retirocahorros(int id, int monto)
        {
            return auth.Retirocahorros(id, monto);
        }
        public int AvanceTarjeta(int id, int monto)
        {
            return auth.AvanceTarjeta(id, monto);
        }
        public int Pagotarjeta(int id, int monto)
        {
            return auth.Pagotarjeta(id, monto);
        }
        public int PagoPrestamo(int id, int monto)
        {
            return auth.PagoPrestamo(id, monto);
        }
        public void EditCliente(Cliente c)
        {
            auth.EditCliente(c);
        }

    }
}
