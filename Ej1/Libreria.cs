using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    public class Libreria
    {
        public float totalCash;
        public int cantidadArticulosVendidos;
        public int totalSell;

        public void procesarVenta(Venta venta)
        {
            if(venta.cantidadArticulosVendidos > 0) { 
                this.totalSell += 1;
                this.cantidadArticulosVendidos += venta.cantidadArticulosVendidos;
                this.totalCash += venta.total;
            }

        }
    }
}
