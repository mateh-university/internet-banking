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

        public Inicio_Result IniciarSesion(String correo, String clave)
        {
            DBProEntities6 db = new DBProEntities6();
            return db.Inicio(correo, clave).FirstOrDefault();
        }
    }
}
