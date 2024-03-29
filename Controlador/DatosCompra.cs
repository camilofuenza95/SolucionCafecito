﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class DatosCompra
    {
        UnCafecitoEntities entity = new UnCafecitoEntities();


        public bool IngresarCompra(Compra c)
        {
            bool res = false;

            if (BuscarCompra(c.Nro_Factura) == null)
            {
               
                entity.Compra.Add(c);

                try
                {
                    entity.SaveChanges();
                    res = true;

                }
                catch (DbEntityValidationException ex)
                {
                    Console.WriteLine(ex);
                }

            }


            return res;
        }

        public Compra BuscarCompra(int nrofactura)
        {

            Compra c = entity.Compra.FirstOrDefault(a => a.Nro_Factura.Equals(nrofactura));
            if (c != null)
            {
                return c;
            }
            else
            {
                return null;
            }

        }



        public bool ModificarCompra(Compra c)
        {

            Compra compra= entity.Compra.FirstOrDefault(a => a.Nro_Factura== c.Nro_Factura);
            if (compra != null)
            {
                compra.Total = c.Total;
                compra.Fecha = c.Fecha;
                compra.id_Proveedor = c.id_Proveedor;
               

                entity.SaveChanges();
                return true;

            }
            else
            {
                return false;
            }

        }
        public List<Compra> ListarCompras()
        {
            var lista = (from con in entity.Compra select con).ToList();
            return lista;
        }
    }
}
