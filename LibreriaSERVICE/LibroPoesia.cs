using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSERVICE
{
    public class LibroPoesia : Libro
    {
       public LibroPoesia(string titulo, string autor, double precio, int cantidad)
       : base(titulo, autor, precio, cantidad) { 
        }
       public override double calcularDescuento() {
         return precioLibro * 0.1; }

        public override string obtenerDescripcion() {
         return obtenerDescripcion + $"(Poesia)"; }
    }
}
