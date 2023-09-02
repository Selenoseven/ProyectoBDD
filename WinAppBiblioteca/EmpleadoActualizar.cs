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

namespace WinAppBiblioteca.Forms
{
    public partial class EmpleadoActualizar : Form
    {
        OracleConnection conn;
        string conStr = @"DATA SOURCE = localhost:1521/orcl; USER ID=jsalazar;PASSWORD=jsalazar";

        bool IsMaster;
        public EmpleadoActualizar(bool ismaster)
        {
            InitializeComponent();
            conn = new OracleConnection(conStr);
            IsMaster = ismaster;
        }
        
        private void ListarDGV()
        {

            string consulta = "SELECT * FROM Empleado";
            conn.Open();
            OracleCommand comando = new OracleCommand(consulta, conn);
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DGV_Act.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla

        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_Act.Rows[e.RowIndex];

                string idEmpleado = row.Cells["idempleado"].Value.ToString();
                string idSucursal = row.Cells["idsucursal"].Value.ToString();
                string nombre = row.Cells["nombre"].Value.ToString();
                string apellido = row.Cells["apellido"].Value.ToString();
                string direccion = row.Cells["direccion"].Value.ToString();
                string ciudad = row.Cells["ciudad"].Value.ToString();
                string provincia = row.Cells["provincia"].Value.ToString();
                string telefono = row.Cells["telefono"].Value.ToString();

                // Establecer los valores en los cuadros de texto
                txt_ID.Text = idEmpleado;
                txt_IDSUCURSAL.Text = idSucursal;
                txt_NOMBRE.Text = nombre;
                txt_APELLIDO.Text = apellido;
                txt_Direccion.Text = direccion;
                txt_CIUDAD.Text = ciudad;
                txt_PROVINCIA.Text = provincia;
                txt_TELEFONO.Text = telefono;

                txt_ID.ReadOnly = true;
            }
        }

        private void Actualizar(string id, string idsucursal, string nombre, string apellido, string direccion, string ciudad, string provincia, string telefono)
        {
            string updateQuery = "";
            if (IsMaster)
            {
                updateQuery = "UPDATE Empleado SET IDSUCURSAL = :idsucursal, NOMBRE = :nombre, APELLIDO = :apellido, DIRECCION = :direccion, CIUDAD = :ciudad, PROVINCIA = :provincia, TELEFONO = :telefono WHERE IDEMPLEADO = :idEmpleado";
            }
            else
            {
                updateQuery = "UPDATE Empleado@replica_proyrad SET IDSUCURSAL = :idsucursal, NOMBRE = :nombre, APELLIDO = :apellido, DIRECCION = :direccion, CIUDAD = :ciudad, PROVINCIA = :provincia, TELEFONO = :telefono WHERE IDEMPLEADO = :idEmpleado";
            }


            // Crea un objeto OracleCommand
            OracleCommand updateCommand = new OracleCommand(updateQuery, conn);

            // Asigna valores a los parámetros
            updateCommand.Parameters.Add(":idsucursal", OracleDbType.Varchar2).Value = idsucursal;
            updateCommand.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nombre;
            updateCommand.Parameters.Add(":apellido", OracleDbType.Varchar2).Value = apellido;
            updateCommand.Parameters.Add(":direccion", OracleDbType.Varchar2).Value = direccion;
            updateCommand.Parameters.Add(":ciudad", OracleDbType.Varchar2).Value = ciudad;
            updateCommand.Parameters.Add(":provincia", OracleDbType.Varchar2).Value = provincia;
            updateCommand.Parameters.Add(":telefono", OracleDbType.Varchar2).Value = telefono;
            updateCommand.Parameters.Add(":idEmpleado", OracleDbType.Varchar2).Value = id;

            try
            {
                // Abre la conexión y ejecuta la consulta de actualización
                conn.Open();
                int rowsAffected = updateCommand.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("La actualización del empleado se realizó con éxito.");
                }
                else
                {
                    MessageBox.Show("No se encontró un empleado con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el empleado: " + ex.Message);
                conn.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string idsucursal = txt_IDSUCURSAL.Text;
            string nombre = txt_NOMBRE.Text;
            string apellido = txt_APELLIDO.Text;
            string direccion = txt_Direccion.Text;
            string ciudad = txt_CIUDAD.Text;
            string provincia = txt_PROVINCIA.Text;
            string telefono = txt_TELEFONO.Text;


            Actualizar(id, idsucursal, nombre, apellido, direccion, ciudad, provincia, telefono);
            ListarDGV(); // Actualiza el DataGridView para mostrar los datos actualizados
        }

        private void EmpleadoActualizar_Load(object sender, EventArgs e)
        {
            this.ListarDGV();
        }
    }
}
