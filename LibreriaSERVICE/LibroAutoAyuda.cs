using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSERVICE
{
     public class LibroAutoAyuda : Libro
    {

        public LibroAutoAyuda(string titulo, string autor, double precio, int cantidad)
       : base(titulo, autor, precio, cantidad) { 
        }


        public override double calcularDescuento() {
            if (precioLibro < 15000)
            {
             return precioLibro * 0.10;
            } else { return 0; }
        }
        public override string obtenerDescripcion() {
            return obtenerDescripcion + $"(AutoAyuda)";
        }


    }


}
