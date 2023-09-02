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
    public partial class TablasInsert : Form
    {
        Usuario user;
        Diseno diseno;
        public TablasInsert(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
            diseno = new Diseno(user);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            /*ClienteGYEinsert clienteIns = new ClienteGYEinsert(user);
            //diseno.MostrarPanel(clienteIns);
            this.Hide();
            diseno.pnlContent.Controls.Add(clienteIns);
            clienteIns.Show();*/
            this.Close();
            diseno.MostrarPanel(1);

        }
    }
}
