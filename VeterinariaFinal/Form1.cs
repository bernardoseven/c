using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VeterinariaFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está Seguro que desea salir de la Aplicación?",
                                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ingresoCtrlIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngresar ingre = new FormIngresar();
            this.Hide();
            ingre.Enabled = true;
            ingre.ShowDialog();
            this.Close();
        }
    }
}
