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
        DBProEntities6 db = new DBProEntities6();
        public Inicio_Result IniciarSesion(String correo, String clave)
        {
            
            return db.Inicio(correo, clave).FirstOrDefault();
        }

        
        public Cliente Crear_cliente(Cliente cliente)
        {
            
            var existe = db.Usuario.FirstOrDefault(a => a.Correo == cliente.Correo);

            if(existe == null)
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



    }
}
