using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;

namespace VeterinariaFinal
{
    public partial class FormMantencionVeterinarios : Form
    {
        public FormMantencionVeterinarios()
        {
            InitializeComponent();
        }

        

        private void CargaDatos(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Rut = this.txtRut.Text;
            u.Nombre = this.txtNombre.Text;
            u.ApPaterno = this.txtAP.Text;
            u.ApMaterno = this.txtAM.Text;
            u.Celular = Convert.ToInt32(this.txtMovil.Text);
            u.Fijo = Convert.ToInt32(this.txtFono.Text);
            u.Especialidad = this.cboEsp.Text;
            u.Email = this.txtMail.Text;
            u.FechaIngreso = this.dateTimePicker1.Value;

            //falta recibir la foto.
            UsuarioMNG umg = new UsuarioMNG();
            umg.IsVeterianrio(u);
            //Preguntar si se ingresaron los datos.



        }

        private void FormMantencionVeterinarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'nataliaDataSet.VETERINARIO' Puede moverla o quitarla según sea necesario.
            this.vETERINARIOTableAdapter.Fill(this.nataliaDataSet.VETERINARIO);

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            //// aqui buscamos una ruta atrabes del boton para traer un archivo y una imagen
            //if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            //{

            //    this.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            //}

            //this.openFileDialog1.ShowDialog();
        }
    }
}
