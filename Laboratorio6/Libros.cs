using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6.Entidades
{
    public class Libros
    {
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Genero { get; set; }

        public int CantidadDisponible { get; set; }

        public Libros(string titulo, string autor, string genero,int cantidad)
        {
            Titulo = titulo.Trim();
            Autor = autor.Trim();
            Genero = genero.Trim();
            CantidadDisponible = cantidad;
        }
        public Libros()
        {

        }
    } 
}
