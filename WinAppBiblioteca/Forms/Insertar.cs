
using WinAppBiblioteca.Logica;
using WinAppBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinAppBiblioteca
{
    public partial class Insertar : Form 
    {
        public Insertar()
        {
            InitializeComponent();
        }

        #region "Variables"
        //String codigoLibro = ""; 
        int nEstadoguarda = 0;
        #endregion

        #region "Métodos"

        //Método para activar o desactivas la edición de las casillas
        private void estadoTexto(bool logicEstado)
        {
            txt_codigo_libro.ReadOnly = !logicEstado;
            txtNombreL.ReadOnly = !logicEstado;
            txtFechaL.ReadOnly = !logicEstado;
            txtEdicionL.ReadOnly = !logicEstado;
            txtNombreA.ReadOnly = !logicEstado;
            txtApellidoA.ReadOnly = !logicEstado;
            txtCategoriaL.ReadOnly = !logicEstado;
            txtStockL.ReadOnly = !logicEstado;
            txtDisponibilidadL.ReadOnly = !logicEstado;
        }

        //Limpia las casillas para ingresar un nuevo libro
        private void LimpiarTexto()
        {
            txt_codigo_libro.Clear();
            txtNombreL.Clear();
            txtFechaL.Clear();
            txtEdicionL.Clear();
            txtNombreA.Clear();
            txtApellidoA.Clear();
            txtCategoriaL.Clear ();
            txtStockL.Clear();  
            txtDisponibilidadL.Clear();

        }

        //Hace visible los botones cancelar y guardar
        private void estadoBotonesCG(bool logicEstado)
        {
            btCancelar.Visible = logicEstado;
            btGuardar.Visible = logicEstado;
           // dataGridView1.Enabled = !logicEstado;
        }

        private void estadoBotonesPrincipales(bool logicEstado)
        {
            btInsertar.Enabled = logicEstado;
             
        }

       

        private void Listado_lib()
        {
            InsertarL datos = new InsertarL();
            List<Libro> libros = datos.listarLibrosArreglo(); // Obtener los datos de listarLibros()

           // dataGridView1.DataSource = libros;
        }




        //
        #endregion


        //Botones para las operaciones CRUD


        
        private void btInsertar_Click(object sender, EventArgs e)
        {
            //Métodos de interfaz
            nEstadoguarda = 1; //Nuevo Registro
            this.estadoTexto(true); 
            this.LimpiarTexto();
            this.estadoBotonesCG(true);
            this.estadoBotonesPrincipales(false);
            txtNombreL.Focus();

        }
        
        //Fin de botones para operaciones CRUD

        
        //Botones para guardar o cancelar la modificación de datos 
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.estadoTexto(false);
            this.LimpiarTexto();
            this.estadoBotonesCG(false);
            this.estadoBotonesPrincipales(true);
        }

        private TextBox GetTxtStockL()
        {
            return txtStockL;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            Libro mLibro = new Libro(); //mLibro = oAr

            mLibro.CodigoLibro = txt_codigo_libro.Text.Trim();
            mLibro.NombreLibro = txtNombreL.Text.Trim();
            mLibro.FechaPublicacion = txtFechaL.Text.Trim();
            mLibro.Edicion = txtEdicionL.Text.Trim();
            mLibro.NombreAutor = txtNombreA.Text.Trim();
            mLibro.ApellidoAutor = txtApellidoA.Text.Trim();
            mLibro.Categoria = txtCategoriaL.Text.Trim();
            mLibro.Stock = int.Parse(txtStockL.Text.Trim());
            mLibro.Disponibilidad = int.Parse(txtDisponibilidadL.Text.Trim());

            InsertarL datos = new InsertarL(); //datos = DATOS
            respuesta = datos.guardarLibros(nEstadoguarda, mLibro); //Guardar_ar = guardarLibros
            
            if(respuesta.Equals("OK"))
            {
                this.Listado_lib();
                MessageBox.Show("Los datos han sido guardados corectamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta);
            }

            
        }
        //Fin de los botones de modificación de datos

        //Inicio de los label que indican que infromación debe llenar el usuario

        private void lbNombreL_Click(object sender, EventArgs e)
        {

        }

        private void lbFechaL_Click(object sender, EventArgs e)
        {

        }

        private void lbEdicionL_Click(object sender, EventArgs e)
        {

        }

        private void lbNombreA_Click(object sender, EventArgs e)
        {

        }

        private void lbApellidoA_Click(object sender, EventArgs e)
        {

        }

        private void lbCategoriaL_Click(object sender, EventArgs e)
        {

        }

        private void lbStockL_Click(object sender, EventArgs e)
        {

        }

        private void lbDisponibilidadL_Click(object sender, EventArgs e)
        {

        }
        //Fin de los Label

        //Inicio de los cuadros de texto que albergan la la información ingresada por el usuario

        
        private void txtNombreL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdicionL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoriaL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStockL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisponibilidadL_TextChanged(object sender, EventArgs e)
        {

        }

        //EVENTO LOAD
        private void Insertar_Load(object sender, EventArgs e)
        {
            this.Listado_lib();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbCodigo_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_libro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_codigo_libro_TextChanged_1(object sender, EventArgs e)
        {

        }


        //Fin de los cuadros dde texto
    }
}
