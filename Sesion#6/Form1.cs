using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            agregar(); 
        }
        public void agregar ()
        {
            string nombre = tbnombre.Text.Trim();
           if (string.IsNullOrEmpty(nombre) )
            {
                MessageBox.Show("No puede quedar vacio el nombre");
                tbnombre.Focus();
                return;
            }
            cmbNombres.Items.Add(nombre);
            tbnombre.Text = "";
            tbnombre.Focus();
        }

        private void btnMover_Click



    }
}
