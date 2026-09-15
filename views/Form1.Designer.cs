namespace practica_form_duna
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(815, 474);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(839, 133);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 60);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(839, 243);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(127, 60);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(839, 340);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(127, 60);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(16, 83);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(310, 26);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(333, 79);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 33);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 623);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
=======
						this.dgvDatos = new System.Windows.Forms.DataGridView();
						this.btnAgregar = new System.Windows.Forms.Button();
						this.btnEditar = new System.Windows.Forms.Button();
						this.btnEliminar = new System.Windows.Forms.Button();
						this.txtBuscar = new System.Windows.Forms.TextBox();
						this.btnBuscar = new System.Windows.Forms.Button();
						((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
						this.SuspendLayout();
						// 
						// dgvDatos
						// 
						this.dgvDatos.AllowUserToAddRows = false;
						this.dgvDatos.AllowUserToDeleteRows = false;
						this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
						this.dgvDatos.Location = new System.Drawing.Point(16, 133);
						this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
						this.dgvDatos.Name = "dgvDatos";
						this.dgvDatos.ReadOnly = true;
						this.dgvDatos.Size = new System.Drawing.Size(815, 474);
						this.dgvDatos.TabIndex = 0;
						// 
						// btnAgregar
						// 
						this.btnAgregar.Location = new System.Drawing.Point(839, 133);
						this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
						this.btnAgregar.Name = "btnAgregar";
						this.btnAgregar.Size = new System.Drawing.Size(127, 60);
						this.btnAgregar.TabIndex = 1;
						this.btnAgregar.Text = "Agregar";
						this.btnAgregar.UseVisualStyleBackColor = true;
						this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
						// 
						// btnEditar
						// 
						this.btnEditar.Location = new System.Drawing.Point(839, 243);
						this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
						this.btnEditar.Name = "btnEditar";
						this.btnEditar.Size = new System.Drawing.Size(127, 60);
						this.btnEditar.TabIndex = 2;
						this.btnEditar.Text = "Editar";
						this.btnEditar.UseVisualStyleBackColor = true;
						// 
						// btnEliminar
						// 
						this.btnEliminar.Location = new System.Drawing.Point(839, 340);
						this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
						this.btnEliminar.Name = "btnEliminar";
						this.btnEliminar.Size = new System.Drawing.Size(127, 60);
						this.btnEliminar.TabIndex = 3;
						this.btnEliminar.Text = "Eliminar";
						this.btnEliminar.UseVisualStyleBackColor = true;
						// 
						// txtBuscar
						// 
						this.txtBuscar.Location = new System.Drawing.Point(16, 83);
						this.txtBuscar.Name = "txtBuscar";
						this.txtBuscar.Size = new System.Drawing.Size(310, 25);
						this.txtBuscar.TabIndex = 4;
						this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
						// 
						// btnBuscar
						// 
						this.btnBuscar.Location = new System.Drawing.Point(333, 79);
						this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
						this.btnBuscar.Name = "btnBuscar";
						this.btnBuscar.Size = new System.Drawing.Size(127, 33);
						this.btnBuscar.TabIndex = 5;
						this.btnBuscar.Text = "Buscar";
						this.btnBuscar.UseVisualStyleBackColor = true;
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(1012, 623);
						this.Controls.Add(this.btnBuscar);
						this.Controls.Add(this.txtBuscar);
						this.Controls.Add(this.btnEliminar);
						this.Controls.Add(this.btnEditar);
						this.Controls.Add(this.btnAgregar);
						this.Controls.Add(this.dgvDatos);
						this.Font = new System.Drawing.Font("Noto Sans Lisu", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.Margin = new System.Windows.Forms.Padding(4);
						this.Name = "Form1";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
						this.Text = "Form1";
						this.Load += new System.EventHandler(this.Form1_Load);
						((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
						this.ResumeLayout(false);
						this.PerformLayout();
>>>>>>> 9a255c0 (make ui)

        }

				#endregion

				private System.Windows.Forms.DataGridView dgvDatos;
				private System.Windows.Forms.Button btnAgregar;
				private System.Windows.Forms.Button btnEditar;
				private System.Windows.Forms.Button btnEliminar;
				private System.Windows.Forms.TextBox txtBuscar;
				private System.Windows.Forms.Button btnBuscar;
		}
}

