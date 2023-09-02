using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppBiblioteca.Model;

namespace WinAppBiblioteca.Logica
{
    public class Delete
    {

        public void EliminarRegistro( Libro libro)
        {
            SQLiteConnection SqlCon = new SQLiteConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearConexion();

                string sqlEliminar = "DELETE FROM Libro WHERE codigo_libro = @CodigoLibro";
                SQLiteCommand Comando = new SQLiteCommand(sqlEliminar, SqlCon);

                Comando.Parameters.AddWithValue("@CodigoLibro", libro.CodigoLibro);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
