using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSERVICE
{
    public class Venta
    {
        public string tituloLibro { get; set; }
        public int cantidadVenta { get; set; }
        public DateTime fechaVenta { get; set; }

        public Venta(string tituloLibro, int cantidadVenta, DateTime fechaVenta)
        {
            tituloLibro = tituloLibro;
            cantidadVenta = cantidadVenta;
            fechaVenta = fechaVenta;
        }


    }
}
//Cada venta tiene como atributo el titulo del libro, la cantidad vendida y la fecha realizada