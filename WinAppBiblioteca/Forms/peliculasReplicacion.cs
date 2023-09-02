using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppBiblioteca.Forms
{
    public partial class peliculasReplicacion : Form
    {
        OracleConnection conn;
        public peliculasReplicacion()
        {
            InitializeComponent();
        }

        private void updateGried()
        {
            string consulta = "SELECT * FROM VWPELICULAS"; // Reemplaza mv_ejemplo con el nombre de tu vista materializada
            conn.Open(); // Abre la conexión a la base de datos Oracle
            OracleCommand comando = new OracleCommand(consulta, conn); // Utiliza "conn" como tu objeto de conexión
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla

        }

        private void peliculasReplicacion_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/orcl; USER ID=aotavalo;PASSWORD=aotavalo";
            conn = new OracleConnection(conStr);
            updateGried();
        }

        private void BtnRefeshPELICULAS_Click(object sender, EventArgs e)
        {
            updateGried();
        }
    }
}
