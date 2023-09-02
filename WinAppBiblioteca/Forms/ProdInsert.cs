
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
using Oracle.ManagedDataAccess.Client;


namespace WinAppBiblioteca
{
    public partial class ProdInsert : Form 
    {
        OracleConnection conn;
        Usuario user;
        public ProdInsert(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
        }

        #region "Variables"
        //String codigoLibro = ""; 
        int nEstadoguarda = 0;
        #endregion

        #region "Métodos"

        //Método para activar o desactivas la edición de las casillas
        private void estadoTexto(bool logicEstado)
        {
            
        }

        //Limpia las casillas para ingresar un nuevo libro
        private void LimpiarTexto()
        {
            

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
            txtIdProducto.Focus();

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

       /* private TextBox GetTxtStockL()
        {
            
        }*/
        private void mostrardatos()
        {
            string conStr = @"DATA SOURCE = localhost:1521/orcl; USER ID=" + user.username + ";PASSWORD=" + user.password;
            conn = new OracleConnection(conStr);
            string consulta = "SELECT * FROM PRODUCTO"; // Reemplaza mv_ejemplo con el nombre de tu vista materializada
            conn.Open(); // Abre la conexión a la base de datos Oracle
            OracleCommand comando = new OracleCommand(consulta, conn); // Utiliza "conn" como tu objeto de conexión
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DGVINSERTPROD.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla

        }
        private void btGuardar_Click(object sender, EventArgs e)
        {

            string idProducto = txtIdProducto.Text;
            string nombreProducto = txtNombreProducto.Text;
            string descripcion = txtDescripcion.Text;
            decimal precioUnitario;

            // Valida y convierte el valor del TextBox de Precio Unitario a decimal
            if (!decimal.TryParse(txtPrecioUnitario.Text, out precioUnitario))
            {
                MessageBox.Show("El precio unitario no es válido.");
                return;
            }

            // Verifica que los campos no estén vacíos antes de la inserción (agrega tu propia lógica de validación)
            if (string.IsNullOrWhiteSpace(idProducto) || string.IsNullOrWhiteSpace(nombreProducto) || string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.");
                return;
            }
            string insertQuery;

            if (user.IsMaster)
            {
                insertQuery = "INSERT INTO Producto (IdProducto, NombreProducto, Descripcion, PrecioUnitario) " +
                     "VALUES (:idProducto, :nombreProducto, :descripcion, :precioUnitario)";
            }
            else
            {
                insertQuery = "INSERT INTO Producto@replica_proyrad (IdProducto, NombreProducto, Descripcion, PrecioUnitario) " +
                     "VALUES (:idProducto, :nombreProducto, :descripcion, :precioUnitario)";
            }

            // Crea un objeto OracleCommand
            OracleCommand insertCommand = new OracleCommand(insertQuery, conn);

            // Asigna valores a los parámetros
            insertCommand.Parameters.Add(":idProducto", OracleDbType.Varchar2).Value = idProducto;
            insertCommand.Parameters.Add(":nombreProducto", OracleDbType.Varchar2).Value = nombreProducto;
            insertCommand.Parameters.Add(":descripcion", OracleDbType.Varchar2).Value = descripcion;
            insertCommand.Parameters.Add(":precioUnitario", OracleDbType.Decimal).Value = precioUnitario;
            // Configura la conexión a Oracle y la sentencia SQL de inserción (como se mostró en respuestas anteriores)

            try
            {
                // Abre la conexión y ejecuta la sentencia SQL de inserción
                conn.Open();
                insertCommand.ExecuteNonQuery();
                conn.Close();

                // Actualiza el DataGridView para mostrar los datos actualizados
                mostrardatos(); // Asumiendo que este método también muestra datos de productos
                MessageBox.Show("La inserción del producto se realizó con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar producto: " + ex.Message);
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
            mostrardatos();
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
