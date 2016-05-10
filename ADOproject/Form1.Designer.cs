namespace ADOproject
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.datagridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_fName = new System.Windows.Forms.TextBox();
            this.textBox_lName = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_nombre = new System.Windows.Forms.Label();
            this.textBox_apellidos = new System.Windows.Forms.Label();
            this.textBox_telefono = new System.Windows.Forms.Label();
            this.button_cargarListado = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_IdPhoneBook = new System.Windows.Forms.TextBox();
            this.textBox_InternalId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_indice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_filas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridView1
            // 
            this.datagridView1.AllowDrop = true;
            this.datagridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridView1.Location = new System.Drawing.Point(27, 33);
            this.datagridView1.Name = "datagridView1";
            this.datagridView1.Size = new System.Drawing.Size(642, 300);
            this.datagridView1.TabIndex = 0;
            // 
            // textBox_fName
            // 
            this.textBox_fName.Location = new System.Drawing.Point(105, 386);
            this.textBox_fName.Name = "textBox_fName";
            this.textBox_fName.Size = new System.Drawing.Size(294, 20);
            this.textBox_fName.TabIndex = 4;
            // 
            // textBox_lName
            // 
            this.textBox_lName.Location = new System.Drawing.Point(105, 417);
            this.textBox_lName.Name = "textBox_lName";
            this.textBox_lName.Size = new System.Drawing.Size(294, 20);
            this.textBox_lName.TabIndex = 5;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(105, 444);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(294, 20);
            this.textBox_phone.TabIndex = 6;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.AutoSize = true;
            this.textBox_nombre.Location = new System.Drawing.Point(24, 386);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(38, 13);
            this.textBox_nombre.TabIndex = 7;
            this.textBox_nombre.Text = "fName";
            // 
            // textBox_apellidos
            // 
            this.textBox_apellidos.AutoSize = true;
            this.textBox_apellidos.Location = new System.Drawing.Point(24, 417);
            this.textBox_apellidos.Name = "textBox_apellidos";
            this.textBox_apellidos.Size = new System.Drawing.Size(37, 13);
            this.textBox_apellidos.TabIndex = 8;
            this.textBox_apellidos.Text = "lName";
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.AutoSize = true;
            this.textBox_telefono.Location = new System.Drawing.Point(24, 444);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(64, 13);
            this.textBox_telefono.TabIndex = 9;
            this.textBox_telefono.Text = "Nº Teléfono";
            // 
            // button_cargarListado
            // 
            this.button_cargarListado.Location = new System.Drawing.Point(696, 33);
            this.button_cargarListado.Name = "button_cargarListado";
            this.button_cargarListado.Size = new System.Drawing.Size(137, 69);
            this.button_cargarListado.TabIndex = 10;
            this.button_cargarListado.Text = "Cargar Listado Telefónico";
            this.button_cargarListado.UseVisualStyleBackColor = true;
            this.button_cargarListado.Click += new System.EventHandler(this.button_cargarListado_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(696, 139);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 23);
            this.button_insert.TabIndex = 11;
            this.button_insert.Text = "Añadir";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(696, 169);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Borrar";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(696, 199);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 13;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_IdPhoneBook
            // 
            this.textBox_IdPhoneBook.Location = new System.Drawing.Point(105, 470);
            this.textBox_IdPhoneBook.Name = "textBox_IdPhoneBook";
            this.textBox_IdPhoneBook.Size = new System.Drawing.Size(193, 20);
            this.textBox_IdPhoneBook.TabIndex = 14;
            // 
            // textBox_InternalId
            // 
            this.textBox_InternalId.Location = new System.Drawing.Point(105, 496);
            this.textBox_InternalId.Name = "textBox_InternalId";
            this.textBox_InternalId.Size = new System.Drawing.Size(193, 20);
            this.textBox_InternalId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "IdPhoneBook";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "InternalId";
            // 
            // textBox_indice
            // 
            this.textBox_indice.Location = new System.Drawing.Point(45, 560);
            this.textBox_indice.Name = "textBox_indice";
            this.textBox_indice.Size = new System.Drawing.Size(100, 20);
            this.textBox_indice.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Indice de la fila seleccionada";
            // 
            // textBox_filas
            // 
            this.textBox_filas.Location = new System.Drawing.Point(210, 560);
            this.textBox_filas.Name = "textBox_filas";
            this.textBox_filas.Size = new System.Drawing.Size(100, 20);
            this.textBox_filas.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nº Filas llenas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 673);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_filas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_indice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_InternalId);
            this.Controls.Add(this.textBox_IdPhoneBook);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_cargarListado);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.textBox_apellidos);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_lName);
            this.Controls.Add(this.textBox_fName);
            this.Controls.Add(this.datagridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.datagridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridView1;
        private System.Windows.Forms.TextBox textBox_fName;
        private System.Windows.Forms.TextBox textBox_lName;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label textBox_nombre;
        private System.Windows.Forms.Label textBox_apellidos;
        private System.Windows.Forms.Label textBox_telefono;
        private System.Windows.Forms.Button button_cargarListado;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_IdPhoneBook;
        private System.Windows.Forms.TextBox textBox_InternalId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_indice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_filas;
        private System.Windows.Forms.Label label4;
    }
}

