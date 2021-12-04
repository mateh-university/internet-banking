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
        Negousuario _usuario = new Negousuario();

        public Negousuario validar(string correo, string clave)
        {
            return _usuario.validar(correo, clave);
        }
    }
}
