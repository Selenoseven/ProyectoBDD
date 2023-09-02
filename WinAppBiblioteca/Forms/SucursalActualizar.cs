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
    public partial class SucursalActualizar : Form
    {
        OracleConnection conn;
        string conStr;

        Usuario user;

        public SucursalActualizar(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
            conStr = @"DATA SOURCE = localhost:1521/orcl; USER ID=" + user.username + ";PASSWORD=" + user.password;
            conn = new OracleConnection(conStr);
        }

        private void ListarDGV()
        {

            string consulta = "SELECT * FROM sucursal"; 
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

                string idSucursal = row.Cells["idsucursal"].Value.ToString();
                string nombreSucursal = row.Cells["nombresucursal"].Value.ToString();
                string direccion = row.Cells["direccion"].Value.ToString();
                string ciudad = row.Cells["ciudad"].Value.ToString();
                string provincia = row.Cells["provincia"].Value.ToString();
                string telefono = row.Cells["telefono"].Value.ToString();

                // Establecer los valores en los cuadros de texto
                txt_ID.Text = idSucursal;
                txt_NOMBRE.Text = nombreSucursal;
                txt_DIRECCION.Text = direccion;
                txt_CIUDAD.Text = ciudad;
                txt_PROVINCIA.Text = provincia;
                txt_TELEFONO.Text = telefono;

                txt_ID.ReadOnly = true;
            }
        }

        private void SucursalActualizar_Load(object sender, EventArgs e)
        {
            this.ListarDGV();
        }

        private void ActualizarVenta(string id, string nombre, string direccion, string ciudad, string provincia,string telefono)
        {

            string updateQuery = "";
            if (user.IsMaster)
            {
                updateQuery = "UPDATE Sucursal SET NombreSucursal = :nombreSucursal, Direccion = :direccion, Ciudad = :ciudad, Provincia = :provincia, Telefono = :telefono WHERE IDSUCURSAL = :idSucursal";
            }
            else
            {
                updateQuery = "UPDATE Sucursal@replica_proyrad SET NombreSucursal = :nombreSucursal, Direccion = :direccion, Ciudad = :ciudad, Provincia = :provincia, Telefono = :telefono WHERE IdSucursal = :idSucursal";
            }

            // Crea un objeto OracleCommand
            OracleCommand updateCommand = new OracleCommand(updateQuery, conn);

            // Asigna valores a los parámetros
            updateCommand.Parameters.Add(":nombreSucursal", OracleDbType.Varchar2).Value = nombre;
            updateCommand.Parameters.Add(":direccion", OracleDbType.Varchar2).Value = direccion;
            updateCommand.Parameters.Add(":ciudad", OracleDbType.Varchar2).Value = ciudad;
            updateCommand.Parameters.Add(":provincia", OracleDbType.Varchar2).Value = provincia;
            updateCommand.Parameters.Add(":telefono", OracleDbType.Varchar2).Value = telefono;
            updateCommand.Parameters.Add(":idSucursal", OracleDbType.Varchar2).Value = id;

            try
            {
                // Abre la conexión y ejecuta la consulta de actualización
                conn.Open();
                int rowsAffected = updateCommand.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("La actualización de la sucursal se realizó con éxito.");
                }
                else
                {
                    MessageBox.Show("No se encontró una sucursal con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la venta: " + ex.Message);
                conn.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string nombre = txt_NOMBRE.Text;
            string direccion = txt_DIRECCION.Text;
            string ciudad = txt_CIUDAD.Text;
            string provincia = txt_PROVINCIA.Text;
            string telefono = txt_TELEFONO.Text;


            ActualizarVenta(id, nombre, direccion, ciudad, provincia, telefono);
            ListarDGV(); // Actualiza el DataGridView para mostrar los datos actualizados
        }

    }
}
