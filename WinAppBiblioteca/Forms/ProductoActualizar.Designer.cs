namespace WinAppBiblioteca.Forms
{
    partial class ProductoActualizar
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
            this.Btn_search = new FontAwesome.Sharp.IconButton();
            this.txt_PrecUnit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVProd_Act = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.ButEliminar = new FontAwesome.Sharp.IconButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProd_Act)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.Btn_search);
            this.panel3.Controls.Add(this.txt_PrecUnit);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_Desc);
            this.panel3.Controls.Add(this.txt_Nombre);
            this.panel3.Controls.Add(this.txt_Codigo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(37, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 174);
            this.panel3.TabIndex = 12;
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
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // txt_PrecUnit
            // 
            this.txt_PrecUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txt_PrecUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrecUnit.ForeColor = System.Drawing.Color.White;
            this.txt_PrecUnit.Location = new System.Drawing.Point(619, 68);
            this.txt_PrecUnit.Name = "txt_PrecUnit";
            this.txt_PrecUnit.Size = new System.Drawing.Size(169, 24);
            this.txt_PrecUnit.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(424, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Precio Unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(464, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre:";
            // 
            // txt_Desc
            // 
            this.txt_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txt_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Desc.ForeColor = System.Drawing.Color.White;
            this.txt_Desc.Location = new System.Drawing.Point(619, 18);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(169, 24);
            this.txt_Desc.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.White;
            this.txt_Nombre.Location = new System.Drawing.Point(151, 67);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(168, 24);
            this.txt_Nombre.TabIndex = 5;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.ForeColor = System.Drawing.Color.White;
            this.txt_Codigo.Location = new System.Drawing.Point(151, 19);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(168, 24);
            this.txt_Codigo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "ACTUALIZAR PRODUCTO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DGVProd_Act
            // 
            this.DGVProd_Act.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.DGVProd_Act.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DGVProd_Act.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProd_Act.Location = new System.Drawing.Point(20, 405);
            this.DGVProd_Act.Name = "DGVProd_Act";
            this.DGVProd_Act.Size = new System.Drawing.Size(968, 258);
            this.DGVProd_Act.TabIndex = 29;
            this.DGVProd_Act.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLibro_CellClick);
            this.DGVProd_Act.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLibro_CellContentClick);
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
            this.btnActualizar.Location = new System.Drawing.Point(245, 329);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(204, 48);
            this.btnActualizar.TabIndex = 28;
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
            this.ButEliminar.Location = new System.Drawing.Point(541, 329);
            this.ButEliminar.Name = "ButEliminar";
            this.ButEliminar.Size = new System.Drawing.Size(204, 48);
            this.ButEliminar.TabIndex = 48;
            this.ButEliminar.Text = "ELIMINAR";
            this.ButEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButEliminar.UseVisualStyleBackColor = true;
            this.ButEliminar.Click += new System.EventHandler(this.ButEliminar_Click);
            // 
            // ProductoActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1049, 675);
            this.Controls.Add(this.ButEliminar);
            this.Controls.Add(this.DGVProd_Act);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductoActualizar";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProd_Act)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton Btn_search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PrecUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private System.Windows.Forms.DataGridView DGVProd_Act;
        private FontAwesome.Sharp.IconButton ButEliminar;
    }
}