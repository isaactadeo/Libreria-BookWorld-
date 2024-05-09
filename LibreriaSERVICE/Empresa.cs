namespace LibreriaSERVICE
{
    public class Empresa
    {
   

        public List<Libro> Libros { get; set; }

        public Empresa()
        {
            Libros = new List<Libro>();
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
}
}
