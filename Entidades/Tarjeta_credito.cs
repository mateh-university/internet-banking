//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarjeta_credito
    {
        public int ID_Tarjeta { get; set; }
        public Nullable<int> ID_propietario { get; set; }
        public Nullable<int> Tarjeta_monto { get; set; }
        public Nullable<System.DateTime> Fecha_limiteapagar { get; set; }
    }
}