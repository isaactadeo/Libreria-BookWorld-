// See https://aka.ms/new-console-template for more information
using LibreriaSERVICE;
Console.WriteLine("Bienvendio a la libreria BookWorld");
Empresa bookWorld = new Empresa();


Console.WriteLine("Desea realizar algun movimiento en el sistema?(S/N)");
string ingresoMov = Console.ReadLine();


while (ingresoMov.ToLower() == "s")
{
    Console.WriteLine("elija una opcion");
    Console.WriteLine("1. Agregar un libro");
    Console.WriteLine("2. Ver inventario");
    Console.WriteLine("3. Realizar una venta");
    Console.WriteLine("4. Obtener ventas en lapso de fechas");
    Console.WriteLine("5. Salir");
    int Opcion = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (Opcion)
    {
        case 1:
            Console.WriteLine($"ingrese el titulo del libro");
            string titulo = Console.ReadLine();
            Console.WriteLine($"ingrese el autor del libro {titulo} ");
            string autor = Console.ReadLine();
            Console.WriteLine($"ingrese el precio del libro {titulo}");
            double precio = double.Parse(Console.ReadLine());
            Console.WriteLine($"ingrese la cantidad del libro {titulo}");
            int cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine($"ingrese el genero del libro {titulo}");
            Console.WriteLine($"1- AutoAyuda/2- Ciencia/3- Novela/4- Poesia");
            int tipo = int.Parse(Console.ReadLine());   
            bookWorld.AgregarLibro(titulo, autor, precio, cantidad, tipo);  
            break; 
        case 2:
            bookWorld.VerInventario();
            break;
        case 3:
            Console.WriteLine("ingrese el titulo del libro vendido");
            string titulolibro = Console.ReadLine();
            Console.WriteLine($"ingrese la cantidad vendida del libro {titulolibro} ");
           int cantidadvendida = int.Parse(Console.ReadLine());
          DateTime fechaventa = DateTime.Now;
            bookWorld.RegistrarVenta(titulolibro, cantidadvendida, fechaventa);
            break;
        case 4:
            Console.WriteLine("Ingrese la fecha de inicio (yyyy-mm-dd):");
            DateTime fechaInicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de fin (yyyy-mm-dd):");
            DateTime fechaFin = DateTime.Parse(Console.ReadLine());
            bookWorld.ObtenerVentasEntreFechas(fechaInicio, fechaFin);
            break;
        case 5:
            ingresoMov = "n";
            break;
        default:
            Console.WriteLine("Opcion incorrecta");
            break;
    }
    
}