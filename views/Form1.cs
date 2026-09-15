<<<<<<< HEAD
﻿using practica_form_duna.models;
=======
﻿using practica_form_duna.views;
>>>>>>> 9a255c0 (make ui)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_form_duna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
=======
				private void Form1_Load(object sender, EventArgs e)
				{
            try
            {
                
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
				}

				private void btnAgregar_Click(object sender, EventArgs e)
				{
            var formulario = new formulario();
            this.Close();
            formulario.Show();
            
				}

			
		}
>>>>>>> 9a255c0 (make ui)
}
