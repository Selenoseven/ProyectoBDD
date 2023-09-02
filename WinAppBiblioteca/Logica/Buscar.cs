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
    internal class Buscar
    {
        public Buscar()
        {

        }

        public DataTable listado(string sqlconection)
        {
            SQLiteDataReader resultado;
            DataTable dt = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon = Conexion.getInstancia().crearConexion();
                string sql_tarea = sqlconection;
                SQLiteCommand cmd = new SQLiteCommand(sql_tarea, sqlcon);
                sqlcon.Open();
                resultado = cmd.ExecuteReader();
                dt.Load(resultado);
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }
       
        public DataTable OrdenamientoBurbuja(DataTable dt)
        {
            DataRow[] rows = dt.Select();

            for (int i = 0; i < rows.Length - 1; i++)
            {
                for (int j = 0; j < rows.Length - i - 1; j++)
                {
                    int codigoLibro1 = Convert.ToInt32(rows[j]["codigo_libro"]);
                    int codigoLibro2 = Convert.ToInt32(rows[j + 1]["codigo_libro"]);

                    if (codigoLibro1 > codigoLibro2)
                    {
                        DataRow tempRow = dt.NewRow();
                        tempRow.ItemArray = rows[j].ItemArray;

                        rows[j].ItemArray = rows[j + 1].ItemArray;
                        rows[j + 1].ItemArray = tempRow.ItemArray;
                    }
                }
            }

            DataTable dtOrdenado = dt.Clone();
            foreach (DataRow row in rows)
            {
                dtOrdenado.ImportRow(row);
            }

            return dtOrdenado;
        }


             


        public DataTable BuscarLibro(string texto)
        {
            SQLiteDataReader resultado;
            DataTable dt = new DataTable();
            SQLiteConnection sqlcon = new SQLiteConnection();

            try
            {
                sqlcon = Conexion.getInstancia().crearConexion();
                string sql_tarea = "SELECT * FROM Libro WHERE LOWER(nombre_libro) LIKE @texto OR codigo_libro LIKE @texto";
                SQLiteCommand cmd = new SQLiteCommand(sql_tarea, sqlcon);
                cmd.Parameters.AddWithValue("@texto", "%" + texto.ToLower() + "%");
                sqlcon.Open();
                resultado = cmd.ExecuteReader();
                dt.Load(resultado);

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }
        /*
        public DataTable BuscarPorNombreLibroSecuencial(string texto)
        {
            DataTable dtOriginal = listado("SELECT * FROM Libro");
            DataTable dtResultado = dtOriginal.Clone();

            foreach (DataRow row in dtOriginal.Rows)
            {
                string nombreLibro = row["nombre_libro"].ToString().ToLower();
                if (nombreLibro.Contains(texto.ToLower()))
                {
                    dtResultado.ImportRow(row);
                }
            }

            return dtResultado;
        }
        */
        public int BusquedaSecuencial(DataTable dt, string nombreLibro)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string nombreLibroActual = dt.Rows[i]["nombre_libro"].ToString();

                if (nombreLibroActual.Equals(nombreLibro, StringComparison.OrdinalIgnoreCase))
                {
                    return i; // Se encontró el libro, se devuelve su índice
                }
            }

            return -1; // No se encontró el libro
        }

       

        public int BusquedaBinariaCodigo(DataTable dt, string codigo)
        {
            int inicio = 0;
            int fin = dt.Rows.Count - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                string codigoMedio = dt.Rows[medio]["codigo_libro"].ToString();

                if (codigoMedio == codigo)
                {
                    return medio; // Encontrado
                }
                else if (String.Compare(codigoMedio, codigo) > 0)
                {
                    fin = medio - 1; // Buscar en la mitad inferior
                }
                else
                {
                    inicio = medio + 1; // Buscar en la mitad superior
                }
            }

            return -1; // No encontrado
        }

        


    }
}
