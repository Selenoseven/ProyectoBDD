using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using WinAppBiblioteca.Logica;
using WinAppBiblioteca.Model;

namespace WinAppBiblioteca.Forms
{
    public partial class ProductoActualizar : Form
    {
        OracleConnection conn;
        string conStr;

        Usuario user;
        public ProductoActualizar(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
            conStr = @"DATA SOURCE = localhost:1521/orcl; USER ID=" + user.username + ";PASSWORD=" + user.password;
            conn = new OracleConnection(conStr);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            this.ListarDGV();
        }

        private void DGVLibro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVProd_Act.Rows[e.RowIndex];

                string idProducto = row.Cells["idproducto"].Value.ToString();
                string nombreProducto = row.Cells["nombreproducto"].Value.ToString();
                string descripcion = row.Cells["descripcion"].Value.ToString();
                decimal precioUnitario;

                // Verifica y convierte el valor del TextBox de Precio Unitario a decimal
                if (!decimal.TryParse(row.Cells["preciounitario"].Value.ToString(), out precioUnitario))
                {
                    MessageBox.Show("El precio unitario no es válido.");
                    return;
                }

                // Establecer los valores en los cuadros de texto
                txt_Codigo.Text = idProducto;
                txt_Nombre.Text = nombreProducto;
                txt_Desc.Text = descripcion;
                txt_PrecUnit.Text = precioUnitario.ToString();

                txt_Codigo.ReadOnly = true;
            }
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            
        }
        private void ListarDGV()
        {
            
            string consulta = "SELECT * FROM producto"; // Reemplaza mv_ejemplo con el nombre de tu vista materializada
            conn.Open(); // Abre la conexión a la base de datos Oracle
            OracleCommand comando = new OracleCommand(consulta, conn); // Utiliza "conn" como tu objeto de conexión
            OracleDataAdapter adaptador = new OracleDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DGVProd_Act.DataSource = tabla;

            conn.Close(); // Cierra la conexión después de usarla

        }

        private void ActualizarProducto(string idProducto, string nuevoNombre, string nuevaDescripcion, decimal nuevoPrecio)
        {
            // Verifica que el ID del producto no esté vacío (puedes agregar más validaciones según tus necesidades)
            if (string.IsNullOrWhiteSpace(idProducto))
            {
                MessageBox.Show("Por favor, ingresa el ID del producto que deseas actualizar.");
                return;
            }

            // Crea la consulta SQL de actualización
            string updateQuery = "";
            if (user.IsMaster)
            {
                updateQuery = "UPDATE Producto SET NombreProducto = :nuevoNombre, Descripcion = :nuevaDescripcion, PrecioUnitario = :nuevoPrecio WHERE IdProducto = :idProducto";
            }
            else
            {
                updateQuery = "UPDATE Producto@replica_proyrad SET NombreProducto = :nuevoNombre, Descripcion = :nuevaDescripcion, PrecioUnitario = :nuevoPrecio WHERE IdProducto = :idProducto";
            }

            // Crea un objeto OracleCommand
            OracleCommand updateCommand = new OracleCommand(updateQuery, conn);

            // Asigna valores a los parámetros
            updateCommand.Parameters.Add(":nuevoNombre", OracleDbType.Varchar2).Value = nuevoNombre;
            updateCommand.Parameters.Add(":nuevaDescripcion", OracleDbType.Varchar2).Value = nuevaDescripcion;
            updateCommand.Parameters.Add(":nuevoPrecio", OracleDbType.Decimal).Value = nuevoPrecio;
            updateCommand.Parameters.Add(":idProducto", OracleDbType.Varchar2).Value = idProducto;

            try
            {
                // Abre la conexión y ejecuta la consulta de actualización
                conn.Open();
                int rowsAffected = updateCommand.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("La actualización del producto se realizó con éxito.");
                }
                else
                {
                    MessageBox.Show("No se encontró un producto con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }

        // Luego puedes llamar a la función de actualización con los nuevos valores que desees
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idProducto = txt_Codigo.Text;
            string nuevoNombre = txt_Nombre.Text;
            string nuevaDescripcion = txt_Desc.Text;

            decimal nuevoPrecio;
            if (!decimal.TryParse(txt_PrecUnit.Text, out nuevoPrecio))
            {
                MessageBox.Show("El nuevo precio no es válido.");
                return;
            }

            ActualizarProducto(idProducto, nuevoNombre, nuevaDescripcion, nuevoPrecio);
            ListarDGV(); // Actualiza el DataGridView para mostrar los datos actualizados
        }


        private void limpiarTxt()
        {
            this.txt_Codigo.ReadOnly= false;
            foreach (Control control in panel3.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }



        private void DGVLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void EliminarProducto(string idProducto)
        {
            // Verifica que el ID del producto no esté vacío
            if (string.IsNullOrWhiteSpace(idProducto))
            {
                MessageBox.Show("Por favor, ingresa el ID del producto que deseas eliminar.");
                return;
            }

            string deleteQuery;
            if (user.IsMaster)
            {
                deleteQuery = "DELETE FROM Producto WHERE IdProducto = :idProducto";
            }
            else
            {
                deleteQuery = "DELETE FROM Producto@replica_proyrad WHERE IdProducto = :idProducto";
            }

            // Crea un objeto OracleCommand
            OracleCommand deleteCommand = new OracleCommand(deleteQuery, conn);

            // Asigna el valor al parámetro
            deleteCommand.Parameters.Add(":idProducto", OracleDbType.Varchar2).Value = idProducto;

            try
            {
                // Abre la conexión y ejecuta la consulta de eliminación
                conn.Open();
                int rowsAffected = deleteCommand.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("El producto se eliminó con éxito.");
                    ListarDGV(); // Actualiza el DataGridView para mostrar los datos actualizados
                }
                else
                {
                    MessageBox.Show("No se encontró un producto con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }
        private void ButEliminar_Click(object sender, EventArgs e)
        {
            string idProducto = txt_Codigo.Text;
            EliminarProducto(idProducto);
        }
    }
}
