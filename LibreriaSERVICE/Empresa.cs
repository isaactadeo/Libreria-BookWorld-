using LibreriaSERVICE;

namespace LibreriaSERVICE
{
    public class Empresa
    {
   

        public List<Libro> Libros { get; set; }
        public List<Venta> Ventas { get; set; }
        public Empresa()
        {
            Libros = new List<Libro>();
            Ventas = new List<Venta>(); 
        }

        public void AgregarLibro(string titulo, string autor, double precio, int cantidad, int tipo) {
        switch (tipo)
         { 
                case 1: Libros.Add(new LibroAutoAyuda(titulo,autor, precio, cantidad));
                    break;
                case 2:
                    Libros.Add(new LibroCiencia(titulo, autor, precio, cantidad));
                    break;
                case 3:
                    Libros.Add(new LibroNovela(titulo, autor, precio, cantidad));
                    break;
                case 4:
                    Libros.Add(new LibroPoesia(titulo, autor, precio, cantidad));
                    break;
                default: Console.WriteLine("Genero inexistente"); 
                     break;  
            }


        }

        public void VerInventario ()
        {
            Console.WriteLine("inentario actual:");
                foreach (var libro in Libros) {
                Console.WriteLine($"{libro.tituloLibro} de {libro.autorLibro}, precio: {libro.precioLibro}, con un total de stock de {libro.cantidadLibro}, descuento: {libro.calcularDescuento}"); 
            }
        }

       public void RegistrarVenta (string tituloLibro, int cantidadVenta, DateTime fechaVenta) {
         Libro libro = Libros.Find(l => l.tituloLibro == tituloLibro);

            if (libro != null)
            {
                libro.cantidadLibro = libro.cantidadLibro - cantidadVenta;
                Ventas.Add(new Venta(tituloLibro, cantidadVenta, fechaVenta));

            } 
            else {
                Console.WriteLine("Libro no encontrado");
            }
            

        }

        public List<Venta> ObtenerVentasEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            // Filtrar las ventas dentro del rango de fechas
            return Ventas.FindAll(v => v.fechaVenta >= fechaInicio && v.fechaVenta <= fechaFin);
        }
    }
}
