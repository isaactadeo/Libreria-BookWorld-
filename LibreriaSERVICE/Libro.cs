using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSERVICE
{
    public abstract class Libro
    {
        public double precioLibro {get; set;}
        public string tituloLibro { get; set; }
        public string autorLibro { get; set; }
        public int cantidadLibro { get; set; }
        public int descuentoLibro { get; set; }

        public Libro(string titulo, string autor, double precio, int cantidad) {
            tituloLibro= titulo;
            autorLibro = autor;
            precioLibro = precio;
            cantidadLibro = cantidad;
         
        }


        public abstract double calcularDescuento();
        //Para calcular el descuento, para las Novelas se tendrá un 15% de descuento
        //, para los libros de Poesía se tendrá un 10% de descuento.
        //Para el caso de autoayuda  si el precio es mayor a 15000 se calculará un 10% de descuento
        //y por último para ciencia, si el precio del libro mas el iva supera el 20000, se hará un 18% de descuento.
        public virtual string obtenerDescripcion (){
            return $"{tituloLibro} de {autorLibro}, precio: {precioLibro}, con un total de stock de {cantidadLibro}, descuento: {calcularDescuento}";
            
        }
    }
}
