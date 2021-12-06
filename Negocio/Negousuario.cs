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
        OP obj = new OP();

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

    }
}
