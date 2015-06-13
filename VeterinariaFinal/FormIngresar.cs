using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaEntidades;


namespace VeterinariaFinal
{
    public partial class FormIngresar : Form
    {
        public int cont = 0;
        public FormIngresar()
        {
            InitializeComponent();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string str1 = this.txtClave.Text;
            Veterinario v = new Veterinario();
            v.Password = str1;

            bool _isUsuario = new CapaLogica.UsuarioMNG().IsUsuario(v);

             if (_isUsuario )
            {
                FormMantencionVeterinarios menu = new FormMantencionVeterinarios();
                this.Hide();
                menu.Enabled = true;
                menu.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Clave Incorrecta");
                cont++;
            }

                if (cont == 3) {this.Close();}
            }

        }
}
