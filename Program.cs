using Biblioteca.Clases;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la biblioteca");

            MiBiblioteca miBiblioteca = new MiBiblioteca();
            string opcion;

            do
            {
                Console.WriteLine("1. Agregar libro");
                Console.WriteLine("2. Buscar Libro por autor");
                Console.WriteLine("3. Listar Libros");
                Console.WriteLine("4. Eliminar Libro");
                Console.WriteLine("5. Salir");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        miBiblioteca.AgregarLibro(); 
                        break;
                    case "2":
                        miBiblioteca.BuscarLibro(); 
                        break;
                    case "3":
                        miBiblioteca.ListarLibros();
                        break;
                    case "4":
                        miBiblioteca.EliminarLibro();
                        break;
                    case "5":
                        Console.WriteLine("Saliendo...");
                        break;
                }
            } while (opcion != "5");
        }
    }
}
