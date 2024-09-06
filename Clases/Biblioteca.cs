using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    class MiBiblioteca
    {
        private List<Libro> Libros;

        public MiBiblioteca()
        {
            Libros = new List<Libro>();
        }

        public void AgregarLibro()
        {

            Console.WriteLine("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();

            Console.WriteLine("Ingrese el año de publicación (opcional, Presione ENTER para omitir): ");
            string anio = Console.ReadLine();
            int? anioPublicacion = null;
            if (int.TryParse(anio, out int resultadoAnio))
            {
                anioPublicacion = resultadoAnio;
            }

            Console.WriteLine("Ingrese el ISBN (opcional, Presione ENTER para omitir): ");
            string? isbn = Console.ReadLine();

            Libro nuevoLibro = new Libro(titulo, autor, anioPublicacion, isbn);

            Libros.Add(nuevoLibro);

            Console.WriteLine($"Libro '{nuevoLibro.Titulo}' agregado a la biblioteca.");
        }

        public void ListarLibros()
        {
            Console.WriteLine("\nLibros disponibles en la biblioteca:");
            if (Libros.Count == 0)
            {
                Console.WriteLine("No hay libros en la biblioteca.");
            }
            else
            {
                foreach (Libro libro in Libros)
                {
                    Console.WriteLine(libro.ObtenerInformacion());
                }
            }
        }

        public void EliminarLibro()
        {

            Console.Write("Ingrese el título del libro que desea eliminar: ");
            string titulo = Console.ReadLine();

            Libro libroAEliminar = Libros.Find(libro => libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (libroAEliminar != null)
            {
                Libros.Remove(libroAEliminar);
                Console.WriteLine($"Libro {titulo} eliminado de la biblioteca.");
            }
            else
            {
                Console.WriteLine($"No se encontró el libro {titulo} en la biblioteca.");
            }
        }

        public void BuscarLibro()
        {
            Console.Write("Ingrese el autor del libro que desea buscar: ");
            string autor = Console.ReadLine();

            List<Libro> librosEncontrados = Libros.FindAll(libro => libro.Autor.Equals(autor, StringComparison.OrdinalIgnoreCase));
            if (librosEncontrados.Count > 0)
            {
                Console.WriteLine($"Libros encontrados de {autor} encontrados en la biblioteca:");

                foreach (Libro libro in librosEncontrados)
                {
                    Console.WriteLine(libro.ObtenerInformacion());
                }
            }
            else
            {
                Console.WriteLine($"No se encontraron libros de {autor} en la biblioteca.");
            }
        }

    }
}
