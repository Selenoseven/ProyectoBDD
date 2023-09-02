
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
using FontAwesome.Sharp;


namespace WinAppBiblioteca
{
    public partial class VENTAinsert : Form 
    {
        OracleConnection conn;
        Usuario user;

        public VENTAinsert(Usuario usuario)
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
            txtIdVenta.Focus();

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
            string consulta;
            if (user.IsMaster)
            {
                consulta = "SELECT * FROM venta";
            }
            else
            {
                consulta = "SELECT * FROM vwventa";
            }
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
            string idVenta = txtIdVenta.Text;
            string idSucursal = txtIdSucursal.Text;
            string idCliente = txtIdCliente.Text;
            DateTime fecha;

            // Valida y convierte el valor del TextBox de Fecha a DateTime
            if (!DateTime.TryParse(txtFecha.Text, out fecha))
            {
                MessageBox.Show("La fecha no es válida.");
                return;
            }

            decimal total;

            // Valida y convierte el valor del TextBox de Total a decimal
            if (!decimal.TryParse(txtTotal.Text, out total))
            {
                MessageBox.Show("El total no es válido.");
                return;
            }

            // Verifica que los campos no estén vacíos antes de la inserción (agrega tu propia lógica de validación)
            if (string.IsNullOrWhiteSpace(idVenta) || string.IsNullOrWhiteSpace(idSucursal) || string.IsNullOrWhiteSpace(idCliente))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.");
                return;
            }

            string updateQuery = "";
            if (user.IsMaster)
            {
                updateQuery = "INSERT INTO venta (IdVenta, IdSucursal, IdCliente, Fecha, Total) " +
                                 "VALUES (:idVenta, :idSucursal, :idCliente, :fecha, :total)";
            }
            else
            {
                updateQuery = "INSERT INTO venta@replica_proyrad (IdVenta, IdSucursal, IdCliente, Fecha, Total) " +
                                 "VALUES (:idVenta, :idSucursal, :idCliente, :fecha, :total)";
            }

            // Crea un objeto OracleCommand
            OracleCommand insertCommand = new OracleCommand(updateQuery, conn);

            // Asigna valores a los parámetros
            insertCommand.Parameters.Add(":idVenta", OracleDbType.Varchar2).Value = idVenta;
            insertCommand.Parameters.Add(":idSucursal", OracleDbType.Varchar2).Value = idSucursal;
            insertCommand.Parameters.Add(":idCliente", OracleDbType.Varchar2).Value = idCliente;
            insertCommand.Parameters.Add(":fecha", OracleDbType.Date).Value = fecha;
            insertCommand.Parameters.Add(":total", OracleDbType.Decimal).Value = total;

            try
            {
                // Abre la conexión y ejecuta la sentencia SQL de inserción
                conn.Open();
                insertCommand.ExecuteNonQuery();
                conn.Close();

                // Actualiza el DataGridView para mostrar los datos actualizados
                mostrardatos(); // Asumiendo que este método también muestra datos de ventas
                MessageBox.Show("La inserción de la venta se realizó con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar venta: " + ex.Message);
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
