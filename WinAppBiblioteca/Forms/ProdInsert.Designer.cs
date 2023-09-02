namespace WinAppBiblioteca
{
    partial class ProdInsert
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
            this.lbNombreL = new System.Windows.Forms.Label();
            this.lbFechaL = new System.Windows.Forms.Label();
            this.lbEdicionL = new System.Windows.Forms.Label();
            this.lbNombreA = new System.Windows.Forms.Label();
            this.txtDisponibilidadL = new System.Windows.Forms.TextBox();
            this.lbInsertar = new System.Windows.Forms.Label();
            this.DGVINSERTPROD = new System.Windows.Forms.DataGridView();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
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
            this.btInsertar.Location = new System.Drawing.Point(486, 97);
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
            // lbNombreL
            // 
            this.lbNombreL.AutoSize = true;
            this.lbNombreL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.lbNombreL.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreL.ForeColor = System.Drawing.Color.White;
            this.lbNombreL.Location = new System.Drawing.Point(669, 62);
            this.lbNombreL.Name = "lbNombreL";
            this.lbNombreL.Size = new System.Drawing.Size(119, 20);
            this.lbNombreL.TabIndex = 12;
            this.lbNombreL.Text = " IdProducto";
            this.lbNombreL.Click += new System.EventHandler(this.lbNombreL_Click);
            // 
            // lbFechaL
            // 
            this.lbFechaL.AutoSize = true;
            this.lbFechaL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.lbFechaL.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaL.ForeColor = System.Drawing.Color.White;
            this.lbFechaL.Location = new System.Drawing.Point(665, 118);
            this.lbFechaL.Name = "lbFechaL";
            this.lbFechaL.Size = new System.Drawing.Size(152, 17);
            this.lbFechaL.TabIndex = 13;
            this.lbFechaL.Text = "  NombreProducto";
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
            this.lbEdicionL.Size = new System.Drawing.Size(129, 20);
            this.lbEdicionL.TabIndex = 14;
            this.lbEdicionL.Text = " Descripcion";
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
            this.lbNombreA.Size = new System.Drawing.Size(134, 17);
            this.lbNombreA.TabIndex = 15;
            this.lbNombreA.Text = "PrecioUnitario";
            this.lbNombreA.Click += new System.EventHandler(this.lbNombreA_Click);
            // 
            // txtDisponibilidadL
            // 
            this.txtDisponibilidadL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txtDisponibilidadL.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisponibilidadL.ForeColor = System.Drawing.Color.White;
            this.txtDisponibilidadL.Location = new System.Drawing.Point(668, 553);
            this.txtDisponibilidadL.Name = "txtDisponibilidadL";
            this.txtDisponibilidadL.ReadOnly = true;
            this.txtDisponibilidadL.Size = new System.Drawing.Size(281, 24);
            this.txtDisponibilidadL.TabIndex = 27;
            this.txtDisponibilidadL.TextChanged += new System.EventHandler(this.txtDisponibilidadL_TextChanged);
            // 
            // lbInsertar
            // 
            this.lbInsertar.AutoSize = true;
            this.lbInsertar.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInsertar.ForeColor = System.Drawing.Color.White;
            this.lbInsertar.Location = new System.Drawing.Point(50, 91);
            this.lbInsertar.Name = "lbInsertar";
            this.lbInsertar.Size = new System.Drawing.Size(374, 40);
            this.lbInsertar.TabIndex = 28;
            this.lbInsertar.Text = "INSERTAR PRODUCTO";
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
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(688, 85);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(261, 20);
            this.txtIdProducto.TabIndex = 29;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(688, 149);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(261, 20);
            this.txtNombreProducto.TabIndex = 30;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(688, 214);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(261, 20);
            this.txtDescripcion.TabIndex = 31;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(688, 282);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(261, 20);
            this.txtPrecioUnitario.TabIndex = 32;
            // 
            // ProdInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.lbInsertar);
            this.Controls.Add(this.txtDisponibilidadL);
            this.Controls.Add(this.lbNombreA);
            this.Controls.Add(this.lbEdicionL);
            this.Controls.Add(this.lbFechaL);
            this.Controls.Add(this.lbNombreL);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btInsertar);
            this.Controls.Add(this.DGVINSERTPROD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdInsert";
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
        private System.Windows.Forms.Label lbNombreL;
        private System.Windows.Forms.Label lbFechaL;
        private System.Windows.Forms.Label lbEdicionL;
        private System.Windows.Forms.Label lbNombreA;
        private System.Windows.Forms.TextBox txtDisponibilidadL;
        private System.Windows.Forms.Label lbInsertar;
        private System.Windows.Forms.DataGridView DGVINSERTPROD;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
    }
}