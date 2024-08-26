using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miapp1.Clases_;


namespace Miapp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dtFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            Persona.Nombre  = tbnombre.Text;
            persona.FechaNac = dtpFechaNac.value;
            Massagebox.show(persona.EvaluarEdad());

        }
    }
}
