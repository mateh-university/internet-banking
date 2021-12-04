using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    class CslCahorros1
    {
        OP cuenta = new OP();

        public void Pedircuenta(Cuenta_Ahorros cuenta_)
        {
            cuenta.Solicitar_Cahorros(cuenta_);
            

        }
    }
}
