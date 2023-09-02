namespace WinAppBiblioteca
{
    partial class Insertar
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
            this.lbApellidoA = new System.Windows.Forms.Label();
            this.lbCategoriaL = new System.Windows.Forms.Label();
            this.lbStockL = new System.Windows.Forms.Label();
            this.lbDisponibilidadL = new System.Windows.Forms.Label();
            this.txtNombreL = new System.Windows.Forms.TextBox();
            this.txtFechaL = new System.Windows.Forms.TextBox();
            this.txtEdicionL = new System.Windows.Forms.TextBox();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.txtApellidoA = new System.Windows.Forms.TextBox();
            this.txtCategoriaL = new System.Windows.Forms.TextBox();
            this.txtStockL = new System.Windows.Forms.TextBox();
            this.txtDisponibilidadL = new System.Windows.Forms.TextBox();
            this.lbInsertar = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txt_codigo_libro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btInsertar
            // 
            this.btInsertar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btInsertar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btInsertar.Location = new System.Drawing.Point(312, 91);
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
            this.lbNombreL.Size = new System.Drawing.Size(159, 20);
            this.lbNombreL.TabIndex = 12;
            this.lbNombreL.Text = "Nombre de Libro";
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
            this.lbFechaL.Text = "Fecha de entrega";
            this.lbFechaL.Click += new System.EventHandler(this.lbFechaL_Click);
            // 
            // lbEdicionL
            // 
            this.lbEdicionL.AutoSize = true;
            this.lbEdicionL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.lbEdicionL.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdicionL.ForeColor = System.Drawing.Color.White;
            this.lbEdicionL.Location = new System.Drawing.Point(669, 191);
            this.lbEdicionL.Name = "lbEdicionL";
            this.lbEdicionL.Size = new System.Drawing.Size(79, 20);
            this.lbEdicionL.TabIndex = 14;
            this.lbEdicionL.Text = "Edición";
            this.lbEdicionL.Click += new System.EventHandler(this.lbEdicionL_Click);
            // 
            // lbNombreA
            // 
            this.lbNombreA.AutoSize = true;
            this.lbNombreA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.lbNombreA.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreA.ForeColor = System.Drawing.Color.White;
            this.lbNombreA.Location = new System.Drawing.Point(667, 252);
            this.lbNombreA.Name = "lbNombreA";
            this.lbNombreA.Size = new System.Drawing.Size(143, 17);
            this.lbNombreA.TabIndex = 15;
            this.lbNombreA.Text = "Nombre de Autor";
            this.lbNombreA.Click += new System.EventHandler(this.lbNombreA_Click);
            // 
            // lbApellidoA
            // 
            this.lbApellidoA.AutoSize = true;
            this.lbApellidoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.lbApellidoA.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidoA.ForeColor = System.Drawing.Color.White;
            this.lbApellidoA.Location = new System.Drawing.Point(667, 320);
            this.lbApellidoA.Name = "lbApellidoA";
            this.lbApellidoA.Size = new System.Drawing.Size(161, 17);
            this.lbApellidoA.TabIndex = 16;
            this.lbApellidoA.Text = "Apellido de Autor";
            this.lbApellidoA.Click += new System.EventHandler(this.lbApellidoA_Click);
            // 
            // lbCategoriaL
            // 
            this.lbCategoriaL.AutoSize = true;
            this.lbCategoriaL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.lbCategoriaL.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoriaL.ForeColor = System.Drawing.Color.White;
            this.lbCategoriaL.Location = new System.Drawing.Point(668, 388);
            this.lbCategoriaL.Name = "lbCategoriaL";
            this.lbCategoriaL.Size = new System.Drawing.Size(99, 20);
            this.lbCategoriaL.TabIndex = 17;
            this.lbCategoriaL.Text = "Categoría";
            this.lbCategoriaL.Click += new System.EventHandler(this.lbCategoriaL_Click);
            // 
            // lbStockL
            // 
            this.lbStockL.AutoSize = true;
            this.lbStockL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.lbStockL.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockL.ForeColor = System.Drawing.Color.White;
            this.lbStockL.Location = new System.Drawing.Point(668, 455);
            this.lbStockL.Name = "lbStockL";
            this.lbStockL.Size = new System.Drawing.Size(59, 20);
            this.lbStockL.TabIndex = 18;
            this.lbStockL.Text = "Stock";
            this.lbStockL.Click += new System.EventHandler(this.lbStockL_Click);
            // 
            // lbDisponibilidadL
            // 
            this.lbDisponibilidadL.AutoSize = true;
            this.lbDisponibilidadL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.lbDisponibilidadL.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisponibilidadL.ForeColor = System.Drawing.Color.White;
            this.lbDisponibilidadL.Location = new System.Drawing.Point(668, 523);
            this.lbDisponibilidadL.Name = "lbDisponibilidadL";
            this.lbDisponibilidadL.Size = new System.Drawing.Size(134, 17);
            this.lbDisponibilidadL.TabIndex = 19;
            this.lbDisponibilidadL.Text = "Disponibilidad";
            this.lbDisponibilidadL.Click += new System.EventHandler(this.lbDisponibilidadL_Click);
            // 
            // txtNombreL
            // 
            this.txtNombreL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txtNombreL.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreL.ForeColor = System.Drawing.Color.White;
            this.txtNombreL.Location = new System.Drawing.Point(670, 91);
            this.txtNombreL.Name = "txtNombreL";
            this.txtNombreL.ReadOnly = true;
            this.txtNombreL.Size = new System.Drawing.Size(281, 24);
            this.txtNombreL.TabIndex = 20;
            this.txtNombreL.TextChanged += new System.EventHandler(this.txtNombreL_TextChanged);
            // 
            // txtFechaL
            // 
            this.txtFechaL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txtFechaL.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaL.ForeColor = System.Drawing.Color.White;
            this.txtFechaL.Location = new System.Drawing.Point(668, 146);
            this.txtFechaL.Name = "txtFechaL";
            this.txtFechaL.ReadOnly = true;
            this.txtFechaL.Size = new System.Drawing.Size(286, 24);
            this.txtFechaL.TabIndex = 21;
            this.txtFechaL.TextChanged += new System.EventHandler(this.txtFechaL_TextChanged);
            // 
            // txtEdicionL
            // 
            this.txtEdicionL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txtEdicionL.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicionL.ForeColor = System.Drawing.Color.White;
            this.txtEdicionL.Location = new System.Drawing.Point(668, 214);
            this.txtEdicionL.Name = "txtEdicionL";
            this.txtEdicionL.ReadOnly = true;
            this.txtEdicionL.Size = new System.Drawing.Size(281, 24);
            this.txtEdicionL.TabIndex = 22;
            this.txtEdicionL.TextChanged += new System.EventHandler(this.txtEdicionL_TextChanged);
            // 
            // txtNombreA
            // 
            this.txtNombreA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txtNombreA.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreA.ForeColor = System.Drawing.Color.White;
            this.txtNombreA.Location = new System.Drawing.Point(668, 282);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.ReadOnly = true;
            this.txtNombreA.Size = new System.Drawing.Size(281, 24);
            this.txtNombreA.TabIndex = 23;
            this.txtNombreA.TextChanged += new System.EventHandler(this.txtNombreA_TextChanged);
            // 
            // txtApellidoA
            // 
            this.txtApellidoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txtApellidoA.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoA.ForeColor = System.Drawing.Color.White;
            this.txtApellidoA.Location = new System.Drawing.Point(668, 350);
            this.txtApellidoA.Name = "txtApellidoA";
            this.txtApellidoA.ReadOnly = true;
            this.txtApellidoA.Size = new System.Drawing.Size(281, 24);
            this.txtApellidoA.TabIndex = 24;
            this.txtApellidoA.TextChanged += new System.EventHandler(this.txtApellidoA_TextChanged);
            // 
            // txtCategoriaL
            // 
            this.txtCategoriaL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txtCategoriaL.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaL.ForeColor = System.Drawing.Color.White;
            this.txtCategoriaL.Location = new System.Drawing.Point(673, 418);
            this.txtCategoriaL.Name = "txtCategoriaL";
            this.txtCategoriaL.ReadOnly = true;
            this.txtCategoriaL.Size = new System.Drawing.Size(281, 24);
            this.txtCategoriaL.TabIndex = 25;
            this.txtCategoriaL.TextChanged += new System.EventHandler(this.txtCategoriaL_TextChanged);
            // 
            // txtStockL
            // 
            this.txtStockL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txtStockL.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockL.ForeColor = System.Drawing.Color.White;
            this.txtStockL.Location = new System.Drawing.Point(670, 485);
            this.txtStockL.Name = "txtStockL";
            this.txtStockL.ReadOnly = true;
            this.txtStockL.Size = new System.Drawing.Size(281, 24);
            this.txtStockL.TabIndex = 26;
            this.txtStockL.TextChanged += new System.EventHandler(this.txtStockL_TextChanged);
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
            this.lbInsertar.Size = new System.Drawing.Size(185, 40);
            this.lbInsertar.TabIndex = 28;
            this.lbInsertar.Text = "INSERTAR";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.White;
            this.lbCodigo.Location = new System.Drawing.Point(669, 5);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(129, 20);
            this.lbCodigo.TabIndex = 29;
            this.lbCodigo.Text = "Código(ISBN)";
            this.lbCodigo.Click += new System.EventHandler(this.lbCodigo_Click);
            // 
            // txt_codigo_libro
            // 
            this.txt_codigo_libro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.txt_codigo_libro.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_libro.ForeColor = System.Drawing.Color.White;
            this.txt_codigo_libro.Location = new System.Drawing.Point(669, 39);
            this.txt_codigo_libro.Name = "txt_codigo_libro";
            this.txt_codigo_libro.Size = new System.Drawing.Size(276, 24);
            this.txt_codigo_libro.TabIndex = 30;
            this.txt_codigo_libro.TextChanged += new System.EventHandler(this.txt_codigo_libro_TextChanged_1);
            // 
            // Insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(984, 636);
            this.Controls.Add(this.txt_codigo_libro);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbInsertar);
            this.Controls.Add(this.txtDisponibilidadL);
            this.Controls.Add(this.txtStockL);
            this.Controls.Add(this.txtCategoriaL);
            this.Controls.Add(this.txtApellidoA);
            this.Controls.Add(this.txtNombreA);
            this.Controls.Add(this.txtEdicionL);
            this.Controls.Add(this.txtFechaL);
            this.Controls.Add(this.txtNombreL);
            this.Controls.Add(this.lbDisponibilidadL);
            this.Controls.Add(this.lbStockL);
            this.Controls.Add(this.lbCategoriaL);
            this.Controls.Add(this.lbApellidoA);
            this.Controls.Add(this.lbNombreA);
            this.Controls.Add(this.lbEdicionL);
            this.Controls.Add(this.lbFechaL);
            this.Controls.Add(this.lbNombreL);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btInsertar);
            this.Name = "Insertar";
            this.Text = "Insertar";
            this.Load += new System.EventHandler(this.Insertar_Load);
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
        private System.Windows.Forms.Label lbApellidoA;
        private System.Windows.Forms.Label lbCategoriaL;
        private System.Windows.Forms.Label lbStockL;
        private System.Windows.Forms.Label lbDisponibilidadL;
        private System.Windows.Forms.TextBox txtNombreL;
        private System.Windows.Forms.TextBox txtFechaL;
        private System.Windows.Forms.TextBox txtEdicionL;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.TextBox txtApellidoA;
        private System.Windows.Forms.TextBox txtCategoriaL;
        private System.Windows.Forms.TextBox txtStockL;
        private System.Windows.Forms.TextBox txtDisponibilidadL;
        private System.Windows.Forms.Label lbInsertar;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txt_codigo_libro;
    }
}