using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSERVICE
{
     public class LibroCiencia : Libro
    {

        public LibroCiencia(string titulo, string autor, double precio, int cantidad)
        : base(titulo, autor, precio, cantidad)
        {
        }
        public override double calcularDescuento() {
         double precioConIVA = precioLibro * 0.21 + precioLibro;
            if (precioConIVA > 20000) {
                return precioLibro * 0.18; 
            } else { return 0; }
        }

        public override string obtenerDescripcion()
        {
            return obtenerDescripcion + $"(Ciencia)";
        }
    }
}
