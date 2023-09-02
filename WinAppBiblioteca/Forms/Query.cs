
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

namespace WinAppBiblioteca
{
    public partial class Query : Form
    {

       private Buscar buscar;
       
        public Query()
        {

            InitializeComponent();
            buscar= new Buscar();
     
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


       
        private void Estudiante_Load(object sender, EventArgs e)
        {
            Listado_ar();
        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            string nombreLibro = tquery.Text.Trim();

            DataTable dt = buscar.listado("SELECT * FROM Libro");

            int indice = buscar.BusquedaSecuencial(dt, nombreLibro);

            if (indice != -1)
            {
                // Crear un nuevo DataTable con la estructura del DataGridView
                DataTable dtLibro = dt.Clone();

                // Copiar la fila del libro encontrado al nuevo DataTable
                DataRow row = dt.Rows[indice];
                dtLibro.ImportRow(row);

                // Asignar el DataTable al DataGridView
                dQuery.DataSource = dtLibro;
            }
            else
            {
                // Limpiar el DataGridView si no se encuentra el libro
                dQuery.DataSource = null;
                MessageBox.Show("El libro no se encontró en la lista.");
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Listado_ar();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string texto = tquery.Text.Trim();
            dQuery.DataSource = buscar.BuscarLibro(texto);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string codigo= tquery.Text.Trim();
            DataTable dt = buscar.listado("SELECT * FROM Libro ORDER BY codigo_libro ASC");
            int indice = buscar.BusquedaBinariaCodigo(dt, codigo);

            if (indice != -1)
            {
                DataRow row = dt.Rows[indice];
                DataTable dtResult = new DataTable();
                dtResult.Columns.Add("codigo_libro");
                dtResult.Columns.Add("nombre_libro");
                dtResult.Columns.Add("fecha_publicacion");
                dtResult.Columns.Add("edicion");
                dtResult.Columns.Add("nombre_autor");
                dtResult.Columns.Add("apellido_autor");
                dtResult.Columns.Add("categoria");
                dtResult.Columns.Add("stock");
                dtResult.Columns.Add("disponibilidad");

                DataRow newRow = dtResult.NewRow();
                newRow["codigo_libro"] = row["codigo_libro"];
                newRow["nombre_libro"] = row["nombre_libro"];
                newRow["fecha_publicacion"] = row["fecha_publicacion"];
                newRow["edicion"] = row["edicion"];
                newRow["nombre_autor"] = row["nombre_autor"];
                newRow["apellido_autor"] = row["apellido_autor"];
                newRow["categoria"] = row["categoria"];
                newRow["stock"] = row["stock"];
                newRow["disponibilidad"] = row["disponibilidad"];

                dtResult.Rows.Add(newRow);

                dQuery.DataSource = dtResult;
            }
            else
            {
                dQuery.DataSource = null;
                MessageBox.Show("El libro no se encontró en la lista.");
            }
        }

        



        private void button18_Click(object sender, EventArgs e)
        {
            DataTable dtOriginal = (DataTable)dQuery.DataSource;
            DataTable dtOrdenado = buscar.OrdenamientoBurbuja(dtOriginal);
            dQuery.DataSource = dtOrdenado;

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
            string consulta = "SELECT * FROM Libro";
            dQuery.DataSource = buscar.listado(consulta);
        }
        
        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {
           Listado_ar();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}