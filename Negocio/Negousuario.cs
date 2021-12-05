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
       

        public Inicio_Result validar(string correo, string clave)
        {
            var auth = new Auth();
            return auth.IniciarSesion(correo, clave);
        }
    }
}
