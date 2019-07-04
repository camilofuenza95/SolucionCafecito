﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DetalleCompra
    {
        public int Nro_Factura { get; set; }
        public string Nombre_Producto { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public string Validacion { get; set; }
        public string Comentario { get; set; }
        public DetalleCompra()
        {
            this.Init();
        }

        private void Init()
        {
            Nro_Factura = 0;
            Nombre_Producto = string.Empty;
            Cantidad = 0;
            Precio = 0;
            Validacion = string.Empty;
            Comentario = string.Empty;
        }
    }
}