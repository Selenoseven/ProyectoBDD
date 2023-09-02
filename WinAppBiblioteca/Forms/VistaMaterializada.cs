
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppBiblioteca.Logica;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.ManagedDataAccess.Client;


namespace WinAppBiblioteca
{
    public partial class VistaMaterializada : Form
    {
        OracleConnection conn;

        private Buscar buscar;
       
        public VistaMaterializada()
        {

            InitializeComponent();
            buscar= new Buscar();
     
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


       
        private void Estudiante_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/orcl; USER ID=marmijo;PASSWORD=marmijo";
            conn = new OracleConnection(conStr);
            updateVWINVENTARIO();
            updateVWEMPLEADO();
            updateVWVENTA();
           
            


        }
        
        private void button15_Click(object sender, EventArgs e)
        {
           

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Listado_ar();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
        }


        private void updateVWINVENTARIO()
        {
            string consulta = "SELECT * FROM VWINVENTARIO"; // Reemplaza mv_ejemplo con el nombre de tu vista materializada
            conn.Open(); // Abre la conexión a la base de datos Oracle
            OracleCommand comando = new OracleCommand(consulta, conn); // Utiliza "conn" como tu objeto de conexión
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DGVinventario.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla

        }
        private void updateVWVENTA()
        {
            string consulta = "SELECT * FROM VWINVENTARIO"; // Reemplaza mv_ejemplo con el nombre de tu vista materializada
            conn.Open(); // Abre la conexión a la base de datos Oracle
            OracleCommand comando = new OracleCommand(consulta, conn); // Utiliza "conn" como tu objeto de conexión
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DGVVENTA.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla

        }

        private void updateVWEMPLEADO()
        {
            string consulta = "SELECT * FROM VWEMPLEADO"; // Reemplaza mv_ejemplo con el nombre de tu vista materializada
            conn.Open(); // Abre la conexión a la base de datos Oracle
            OracleCommand comando = new OracleCommand(consulta, conn); // Utiliza "conn" como tu objeto de conexión
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DGVEMPLEADO.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla

        }


        private void button18_Click(object sender, EventArgs e)
        {
            

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGLibro_Layout(object sender, LayoutEventArgs e)
        {
          
        }

        private void dataGLibroQ_Layout(object sender, LayoutEventArgs e)
        {
            
        }
        private void Listado_ar()
        {
           
           // DGVinventario.DataSource = buscar.listado(consulta);
        }
        
        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Layout_1(object sender, LayoutEventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/orcl; USER ID=marmijo;PASSWORD=marmijo";
            conn = new OracleConnection(conStr);
            updateVWINVENTARIO();
            updateVWEMPLEADO();
            updateVWVENTA();
        }
    }
}