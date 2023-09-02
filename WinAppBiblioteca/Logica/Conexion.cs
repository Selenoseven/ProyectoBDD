using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace WinAppBiblioteca.Logica
{
    public class Conexion
    {
        private string baseDatos;
        private static Conexion con = null;
        OracleConnection conn;

        private Conexion() 
        {
            string conStr = @"DATA SOURCE = localhost:1521/orcl; USER ID=marmijo;PASSWORD=marmijo";
            conn = new OracleConnection(conStr);
            string consulta = "SELECT * FROM PRODUCTO"; // Reemplaza mv_ejemplo con el nombre de tu vista materializada
            conn.Open(); // Abre la conexión a la base de datos Oracle
            OracleCommand comando = new OracleCommand(consulta, conn); // Utiliza "conn" como tu objeto de conexión
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            conn.Close(); // Cierra la conexión después de usarla
        }

        public SQLiteConnection crearConexion()
        {
            SQLiteConnection cadena = new SQLiteConnection();
            try
            {
                cadena.ConnectionString = "Data Source="+this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
