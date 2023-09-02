using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppBiblioteca.Logica;
using WinAppBiblioteca.Model;

namespace WinAppBiblioteca.Forms
{
    public partial class DeleteForm : Form
    {
        Read readAux;
        Delete deleteAux;
        public DeleteForm()
        {
            InitializeComponent();
            readAux = new Read();
            deleteAux = new Delete();
        }
        public void ListarDGV()
        {
            DGVLibro.DataSource = readAux.Listar("Libro");
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            ListarDGV();
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            DataRow row = readAux.BuscarRegistroPorCodigo("Libro", txt_Codigo.Text, "codigo_libro");
            if (row != null)
            {
                // Obtener los valores de las columnas del registro seleccionado
                string codigoLibro = row["codigo_libro"].ToString();
                string nombreLibro = row["nombre_libro"].ToString();
                string fechaPublicacion = row["fecha_publicacion"].ToString();
                string edicion = row["edicion"].ToString();
                string nombreAutor = row["nombre_autor"].ToString();
                string apellidoAutor = row["apellido_autor"].ToString();
                string categoria = row["categoria"].ToString();
                int stock = Convert.ToInt32(row["stock"]);
                int disponibilidad = Convert.ToInt32(row["disponibilidad"]);

                // Establecer los valores en los cuadros de texto
                txt_Codigo.Text = codigoLibro;
                txt_Nombre.Text = nombreLibro;
                txt_FechaPub.Text = fechaPublicacion;
                txt_Edicion.Text = edicion;
                txt_NombreAu.Text = nombreAutor;
                txt_ApellidoAu.Text = apellidoAutor;
                txt_Categoria.Text = categoria;
                txt_Stock.Text = stock.ToString();
                txt_Disponibilidad.Text = disponibilidad.ToString();

            }
        }

        private void DGVLibro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVLibro.Rows[e.RowIndex];
                string codigoLibro = row.Cells["codigo_libro"].Value.ToString();
                string nombreLibro = row.Cells["nombre_libro"].Value.ToString();
                string fechaPublicacion = row.Cells["fecha_publicacion"].Value.ToString();
                string edicion = row.Cells["edicion"].Value.ToString();
                string nombreAutor = row.Cells["nombre_autor"].Value.ToString();
                string apellidoAutor = row.Cells["apellido_autor"].Value.ToString();
                string categoria = row.Cells["categoria"].Value.ToString();
                int stock = Convert.ToInt32(row.Cells["stock"].Value);
                int disponibilidad = Convert.ToInt32(row.Cells["disponibilidad"].Value);

                // Establecer los valores en los cuadros de texto
                txt_Codigo.Text = codigoLibro.ToString();
                txt_Nombre.Text = nombreLibro;
                txt_FechaPub.Text = fechaPublicacion;
                txt_Edicion.Text = edicion;
                txt_NombreAu.Text = nombreAutor;
                txt_ApellidoAu.Text = apellidoAutor;
                txt_Categoria.Text = categoria;
                txt_Stock.Text = stock.ToString();
                txt_Disponibilidad.Text = disponibilidad.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Libro libro = new Libro(txt_Codigo.Text,
                    txt_Nombre.Text, txt_FechaPub.Text, txt_Edicion.Text,
                    txt_NombreAu.Text, txt_ApellidoAu.Text, txt_Categoria.Text,
                    int.Parse(txt_Stock.Text), int.Parse(txt_Disponibilidad.Text));

                deleteAux.EliminarRegistro(libro);
                this.ListarDGV();
                limpiarTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limpiarTxt()
        {
            this.txt_Codigo.ReadOnly = false;
            foreach (Control control in panel3.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }
    }
}
