namespace practica_form_duna.views
{
		partial class formulario
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
						this.btnCancelar = new System.Windows.Forms.Button();
						this.btnGuardar = new System.Windows.Forms.Button();
						this.txtNombre = new System.Windows.Forms.TextBox();
						this.txtTelefono = new System.Windows.Forms.TextBox();
						this.txtId = new System.Windows.Forms.TextBox();
						this.label1 = new System.Windows.Forms.Label();
						this.label2 = new System.Windows.Forms.Label();
						this.label3 = new System.Windows.Forms.Label();
						this.label4 = new System.Windows.Forms.Label();
						this.SuspendLayout();
						// 
						// btnCancelar
						// 
						this.btnCancelar.Location = new System.Drawing.Point(57, 410);
						this.btnCancelar.Name = "btnCancelar";
						this.btnCancelar.Size = new System.Drawing.Size(103, 43);
						this.btnCancelar.TabIndex = 0;
						this.btnCancelar.Text = "Cancelar";
						this.btnCancelar.UseVisualStyleBackColor = true;
						// 
						// btnGuardar
						// 
						this.btnGuardar.Location = new System.Drawing.Point(226, 410);
						this.btnGuardar.Name = "btnGuardar";
						this.btnGuardar.Size = new System.Drawing.Size(103, 43);
						this.btnGuardar.TabIndex = 1;
						this.btnGuardar.Text = "Guardar";
						this.btnGuardar.UseVisualStyleBackColor = true;
						// 
						// txtNombre
						// 
						this.txtNombre.Location = new System.Drawing.Point(147, 205);
						this.txtNombre.Name = "txtNombre";
						this.txtNombre.Size = new System.Drawing.Size(175, 23);
						this.txtNombre.TabIndex = 2;
						// 
						// txtTelefono
						// 
						this.txtTelefono.Location = new System.Drawing.Point(154, 251);
						this.txtTelefono.Name = "txtTelefono";
						this.txtTelefono.Size = new System.Drawing.Size(175, 23);
						this.txtTelefono.TabIndex = 3;
						// 
						// txtId
						// 
						this.txtId.Location = new System.Drawing.Point(147, 167);
						this.txtId.Name = "txtId";
						this.txtId.ReadOnly = true;
						this.txtId.Size = new System.Drawing.Size(75, 23);
						this.txtId.TabIndex = 4;
						// 
						// label1
						// 
						this.label1.AutoSize = true;
						this.label1.Location = new System.Drawing.Point(54, 175);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(39, 15);
						this.label1.TabIndex = 5;
						this.label1.Text = "ID :";
						// 
						// label2
						// 
						this.label2.AutoSize = true;
						this.label2.Location = new System.Drawing.Point(54, 213);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(71, 15);
						this.label2.TabIndex = 6;
						this.label2.Text = "Nombre :";
						// 
						// label3
						// 
						this.label3.AutoSize = true;
						this.label3.Location = new System.Drawing.Point(54, 259);
						this.label3.Name = "label3";
						this.label3.Size = new System.Drawing.Size(87, 15);
						this.label3.TabIndex = 7;
						this.label3.Text = "Telefono :";
						// 
						// label4
						// 
						this.label4.AutoSize = true;
						this.label4.Location = new System.Drawing.Point(144, 97);
						this.label4.Name = "label4";
						this.label4.Size = new System.Drawing.Size(55, 15);
						this.label4.TabIndex = 8;
						this.label4.Text = "Titulo";
						// 
						// formulario
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(385, 483);
						this.ControlBox = false;
						this.Controls.Add(this.label4);
						this.Controls.Add(this.label3);
						this.Controls.Add(this.label2);
						this.Controls.Add(this.label1);
						this.Controls.Add(this.txtId);
						this.Controls.Add(this.txtTelefono);
						this.Controls.Add(this.txtNombre);
						this.Controls.Add(this.btnGuardar);
						this.Controls.Add(this.btnCancelar);
						this.Font = new System.Drawing.Font("CaskaydiaCove NF SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						this.KeyPreview = true;
						this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
						this.Name = "formulario";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
						this.Text = "formulario";
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.Button btnCancelar;
				private System.Windows.Forms.Button btnGuardar;
				private System.Windows.Forms.TextBox txtNombre;
				private System.Windows.Forms.TextBox txtTelefono;
				private System.Windows.Forms.TextBox txtId;
				private System.Windows.Forms.Label label1;
				private System.Windows.Forms.Label label2;
				private System.Windows.Forms.Label label3;
				private System.Windows.Forms.Label label4;
		}
}