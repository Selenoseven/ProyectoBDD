using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.Data.SQLite;
using System.Linq.Expressions;
using WinAppBiblioteca.Logica;
using WinAppBiblioteca.Model;

namespace WinAppBiblioteca.Logica
{
    public class InsertarL
    {
        public InsertarL()
        {

            listarLibrosArreglo();


        }

        /*

        public DataTable listarLibros()
        {
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            SQLiteConnection SqlCon = new SQLiteConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearConexion();
                string Sql_tarea = "select * from Libro";
                SQLiteCommand comando = new SQLiteCommand(Sql_tarea, SqlCon);
                SqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        */

        public List<Libro> listarLibrosArreglo()
        {
            List<Libro> libros = new List<Libro>();

            SQLiteDataReader resultado;
            SQLiteConnection SqlCon = new SQLiteConnection();

            try
            {
                SqlCon = Conexion.getInstancia().crearConexion();
                string sqlConsulta = "SELECT * FROM Libro";
                SQLiteCommand comando = new SQLiteCommand(sqlConsulta, SqlCon);
                SqlCon.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    Libro libro = new Libro();

                    
                    libro.CodigoLibro = resultado.GetString(0);
                    libro.NombreLibro = resultado.GetString(1);
                    libro.FechaPublicacion = resultado.GetString(2);
                    libro.Edicion = resultado.GetString(3);
                    libro.NombreAutor = resultado.GetString(4);
                    libro.ApellidoAutor = resultado.GetString(5);
                    libro.Categoria = resultado.GetString(6);
                    libro.Stock = resultado.GetInt32(7);
                    libro.Disponibilidad = resultado.GetInt32(8);
                    

                    libros.Add(libro);
                }

                return libros;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }


        public string guardarLibros(int nOpcion, Libro libro) //L_Articulos = guardarLibros
        {

            String respuesta = "";
            string Sql_tarea = "";
            /*
            SQLiteDataReader resultado;
            DataTable tabla = new DataTable();
            */
            SQLiteConnection SqlCon = new SQLiteConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearConexion();


                if (nOpcion == 1) //Nuevo registro
                {
                   
                    Sql_tarea = "INSERT INTO Libro (codigo_libro, nombre_libro, fecha_publicacion, edicion, nombre_autor, apellido_autor, categoria, stock, disponibilidad) " +
                    "VALUES ('"+libro.CodigoLibro+"','" + libro.NombreLibro + "', '" + libro.FechaPublicacion + "' , '" + libro.Edicion + "' , '" + libro.NombreAutor + "' , '" + libro.ApellidoAutor + "' , '" + libro.Categoria + "' , '" + libro.Stock + "' , '" + libro.Disponibilidad + "' )";
                }
                else //Actualizar registro
                {
                    Sql_tarea = "";
                }

                SQLiteCommand comando = new SQLiteCommand(Sql_tarea, SqlCon);
                SqlCon.Open();
                respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo completar el proceso de registro";

                return respuesta;
            }
            catch (Exception e)
            {
                return respuesta = e.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

    }

}