//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prestamo
    {
        public int ID_Prestamo { get; set; }
        public Nullable<int> ID_propietario { get; set; }
        public Nullable<int> Monto_inicial { get; set; }
        public Nullable<int> Monto_Prestado { get; set; }
        public Nullable<System.DateTime> Fecha_limiteapagar { get; set; }
        public Nullable<int> Cuotas { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Registro_Prestamo Registro_Prestamo { get; set; }
    }
}
