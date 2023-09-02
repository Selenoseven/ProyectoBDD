using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppBiblioteca.Model;

namespace WinAppBiblioteca.Forms
{
    public partial class PedidoUIOActualizar : Form
    {
        OracleConnection conn;
        string conStr;

        Usuario user;
        public PedidoUIOActualizar(Usuario usuario)
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
                consulta = "SELECT * FROM pedido_uio";
            }
            else
            {
                consulta = "SELECT * FROM pedido_gye";
            }

            conn.Open();
            OracleCommand comando = new OracleCommand(consulta, conn);
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DGV_Act.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla

        }

        private void PedidoUIOActualizar_Load(object sender, EventArgs e)
        {
            ListarDGV();
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_Act.Rows[e.RowIndex];

                string idPedido = row.Cells["idpedido"].Value.ToString();
                string idSucursal = row.Cells["idsucursal"].Value.ToString();
                string idCliente = row.Cells["idcliente"].Value.ToString();
                DateTime fecha = Convert.ToDateTime(row.Cells["fecha"].Value);
                decimal total;

                // Verifica y convierte el valor del TextBox de Total a decimal
                if (!decimal.TryParse(row.Cells["total"].Value.ToString(), out total))
                {
                    MessageBox.Show("El total no es válido.");
                    return;
                }

                // Establecer los valores en los cuadros de texto
                txt_ID.Text = idPedido;
                txt_IDSUCURSAL.Text = idSucursal;
                txt_IDCLIENTE.Text = idCliente;
                txt_FECHA.Text = fecha.ToString();
                txt_TOTAL.Text = total.ToString();

                txt_ID.ReadOnly = true;
            }
        }
        private void Actualizar(string id, string idsucursal, string idcliente, DateTime fecha, decimal total)
        {

            string updateQuery;

            if (user.IsMaster)
            {
                 updateQuery = "UPDATE pedido_uio SET IDSUCURSAL = :idSucursal, IDCLIENTE = :idCliente, FECHA = :fecha, TOTAL = :total WHERE IDPEDIDO = :idPedido";
            }
            else
            {
                updateQuery = "UPDATE pedido_gye SET IDSUCURSAL = :idSucursal, IDCLIENTE = :idCliente, FECHA = :fecha, TOTAL = :total WHERE IDPEDIDO = :idPedido";
            }



            // Crea un objeto OracleCommand
            OracleCommand updateCommand = new OracleCommand(updateQuery, conn);

            // Asigna valores a los parámetros
            updateCommand.Parameters.Add(":idSucursal", OracleDbType.Varchar2).Value = idsucursal;
            updateCommand.Parameters.Add(":idCliente", OracleDbType.Varchar2).Value = idcliente;
            updateCommand.Parameters.Add(":fecha", OracleDbType.Date).Value = fecha;
            updateCommand.Parameters.Add(":total", OracleDbType.Decimal).Value = total;
            updateCommand.Parameters.Add(":idPedido", OracleDbType.Varchar2).Value = id;

            try
            {
                // Abre la conexión y ejecuta la consulta de actualización
                conn.Open();
                int rowsAffected = updateCommand.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("La actualización del pedido se realizó con éxito.");
                }
                else
                {
                    MessageBox.Show("No se encontró un pedido con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el pedido: " + ex.Message);
                conn.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string idSucursal = txt_IDSUCURSAL.Text;
            string idCliente = txt_IDCLIENTE.Text;

            DateTime fecha;
            if (!DateTime.TryParse(txt_FECHA.Text, out fecha))
            {
                MessageBox.Show("La fecha no es válida.");
                return;
            }

            decimal total;
            if (!decimal.TryParse(txt_TOTAL.Text, out total))
            {
                MessageBox.Show("El total no es válido.");
                return;
            }

            Actualizar(id, idSucursal, idCliente, fecha, total);
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
                    deleteQuery = "DELETE FROM pedido_uio WHERE IDPEDIDO = :idPedido";
                }
                else
                {
                    deleteQuery = "DELETE FROM pedido_gye WHERE IDPEDIDO = :idPedido";
                }

                // Crea un objeto OracleCommand
                OracleCommand deleteCommand = new OracleCommand(deleteQuery, conn);

                // Asigna el valor al parámetro
                deleteCommand.Parameters.Add(":idPedido", OracleDbType.Varchar2).Value = id;

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
