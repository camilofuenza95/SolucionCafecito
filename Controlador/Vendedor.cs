//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Controlador
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vendedor
    {
        public Vendedor()
        {
            this.Venta = new HashSet<Venta>();
        }
    
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }
    
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
