using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio6.Datos;
using Laboratorio6.Entidades;

namespace Laboratorio6.Logica
{
    public class LogicaLibros
    {
        private Libreria datosLibros;

        public LogicaLibros()
        {
            datosLibros = new Libreria();
        }

        public int Registrar(Libros libro)
        {
            if (string.IsNullOrWhiteSpace(libro.Titulo))
                throw new ArgumentException("El título del libro no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(libro.Autor))
                throw new ArgumentException("El autor del libro no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(libro.Genero))
                throw new ArgumentException("Debe seleccionar un género literario.");

            return datosLibros.Registrar(libro);
        }

        public List<Libros> ObtenerTodos()
        {
            return datosLibros.ObtenerTodos();
        }

        public List<Libros> ObtenerPorGenero(string genero)
        {
            if (string.IsNullOrWhiteSpace(genero))
                throw new ArgumentException("Debe especificar un género válido.");

            return datosLibros.ObtenerPorGenero(genero);
        }
    }
}
