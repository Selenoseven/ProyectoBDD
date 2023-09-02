using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppBiblioteca.Logica
{
    public class Read
    {
        public DataTable Listar(string tableName)
        {
            SQLiteDataReader Resultado;
            DataTable Tabla = new DataTable();
            SQLiteConnection SqlCon = new SQLiteConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearConexion();
                string Sql_tarea = "select * from " + tableName;
                SQLiteCommand Comando = new SQLiteCommand(Sql_tarea, SqlCon);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataRow BuscarRegistroPorCodigo(string tableName, string codigo,String campoCod)
        {
            SQLiteDataReader Resultado;
            DataTable Tabla = new DataTable();
            SQLiteConnection SqlCon = new SQLiteConnection();
            try
            {
                SqlCon = Conexion.getInstancia().crearConexion();
                string Sql_tarea = "SELECT * FROM " + tableName + " WHERE "+campoCod+" = @Codigo";
                SQLiteCommand Comando = new SQLiteCommand(Sql_tarea, SqlCon);
                Comando.Parameters.AddWithValue("@Codigo", codigo);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                if (Tabla.Rows.Count > 0)
                {
                    return Tabla.Rows[0];
                }
                else
                {
                    MessageBox.Show("No se encontro el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

    }
}
