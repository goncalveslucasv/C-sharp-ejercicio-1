using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    public class Venta
    {
        public int cantidadArticulosVendidos;
        public float total;


        public void Vender(Articulo art, int cantidad)
        {
            this.cantidadArticulosVendidos += cantidad;
            this.total += (art.precio * cantidad);

        }
    }
}
