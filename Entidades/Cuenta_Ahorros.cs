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
    
    public partial class Cuenta_Ahorros
    {
        public int ID_cuenta { get; set; }
        public Nullable<int> ID_propietario { get; set; }
        public Nullable<int> Cuenta_monto { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Registro_Cahorros Registro_Cahorros { get; set; }
    }
}
