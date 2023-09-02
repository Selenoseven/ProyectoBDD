using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppBiblioteca.Model;

namespace WinAppBiblioteca.Forms
{
    public partial class ReadFrag : Form
    {
        OracleConnection conn;
        string conStr;
        Usuario user;
        public ReadFrag(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
            conStr = @"DATA SOURCE = localhost:1521/orcl; USER ID=" + user.username + ";PASSWORD=" + user.password;
            conn = new OracleConnection(conStr);
        }

        private void ReadFrag_Load(object sender, EventArgs e)
        {
            this.ListarDGVCliente();
            this.ListarDGVPedido();
            this.ListarDGVProveedor();

        }
        private void ListarDGVCliente()
        {
            string consulta;
            if (user.IsMaster)
            {
                consulta = "SELECT * FROM peliculas";
            }
            else
            {
                consulta = "SELECT * FROM peliculas";
            }
            conn.Open();
            OracleCommand comando = new OracleCommand(consulta, conn);
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DGV_Cliente.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla
        }
        private void ListarDGVProveedor()
        {
            string consulta;
            if (user.IsMaster)
            {
                consulta = "SELECT * FROM salas";
            }
            else
            {
                consulta = "SELECT * FROM salas";
            }
            conn.Open();
            OracleCommand comando = new OracleCommand(consulta, conn);
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DGV_Proveedor.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla
        }
        private void ListarDGVPedido()
        {
            string consulta;
            if (user.IsMaster)
            {
                consulta = "SELECT * FROM funciones";
            }
            else
            {
                consulta = "SELECT * FROM funciones";
            }
            conn.Open();
            OracleCommand comando = new OracleCommand(consulta, conn);
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DGV_Pedido.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla
        }
    }
}
