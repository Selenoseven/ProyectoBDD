using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppBiblioteca.Model;
using System.Windows.Forms;

namespace WinAppBiblioteca.Logica
{
    public class UpdateL
    {

        public void ActualizarRegistro(Libro libro)
        {
            SQLiteConnection SqlCon = new SQLiteConnection();
            SqlCon = Conexion.getInstancia().crearConexion();
            try
            {
                string sqlActualizar = "UPDATE Libro SET nombre_libro = @NombreLibro, " +
                            "fecha_publicacion = @Fecha, edicion = @Edicion, nombre_autor = @AutorNombre, " +
                            "apellido_autor = @AutorApellido, categoria = @Categoria, stock = @Stock, " +
                            "disponibilidad = @Disponibilidad WHERE codigo_libro = @CodigoLibro";
                SQLiteCommand Comando = new SQLiteCommand(sqlActualizar, SqlCon);

                // Agregar parámetros a la consulta
                Comando.Parameters.AddWithValue("@NombreLibro", libro.NombreLibro);
                Comando.Parameters.AddWithValue("@Fecha", libro.FechaPublicacion);
                Comando.Parameters.AddWithValue("@Edicion", libro.Edicion);
                Comando.Parameters.AddWithValue("@AutorNombre", libro.NombreAutor);
                Comando.Parameters.AddWithValue("@AutorApellido", libro.ApellidoAutor);
                Comando.Parameters.AddWithValue("@Categoria", libro.Categoria);
                Comando.Parameters.AddWithValue("@Stock", libro.Stock);
                Comando.Parameters.AddWithValue("@Disponibilidad", libro.Disponibilidad);
                Comando.Parameters.AddWithValue("@CodigoLibro", libro.CodigoLibro);

                SqlCon.Open();
                int numRows = Comando.ExecuteNonQuery();
                MessageBox.Show("Se han actualizado "+ numRows + " Registros", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

    }
}
