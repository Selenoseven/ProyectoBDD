using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppBiblioteca.Forms;
using WinAppBiblioteca.Model;

namespace WinAppBiblioteca
{
    public partial class Diseno : Form
    {
        static Usuario user ;
        Query query;

        private Form formularioActual = null;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
     (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse

      );
        
        public Diseno(Usuario usuario)
        {
            InitializeComponent();
            user = usuario;
            
            Console.WriteLine(user.ToString());
            label4.Text = user.username;
            if (usuario.IsMaster)
            {
                btnReplic.Visible= false;
                label2.Text = "MASTER";
            }
            else
            {
                btnAuditoria.Visible= false;
                label2.Text = "REPLICA";
            }
        }
        private Point lastLocation;

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastLocation = e.Location;
            }
        }

        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void ButtonColorReset(Button button)
        {
            Color activeColor = Color.FromArgb(31, 27, 48);
            Color btnColor = Color.FromArgb(26, 23, 40);
            btnInsert.BackColor = btnColor;
            btnUpdate.BackColor = btnColor;
            btnFrag.BackColor = btnColor;
            btnReplic.BackColor = btnColor;
            btnAuditoria.BackColor = btnColor;
            btnSettings.BackColor = btnColor;
            button.BackColor = activeColor;
        }

        private void BtnInsert_Click(object sender, EventArgs e) //Insertar
        {
            this.menuStripUpdate.Visible = false;
            pnlNavIndicator.Height = btnInsert.Height;
            pnlNavIndicator.Top = btnInsert.Top;
            pnlNavIndicator.Left = btnInsert.Left;
            ButtonColorReset(btnInsert);
            
            this.menuStripInsert.Visible = true;
           
            lblTabTitle.Text = "Insertar";
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }
        }

        public void MostrarPanel(int opc)
        {
            switch (opc)
            {
                case 1:

                    ClienteGYEinsert clientInsert = new ClienteGYEinsert(user) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    this.pnlContent.Controls.Add(clientInsert);
                    clientInsert.Show();
                    break;
            }

        }
        private void BtnAuditoria_Click(object sender, EventArgs e)
        {
            this.menuStripInsert.Visible = false;
            this.menuStripUpdate.Visible = false;
            pnlNavIndicator.Height = btnAuditoria.Height;
            pnlNavIndicator.Top = btnAuditoria.Top;
            pnlNavIndicator.Left = btnAuditoria.Left;
            ButtonColorReset(btnAuditoria);

            lblTabTitle.Text = "Auditoria";
            //this.pnlContent.Controls.Clear();

            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            Auditoria formactual = new Auditoria(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(formactual);
            formactual.Show();
            formularioActual = formactual;


        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.menuStripInsert.Visible = false;
            pnlNavIndicator.Height = btnUpdate.Height;
            pnlNavIndicator.Top = btnUpdate.Top;
            pnlNavIndicator.Left = btnUpdate.Left;
            ButtonColorReset(btnUpdate);

            lblTabTitle.Text = "Update";
            this.menuStripUpdate.Visible = true;

            if (formularioActual != null)
            {
                formularioActual.Hide();
            }
            /*
            ProdInsert FormINSERT = new ProdInsert(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(FormINSERT);
            FormINSERT.Show();
            formularioActual = FormINSERT;*/

        }

        private void btnFrag_Click(object sender, EventArgs e)
        {
            this.menuStripInsert.Visible =false;
            this.menuStripUpdate.Visible =false;
            pnlNavIndicator.Height = btnFrag.Height;
            pnlNavIndicator.Top = btnFrag.Top;
            pnlNavIndicator.Left = btnFrag.Left;
            ButtonColorReset(btnFrag);

            lblTabTitle.Text = "Fragmentacion";
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            ReadFrag readFrag = new ReadFrag(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            this.pnlContent.Controls.Add(readFrag);
            readFrag.Show();
            formularioActual = readFrag;
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            this.menuStripInsert.Visible = false;
            this.menuStripUpdate.Visible = false;

            pnlNavIndicator.Height = btnReplic.Height;
            pnlNavIndicator.Top = btnReplic.Top;
            pnlNavIndicator.Left = btnReplic.Left;
            ButtonColorReset(btnReplic);

            lblTabTitle.Text = "REPLICACIÓN";

            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            VistaMaterializada formactual = new VistaMaterializada()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(formactual);
            formactual.Show();
            formularioActual = formactual;

            //this.pnlContent.Controls.Clear();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            ClienteGYEinsert clienteinsert = new ClienteGYEinsert(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(clienteinsert);
            clienteinsert.Show();
            formularioActual = clienteinsert;
        }

       

        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            EmpleadoINSERT empleadoINSERT = new EmpleadoINSERT(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(empleadoINSERT);
            empleadoINSERT.Show();

            formularioActual = empleadoINSERT;
        }

        private void iNVENTARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            InventarioINSERT inventarioINSERT = new InventarioINSERT(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(inventarioINSERT);
            inventarioINSERT.Show();

            formularioActual = inventarioINSERT;
        }


        private void pRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            ProdInsert FormINSERT = new ProdInsert(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(FormINSERT);
            FormINSERT.Show();
            formularioActual = FormINSERT;
        }

        private void pROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            ProveedorGYEinsert FormINSERT = new ProveedorGYEinsert(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(FormINSERT);
            FormINSERT.Show();
            formularioActual = FormINSERT;

        }

        private void pEDIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            PedidoGYEinsert FormINSERT = new PedidoGYEinsert(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(FormINSERT);
            FormINSERT.Show();
            formularioActual = FormINSERT;
        }

        private void vENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            VENTAinsert FormINSERT = new VENTAinsert(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(FormINSERT);
            FormINSERT.Show();
            formularioActual = FormINSERT;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            ClienteGYEActualizar formUPDATE = new ClienteGYEActualizar(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(formUPDATE);
            formUPDATE.Show();
            formularioActual = formUPDATE;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            EmpleadoActualizar formUPDATE = new EmpleadoActualizar(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(formUPDATE);
            formUPDATE.Show();
            formularioActual = formUPDATE;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            InventarioActualizar formUPDATE = new InventarioActualizar(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(formUPDATE);
            formUPDATE.Show();
            formularioActual = formUPDATE;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            ProductoActualizar formUPDATE = new ProductoActualizar(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(formUPDATE);
            formUPDATE.Show();
            formularioActual = formUPDATE;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            ProveedorUIOActualizar formUPDATE = new ProveedorUIOActualizar(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(formUPDATE);
            formUPDATE.Show();
            formularioActual = formUPDATE;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            PedidoUIOActualizar formUPDATE = new PedidoUIOActualizar(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(formUPDATE);
            formUPDATE.Show();
            formularioActual = formUPDATE;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (formularioActual != null)
            {
                formularioActual.Hide();
            }

            VentaActualizar formUPDATE = new VentaActualizar(user)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };

            this.pnlContent.Controls.Add(formUPDATE);
            formUPDATE.Show();
            formularioActual = formUPDATE;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Visible = true;
        }
    }
}
