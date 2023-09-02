namespace WinAppBiblioteca
{
    partial class ClienteGYEinsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btInsertar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.lbFechaL = new System.Windows.Forms.Label();
            this.lbEdicionL = new System.Windows.Forms.Label();
            this.lbNombreA = new System.Windows.Forms.Label();
            this.lbInsertar = new System.Windows.Forms.Label();
            this.DGVINSERTPROD = new System.Windows.Forms.DataGridView();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtIdSucursal = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVINSERTPROD)).BeginInit();
            this.SuspendLayout();
            // 
            // btInsertar
            // 
            this.btInsertar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btInsertar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btInsertar.Location = new System.Drawing.Point(526, 91);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(85, 33);
            this.btInsertar.TabIndex = 4;
            this.btInsertar.Text = "Insertar";
            this.btInsertar.UseVisualStyleBackColor = false;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.btCancelar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btCancelar.Location = new System.Drawing.Point(668, 583);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(93, 30);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Visible = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(89)))));
            this.btGuardar.Location = new System.Drawing.Point(834, 583);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(89, 30);
            this.btGuardar.TabIndex = 10;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Visible = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // lbFechaL
            // 
            this.lbFechaL.AutoSize = true;
            this.lbFechaL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.lbFechaL.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaL.ForeColor = System.Drawing.Color.White;
            this.lbFechaL.Location = new System.Drawing.Point(685, 114);
            this.lbFechaL.Name = "lbFechaL";
            this.lbFechaL.Size = new System.Drawing.Size(0, 17);
            this.lbFechaL.TabIndex = 13;
            this.lbFechaL.Click += new System.EventHandler(this.lbFechaL_Click);
            // 
            // lbEdicionL
            // 
            this.lbEdicionL.AutoSize = true;
            this.lbEdicionL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.lbEdicionL.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdicionL.ForeColor = System.Drawing.Color.White;
            this.lbEdicionL.Location = new System.Drawing.Point(684, 182);
            this.lbEdicionL.Name = "lbEdicionL";
            this.lbEdicionL.Size = new System.Drawing.Size(69, 20);
            this.lbEdicionL.TabIndex = 14;
            this.lbEdicionL.Text = "Nombre";
            this.lbEdicionL.Click += new System.EventHandler(this.lbEdicionL_Click);
            // 
            // lbNombreA
            // 
            this.lbNombreA.AutoSize = true;
            this.lbNombreA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.lbNombreA.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreA.ForeColor = System.Drawing.Color.White;
            this.lbNombreA.Location = new System.Drawing.Point(685, 250);
            this.lbNombreA.Name = "lbNombreA";
            this.lbNombreA.Size = new System.Drawing.Size(80, 17);
            this.lbNombreA.TabIndex = 15;
            this.lbNombreA.Text = "Apellido";
            this.lbNombreA.Click += new System.EventHandler(this.lbNombreA_Click);
            // 
            // lbInsertar
            // 
            this.lbInsertar.AutoSize = true;
            this.lbInsertar.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInsertar.ForeColor = System.Drawing.Color.White;
            this.lbInsertar.Location = new System.Drawing.Point(32, 42);
            this.lbInsertar.Name = "lbInsertar";
            this.lbInsertar.Size = new System.Drawing.Size(563, 40);
            this.lbInsertar.TabIndex = 28;
            this.lbInsertar.Text = "INSERTAR CLIENTE GYE Y UIO";
            // 
            // DGVINSERTPROD
            // 
            this.DGVINSERTPROD.AllowUserToAddRows = false;
            this.DGVINSERTPROD.AllowUserToDeleteRows = false;
            this.DGVINSERTPROD.AllowUserToOrderColumns = true;
            this.DGVINSERTPROD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.DGVINSERTPROD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVINSERTPROD.Location = new System.Drawing.Point(21, 161);
            this.DGVINSERTPROD.Name = "DGVINSERTPROD";
            this.DGVINSERTPROD.ReadOnly = true;
            this.DGVINSERTPROD.Size = new System.Drawing.Size(623, 348);
            this.DGVINSERTPROD.TabIndex = 0;
            this.DGVINSERTPROD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(688, 85);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(261, 20);
            this.txtIdCliente.TabIndex = 29;
            // 
            // txtIdSucursal
            // 
            this.txtIdSucursal.Location = new System.Drawing.Point(688, 149);
            this.txtIdSucursal.Name = "txtIdSucursal";
            this.txtIdSucursal.Size = new System.Drawing.Size(261, 20);
            this.txtIdSucursal.TabIndex = 30;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(688, 214);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 20);
            this.txtNombre.TabIndex = 31;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(688, 282);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(261, 20);
            this.txtApellido.TabIndex = 32;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(688, 358);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(261, 20);
            this.txtCiudad.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(685, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ciudad";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(688, 428);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(261, 20);
            this.txtProvincia.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(685, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Provincia";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(688, 498);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(261, 20);
            this.txtTelefono.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.label3.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(685, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.label4.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(684, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "IDCliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.label5.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(684, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "IDSucursal";
            // 
            // ClienteGYEinsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdSucursal);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lbInsertar);
            this.Controls.Add(this.lbNombreA);
            this.Controls.Add(this.lbEdicionL);
            this.Controls.Add(this.lbFechaL);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.DGVINSERTPROD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClienteGYEinsert";
            this.Text = "Insertar";
            this.Load += new System.EventHandler(this.Insertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVINSERTPROD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label lbFechaL;
        private System.Windows.Forms.Label lbEdicionL;
        private System.Windows.Forms.Label lbNombreA;
        private System.Windows.Forms.Label lbInsertar;
        private System.Windows.Forms.DataGridView DGVINSERTPROD;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtIdSucursal;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}