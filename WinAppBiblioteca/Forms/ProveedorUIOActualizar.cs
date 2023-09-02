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
    public partial class ProveedorUIOActualizar : Form
    {
        OracleConnection conn;
        string conStr;

        Usuario user;
        public ProveedorUIOActualizar(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
            conStr = @"DATA SOURCE = localhost:1521/orcl; USER ID=" + user.username + ";PASSWORD=" + user.password;
            conn = new OracleConnection(conStr);
        }
        private void ListarDGV()
        {

            string consulta;
            if (user.IsMaster)
            {
                consulta = "SELECT * FROM PROVEEDOR_UIO";
            }
            else
            {
                consulta = "SELECT * FROM PROVEEDOR_GYE";
            }

            conn.Open();
            OracleCommand comando = new OracleCommand(consulta, conn);
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DGV_Act.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla

        }

        private void ProveedorUIOActualizar_Load(object sender, EventArgs e)
        {
            this.ListarDGV();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_Act.Rows[e.RowIndex];

                string idCliente = row.Cells["idproveedor"].Value.ToString();
                string idSucursal = row.Cells["idsucursal"].Value.ToString();
                string nombre = row.Cells["nombreproveedor"].Value.ToString();
                string ciudad = row.Cells["ciudad"].Value.ToString();
                string provincia = row.Cells["provincia"].Value.ToString();
                string telefono = row.Cells["telefono"].Value.ToString();

                // Establecer los valores en los cuadros de texto
                txt_ID.Text = idCliente;
                txt_IDSUCURSAL.Text = idSucursal;
                txt_NOMBRE.Text = nombre;
                txt_CIUDAD.Text = ciudad;
                txt_PROVINCIA.Text = provincia;
                txt_TELEFONO.Text = telefono;

                txt_ID.ReadOnly = true;
            }
        }

        private void Actualizar(string id, string idsucursal, string nombre, string ciudad, string provincia, string telefono)
        {
            string updateQuery;

            if (user.IsMaster)
            {
                updateQuery = "UPDATE PROVEEDOR_UIO SET IDSUCURSAL = :idsucursal, NOMBREPROVEEDOR = :nombre, CIUDAD = :ciudad, PROVINCIA = :provincia, TELEFONO = :telefono WHERE IDPROVEEDOR = :idProveedor";
            }
            else
            {
                updateQuery = "UPDATE PROVEEDOR_GYE SET IDSUCURSAL = :idsucursal, NOMBREPROVEEDOR = :nombre, CIUDAD = :ciudad, PROVINCIA = :provincia, TELEFONO = :telefono WHERE IDPROVEEDOR = :idProveedor";
            }



            // Crea un objeto OracleCommand
            OracleCommand updateCommand = new OracleCommand(updateQuery, conn);

            // Asigna valores a los parámetros
            updateCommand.Parameters.Add(":idsucursal", OracleDbType.Varchar2).Value = idsucursal;
            updateCommand.Parameters.Add(":nombre", OracleDbType.Varchar2).Value = nombre;
            updateCommand.Parameters.Add(":ciudad", OracleDbType.Varchar2).Value = ciudad;
            updateCommand.Parameters.Add(":provincia", OracleDbType.Varchar2).Value = provincia;
            updateCommand.Parameters.Add(":telefono", OracleDbType.Varchar2).Value = telefono;
            updateCommand.Parameters.Add(":idProveedor", OracleDbType.Varchar2).Value = id;

            try
            {
                // Abre la conexión y ejecuta la consulta de actualización
                conn.Open();
                int rowsAffected = updateCommand.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("La actualización del proveedor se realizó con éxito.");
                }
                else
                {
                    MessageBox.Show("No se encontró un proveedor con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el proveedor: " + ex.Message);
                conn.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string idsucursal = txt_IDSUCURSAL.Text;
            string nombre = txt_NOMBRE.Text;
            string ciudad = txt_CIUDAD.Text;
            string provincia = txt_PROVINCIA.Text;
            string telefono = txt_TELEFONO.Text;


            Actualizar(id, idsucursal, nombre, ciudad, provincia, telefono);
            ListarDGV(); // Actualiza el DataGridView para mostrar los datos actualizados
        }

        private void ButEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ID.Text))
            {
                string id = txt_ID.Text;

                // Query para eliminar el registro
                string deleteQuery;
                if (user.IsMaster)
                {
                    deleteQuery = "DELETE FROM PROVEEDOR_UIO WHERE IDPROVEEDOR = :idProveedor";
                }
                else
                {
                    deleteQuery = "DELETE FROM PROVEEDOR_GYE WHERE IDPROVEEDOR = :idProveedor";
                }

                // Crea un objeto OracleCommand
                OracleCommand deleteCommand = new OracleCommand(deleteQuery, conn);

                // Asigna el valor al parámetro
                deleteCommand.Parameters.Add(":idProveedor", OracleDbType.Varchar2).Value = id;

                try
                {
                    // Abre la conexión y ejecuta la consulta de eliminación
                    conn.Open();
                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("El cliente se eliminó con éxito.");
                        ListarDGV(); // Actualiza el DataGridView para mostrar los datos actualizados
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un cliente con el ID especificado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista antes de eliminarlo.");
            }
        }
    }
}
