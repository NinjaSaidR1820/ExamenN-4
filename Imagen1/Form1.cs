using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imagen1.Clases;
using Imagen1.Formularios;

namespace Imagen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ingresarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarDatos formulario = new AgregarDatos();

            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
