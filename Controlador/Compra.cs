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
    
    public partial class Compra
    {
        public Compra()
        {
            this.DetalleCompra = new HashSet<DetalleCompra>();
        }
    
        public int Nro_Factura { get; set; }
        public Nullable<int> id_Proveedor { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<double> Total { get; set; }
    
        public virtual Proveedor Proveedor { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }
    }
}
