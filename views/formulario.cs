using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_form_duna.views
{
		public partial class formulario : Form
		{
				public formulario()
				{
						InitializeComponent();
				}

				

				private void btnGuardar_Click(object sender, EventArgs e)
				{
						MessageBox.Show("hello");
				}

				private void btnCancelar_Click(object sender, EventArgs e)
				{
				//salir de formulario
					var rpt=	MessageBox.Show("Seguro que quiere salir?","", 
								MessageBoxButtons.YesNo,
								MessageBoxIcon.Question);
						if (rpt == DialogResult.Yes)
						{
								this.Close();
								var frm = new Form1();
								frm.Show();
						}
				}
		}
}