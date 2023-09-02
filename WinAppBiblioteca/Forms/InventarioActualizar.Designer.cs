namespace WinAppBiblioteca.Forms
{
    partial class InventarioActualizar
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
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_IDSUCURSAL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_IDPROD = new System.Windows.Forms.TextBox();
            this.DGV_Act = new System.Windows.Forms.DataGridView();
            this.txt_CANTIDAD = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButEliminar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Act)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.btnActualizar.Location = new System.Drawing.Point(205, 301);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(204, 48);
            this.btnActualizar.TabIndex = 44;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(73, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "ID SUCURSAL:";
            // 
            // txt_IDSUCURSAL
            // 
            this.txt_IDSUCURSAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txt_IDSUCURSAL.Enabled = false;
            this.txt_IDSUCURSAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDSUCURSAL.ForeColor = System.Drawing.Color.White;
            this.txt_IDSUCURSAL.Location = new System.Drawing.Point(232, 100);
            this.txt_IDSUCURSAL.Name = "txt_IDSUCURSAL";
            this.txt_IDSUCURSAL.Size = new System.Drawing.Size(168, 24);
            this.txt_IDSUCURSAL.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 27);
            this.label2.TabIndex = 43;
            this.label2.Text = "ACTUALIZAR INVENTARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID PRODUCTO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(509, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "CANTIDAD:";
            // 
            // txt_IDPROD
            // 
            this.txt_IDPROD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txt_IDPROD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDPROD.ForeColor = System.Drawing.Color.White;
            this.txt_IDPROD.Location = new System.Drawing.Point(232, 35);
            this.txt_IDPROD.Name = "txt_IDPROD";
            this.txt_IDPROD.Size = new System.Drawing.Size(168, 24);
            this.txt_IDPROD.TabIndex = 4;
            // 
            // DGV_Act
            // 
            this.DGV_Act.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.DGV_Act.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DGV_Act.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Act.Location = new System.Drawing.Point(11, 367);
            this.DGV_Act.Name = "DGV_Act";
            this.DGV_Act.Size = new System.Drawing.Size(968, 287);
            this.DGV_Act.TabIndex = 45;
            this.DGV_Act.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // txt_CANTIDAD
            // 
            this.txt_CANTIDAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txt_CANTIDAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CANTIDAD.ForeColor = System.Drawing.Color.White;
            this.txt_CANTIDAD.Location = new System.Drawing.Point(649, 36);
            this.txt_CANTIDAD.Name = "txt_CANTIDAD";
            this.txt_CANTIDAD.Size = new System.Drawing.Size(169, 24);
            this.txt_CANTIDAD.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_IDSUCURSAL);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_CANTIDAD);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_IDPROD);
            this.panel3.Location = new System.Drawing.Point(0, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1003, 174);
            this.panel3.TabIndex = 42;
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
            this.ButEliminar.Location = new System.Drawing.Point(483, 301);
            this.ButEliminar.Name = "ButEliminar";
            this.ButEliminar.Size = new System.Drawing.Size(204, 48);
            this.ButEliminar.TabIndex = 52;
            this.ButEliminar.Text = "ELIMINAR";
            this.ButEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButEliminar.UseVisualStyleBackColor = true;
            this.ButEliminar.Click += new System.EventHandler(this.ButEliminar_Click);
            // 
            // InventarioActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(984, 636);
            this.Controls.Add(this.ButEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_Act);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventarioActualizar";
            this.Text = "InventarioActualizar";
            this.Load += new System.EventHandler(this.InventarioActualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Act)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnActualizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_IDSUCURSAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_IDPROD;
        private System.Windows.Forms.DataGridView DGV_Act;
        private System.Windows.Forms.TextBox txt_CANTIDAD;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton ButEliminar;
    }
}