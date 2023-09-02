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
    public partial class VentaActualizar : Form
    {
        OracleConnection conn;
        string conStr;
        Usuario user;

        public VentaActualizar(Usuario usuario)
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
            DGVProd_Act.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla

        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVProd_Act.Rows[e.RowIndex];

                string idVenta = row.Cells["idventa"].Value.ToString();
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
                txt_IDVENTA.Text = idVenta;
                txt_IDSUCURSAL.Text = idSucursal;
                txt_IDCLIENTE.Text = idCliente;
                txt_FECHA.Text = fecha.ToString("yyyy-MM-dd"); // Ajusta el formato según tus necesidades
                txt_TOTAL.Text = total.ToString();

                txt_IDVENTA.ReadOnly = true;
            }
        }

        private void ActualizarVenta(string idVenta, string idSucursal, string idCliente, DateTime fecha, decimal total)
        {
            // Verifica que el ID de la venta no esté vacío
            if (string.IsNullOrWhiteSpace(idVenta))
            {
                MessageBox.Show("Por favor, ingresa el ID de la venta que deseas actualizar.");
                return;
            }


            string updateQuery;
            if (user.IsMaster)
            {
                updateQuery = "UPDATE Venta SET IDSUCURSAL = :idSucursal, IDCLIENTE = :idCliente, FECHA = :fecha, TOTAL = :total WHERE IDVENTA = :idVenta";
            }
            else
            {
                updateQuery = "UPDATE Venta@replica_proyrad SET IDSUCURSAL = :idSucursal, IDCLIENTE = :idCliente, FECHA = :fecha, TOTAL = :total WHERE IDVENTA = :idVenta";
            }

            // Crea un objeto OracleCommand
            OracleCommand updateCommand = new OracleCommand(updateQuery, conn);

            // Asigna valores a los parámetros
            updateCommand.Parameters.Add(":idSucursal", OracleDbType.Varchar2).Value = idSucursal;
            updateCommand.Parameters.Add(":idCliente", OracleDbType.Varchar2).Value = idCliente;
            updateCommand.Parameters.Add(":fecha", OracleDbType.Date).Value = fecha;
            updateCommand.Parameters.Add(":total", OracleDbType.Decimal).Value = total;
            updateCommand.Parameters.Add(":idVenta", OracleDbType.Varchar2).Value = idVenta;

            try
            {
                // Abre la conexión y ejecuta la consulta de actualización
                conn.Open();
                int rowsAffected = updateCommand.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("La actualización de la venta se realizó con éxito.");
                }
                else
                {
                    MessageBox.Show("No se encontró una venta con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la venta: " + ex.Message);
                conn.Close();
            }
        }

        // Luego puedes llamar a la función de actualización con los nuevos valores que desees
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idVenta = txt_IDVENTA.Text;
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

            ActualizarVenta(idVenta, idSucursal, idCliente, fecha, total);
            ListarDGV(); // Actualiza el DataGridView para mostrar los datos actualizados
        }

        private void VentaActualizar_Load(object sender, EventArgs e)
        {
            this.ListarDGV();
        }
        private void EliminarVenta(string idVenta)
        {
            // Verifica que el ID de la venta no esté vacío
            if (string.IsNullOrWhiteSpace(idVenta))
            {
                MessageBox.Show("Por favor, ingresa el ID de la venta que deseas eliminar.");
                return;
            }

            string deleteQuery;
            if (user.IsMaster)
            {
                deleteQuery = "DELETE FROM Venta WHERE IDVENTA = :idVenta";
            }
            else
            {
                deleteQuery = "DELETE FROM Venta@replica_proyrad WHERE IDVENTA = :idVenta";
            }

            // Crea un objeto OracleCommand
            OracleCommand deleteCommand = new OracleCommand(deleteQuery, conn);

            // Asigna el valor al parámetro
            deleteCommand.Parameters.Add(":idVenta", OracleDbType.Varchar2).Value = idVenta;

            try
            {
                // Abre la conexión y ejecuta la consulta de eliminación
                conn.Open();
                int rowsAffected = deleteCommand.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("La venta se eliminó con éxito.");
                    ListarDGV(); // Actualiza el DataGridView para mostrar los datos actualizados
                }
                else
                {
                    MessageBox.Show("No se encontró una venta con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la venta: " + ex.Message);
                conn.Close();
            }
        }
        private void ButEliminar_Click(object sender, EventArgs e)
        {
            string idVenta = txt_IDVENTA.Text;
            EliminarVenta(idVenta);
        }
    }
}
