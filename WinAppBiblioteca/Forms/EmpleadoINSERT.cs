
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
    public partial class EmpleadoINSERT : Form 
    {
        OracleConnection conn;
        Usuario user;
        public EmpleadoINSERT(Usuario usuario)
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
            txtIdEmpleado.Focus();

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
                consulta = "SELECT * FROM empleado";
            }
            else
            {
                consulta = "SELECT * FROM vwempleado";
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

            string idEmpleado = txtIdEmpleado.Text;
            string idSucursal = txtIdSucursal.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string ciudad = txtCiudad.Text;
            string provincia = txtProvincia.Text;
            string telefono = txtTelefono.Text;

            // Verifica que los campos no estén vacíos antes de la inserción (agrega tu propia lógica de validación)
            if (string.IsNullOrWhiteSpace(idEmpleado) || string.IsNullOrWhiteSpace(idSucursal) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(ciudad) ||
                string.IsNullOrWhiteSpace(provincia) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.");
                return;
            }
            string insertQuery = "";
            if (user.IsMaster && idSucursal.Equals("S001"))
            {
                insertQuery = "INSERT INTO empleado (IdEmpleado, IdSucursal, Nombre, Apellido, Direccion, Ciudad, Provincia, Telefono) " +
                                 "VALUES (:idEmpleado, :idSucursal, :nombre, :apellido, :direccion, :ciudad, :provincia, :telefono)";
            }
            else if (user.IsMaster && idSucursal.Equals("S002"))
            {
                insertQuery = "INSERT INTO empleado@replica_proyrad (IdEmpleado, IdSucursal, Nombre, Apellido, Direccion, Ciudad, Provincia, Telefono) " +
                                 "VALUES (:idEmpleado, :idSucursal, :nombre, :apellido, :direccion, :ciudad, :provincia, :telefono)";
            }
            else if (!user.IsMaster && idSucursal.Equals("S001"))
            {
                insertQuery = "INSERT INTO empleado@replica_proyrad (IdEmpleado, IdSucursal, Nombre, Apellido, Direccion, Ciudad, Provincia, Telefono) " +
                                 "VALUES (:idEmpleado, :idSucursal, :nombre, :apellido, :direccion, :ciudad, :provincia, :telefono)";
            }
            else
            {
                insertQuery = "INSERT INTO empleado (IdEmpleado, IdSucursal, Nombre, Apellido, Direccion, Ciudad, Provincia, Telefono) " +
                                 "VALUES (:idEmpleado, :idSucursal, :nombre, :apellido, :direccion, :ciudad, :provincia, :telefono)";
            }

            // Modifica la cadena de conexión para usar el Database Link
            string conStr = @"DATA SOURCE = replica_proyrad; USER ID=marmijo;PASSWORD=marmijo";

            // Sentencia SQL de inserción con el uso de Database Link
          

            // Crea un objeto OracleCommand
            OracleCommand insertCommand = new OracleCommand(insertQuery, conn);

            // Asigna valores a los parámetros
            insertCommand.Parameters.Add(":idEmpleado", OracleDbType.Varchar2).Value = idEmpleado;
            insertCommand.Parameters.Add(":idSucursal", OracleDbType.Varchar2).Value = idSucursal;
            insertCommand.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nombre;
            insertCommand.Parameters.Add(":apellido", OracleDbType.Varchar2).Value = apellido;
            insertCommand.Parameters.Add(":direccion", OracleDbType.Varchar2).Value = direccion;
            insertCommand.Parameters.Add(":ciudad", OracleDbType.Varchar2).Value = ciudad;
            insertCommand.Parameters.Add(":provincia", OracleDbType.Varchar2).Value = provincia;
            insertCommand.Parameters.Add(":telefono", OracleDbType.Varchar2).Value = telefono;

            try
            {
                // Abre la conexión y ejecuta la sentencia SQL de inserción
                conn.Open();
                insertCommand.ExecuteNonQuery();
                conn.Close();

                // Actualiza el DataGridView para mostrar los datos actualizados
                mostrardatos(); // Asumiendo que este método también muestra datos de empleados
                MessageBox.Show("La inserción del empleado se realizó con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar empleado: " + ex.Message);
            }

        }
        //Fin de los botones de modificación de datos

        //Inicio de los label que indican que infromación debe llenar el usuario


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

        //Fin de los Label

        //Inicio de los cuadros de texto que albergan la la información ingresada por el usuario

    
        //EVENTO LOAD
        private void Insertar_Load(object sender, EventArgs e)
        {
            mostrardatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //Fin de los cuadros dde texto
    }
}
