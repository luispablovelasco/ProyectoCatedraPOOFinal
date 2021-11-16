using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoDeCatedraPOOFinal
{
    public partial class FrmMamifero : ProyectoDeCatedraPOOFinal.FrmIngreso
    {
        public FrmMamifero()
        {
            InitializeComponent();
        }

        private void txtCantMamas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxtBox validacion = new ValidarTxtBox();
            validacion.validar(e, errorProvider1, txtCantMamas);
        }

        private void limpiar()
        {
            txtNomComun.Clear();
            txtNomCientifico.Clear();
            cbClasificacion.SelectedIndex = -1;
            cbHabitat.SelectedIndex = -1;
            txtCantMamas.Clear();
            txtColorPelo.Clear();
            fotoAnimal.ImageLocation = Application.StartupPath + @"\Images\imagen.png";
            txtRutaFoto.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmIngreso frm = new FrmIngreso();
            try
            {
                Mamiferos mamifero = new Mamiferos()
                {
                    NomComun = txtNomComun.Text,
                    NomCientifico = txtNomCientifico.Text,
                    Clasificacion = cbClasificacion.Text,
                    Habitat = cbHabitat.Text,
                    RutaFoto = frm.guardarFoto(fotoAnimal, txtNomComun.Text),
                    CantMamas = int.Parse(txtCantMamas.Text),
                    ColorPelo = txtColorPelo.Text
                };
                mamifero.guardarDatos(mamifero.guardar(Application.StartupPath));
                MessageBox.Show("Registro ingresado con éxito");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
