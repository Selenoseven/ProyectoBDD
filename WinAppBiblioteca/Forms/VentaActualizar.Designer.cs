namespace WinAppBiblioteca.Forms
{
    partial class VentaActualizar
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_TOTAL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_search = new FontAwesome.Sharp.IconButton();
            this.txt_FECHA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_IDCLIENTE = new System.Windows.Forms.TextBox();
            this.txt_IDSUCURSAL = new System.Windows.Forms.TextBox();
            this.txt_IDVENTA = new System.Windows.Forms.TextBox();
            this.DGVProd_Act = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.ButEliminar = new FontAwesome.Sharp.IconButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProd_Act)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.txt_TOTAL);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Btn_search);
            this.panel3.Controls.Add(this.txt_FECHA);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_IDCLIENTE);
            this.panel3.Controls.Add(this.txt_IDSUCURSAL);
            this.panel3.Controls.Add(this.txt_IDVENTA);
            this.panel3.Location = new System.Drawing.Point(25, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 174);
            this.panel3.TabIndex = 30;
            // 
            // txt_TOTAL
            // 
            this.txt_TOTAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txt_TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TOTAL.ForeColor = System.Drawing.Color.White;
            this.txt_TOTAL.Location = new System.Drawing.Point(566, 98);
            this.txt_TOTAL.Name = "txt_TOTAL";
            this.txt_TOTAL.Size = new System.Drawing.Size(169, 24);
            this.txt_TOTAL.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(464, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "TOTAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "IDSUCURSAL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "IDVENTA:";
            // 
            // Btn_search
            // 
            this.Btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_search.FlatAppearance.BorderSize = 0;
            this.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.Btn_search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.Btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_search.IconSize = 28;
            this.Btn_search.Location = new System.Drawing.Point(342, 22);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(35, 24);
            this.Btn_search.TabIndex = 16;
            this.Btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_FECHA
            // 
            this.txt_FECHA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txt_FECHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FECHA.ForeColor = System.Drawing.Color.White;
            this.txt_FECHA.Location = new System.Drawing.Point(566, 40);
            this.txt_FECHA.Name = "txt_FECHA";
            this.txt_FECHA.Size = new System.Drawing.Size(169, 24);
            this.txt_FECHA.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(464, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "FECHA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "IDCLIENTE:";
            // 
            // txt_IDCLIENTE
            // 
            this.txt_IDCLIENTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txt_IDCLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDCLIENTE.ForeColor = System.Drawing.Color.White;
            this.txt_IDCLIENTE.Location = new System.Drawing.Point(151, 115);
            this.txt_IDCLIENTE.Name = "txt_IDCLIENTE";
            this.txt_IDCLIENTE.Size = new System.Drawing.Size(169, 24);
            this.txt_IDCLIENTE.TabIndex = 6;
            // 
            // txt_IDSUCURSAL
            // 
            this.txt_IDSUCURSAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txt_IDSUCURSAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDSUCURSAL.ForeColor = System.Drawing.Color.White;
            this.txt_IDSUCURSAL.Location = new System.Drawing.Point(151, 67);
            this.txt_IDSUCURSAL.Name = "txt_IDSUCURSAL";
            this.txt_IDSUCURSAL.Size = new System.Drawing.Size(168, 24);
            this.txt_IDSUCURSAL.TabIndex = 5;
            // 
            // txt_IDVENTA
            // 
            this.txt_IDVENTA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txt_IDVENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDVENTA.ForeColor = System.Drawing.Color.White;
            this.txt_IDVENTA.Location = new System.Drawing.Point(151, 19);
            this.txt_IDVENTA.Name = "txt_IDVENTA";
            this.txt_IDVENTA.Size = new System.Drawing.Size(168, 24);
            this.txt_IDVENTA.TabIndex = 4;
            // 
            // DGVProd_Act
            // 
            this.DGVProd_Act.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.DGVProd_Act.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DGVProd_Act.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProd_Act.Location = new System.Drawing.Point(12, 398);
            this.DGVProd_Act.Name = "DGVProd_Act";
            this.DGVProd_Act.Size = new System.Drawing.Size(968, 265);
            this.DGVProd_Act.TabIndex = 33;
            this.DGVProd_Act.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 27);
            this.label2.TabIndex = 31;
            this.label2.Text = "ACTUALIZAR VENTA";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.btnActualizar.FlatAppearance.BorderSize = 2;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Courier New", 18F);
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnActualizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 45;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(280, 320);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(204, 48);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ButEliminar
            // 
            this.ButEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.ButEliminar.FlatAppearance.BorderSize = 2;
            this.ButEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ButEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButEliminar.Font = new System.Drawing.Font("Courier New", 18F);
            this.ButEliminar.ForeColor = System.Drawing.Color.Red;
            this.ButEliminar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ButEliminar.IconColor = System.Drawing.Color.Red;
            this.ButEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButEliminar.IconSize = 45;
            this.ButEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButEliminar.Location = new System.Drawing.Point(556, 320);
            this.ButEliminar.Name = "ButEliminar";
            this.ButEliminar.Size = new System.Drawing.Size(204, 48);
            this.ButEliminar.TabIndex = 47;
            this.ButEliminar.Text = "ELIMINAR";
            this.ButEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButEliminar.UseVisualStyleBackColor = true;
            this.ButEliminar.Click += new System.EventHandler(this.ButEliminar_Click);
            // 
            // VentaActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1049, 675);
            this.Controls.Add(this.ButEliminar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DGVProd_Act);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentaActualizar";
            this.Text = "VentaActualizar";
            this.Load += new System.EventHandler(this.VentaActualizar_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProd_Act)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_TOTAL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Btn_search;
        private System.Windows.Forms.TextBox txt_FECHA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IDCLIENTE;
        private System.Windows.Forms.TextBox txt_IDSUCURSAL;
        private System.Windows.Forms.TextBox txt_IDVENTA;
        private System.Windows.Forms.DataGridView DGVProd_Act;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ButEliminar;
    }
}