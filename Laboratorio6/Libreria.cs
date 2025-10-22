using Laboratorio6.Entidades;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio6.Datos
{

    public class Libreria
    {
        public Libreria() { }
        private string cadenaConexion =
         "Data Source=localhost;Initial Catalog=Libreria;Integrated Security=True";



        public int Registrar(Libros libro)
        {
            int idLibros = 0;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand("sp_InsertarLibro", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        //Parametros 
                        comando.Parameters.AddWithValue("@Titulo", libro.Titulo);
                        comando.Parameters.AddWithValue("@Autor", libro.Autor);
                        comando.Parameters.AddWithValue("@Genero", libro.Genero);
                        comando.Parameters.AddWithValue("@Cantidad", libro.CantidadDisponible);

                        //Ejecutar y obtener ID
                        object resultado = comando.ExecuteScalar();

                        if (resultado != null)
                        {
                            idLibros = Convert.ToInt32(resultado);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar libro:" + ex.Message);
            }
            return idLibros;
        }

        public List<Libros> ObtenerTodos()
        {
            List<Libros> lista = new List<Libros>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand("sp_ObtenerTodosLibros", conexion))
                    {

                        comando.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Libros libro = new Libros
                                {
                                    Titulo = reader["Titulo"].ToString(),
                                    Autor = reader["Autor"].ToString(),
                                    Genero = reader["Genero_Literario"].ToString(),
                                    CantidadDisponible = Convert.ToInt32(reader["Cantidad_Disponible"])
                                };

                                lista.Add(libro);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener los libros:" + ex.Message);
            }
            return lista;
        }
        public List<Libros> ObtenerPorGenero(string genero)
        {
            List<Libros> lista = new List<Libros>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand("sp_ObtenerLibrosPorGenero", conexion))
                    {

                        comando.CommandType = CommandType.StoredProcedure;


                        comando.Parameters.AddWithValue("@Genero", genero);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            Libros libro = new Libros
                                {
                                    Titulo = reader["Titulo"].ToString(),
                                    Autor = reader["Autor"].ToString(),
                                    Genero = reader["Genero_Literario"].ToString(),
                                    CantidadDisponible = Convert.ToInt32(reader["Cantidad_Disponible"])
                            };

                            lista.Add(libro);

                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al obtener libros por género " + ex.Message);
            }

            return lista;
        }

        // Eliminar libro por titulo
        public bool EliminarLibroPorTitulo(string titulo)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_EliminarLibroPorTitulo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Titulo", titulo);

                        int filasAfectadas = command.ExecuteNonQuery();
                        return filasAfectadas > 0; // True si eliminó, False si no encontró
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar libro: " + ex.Message, ex);
                }
            }
        }
    }
}
