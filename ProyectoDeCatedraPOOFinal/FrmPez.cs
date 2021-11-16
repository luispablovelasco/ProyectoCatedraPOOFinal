using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoDeCatedraPOOFinal
{
    public partial class FrmPez : ProyectoDeCatedraPOOFinal.FrmIngreso
    {
        public FrmPez()
        {
            InitializeComponent();
        }

        private void txtCantAletas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxtBox validacion = new ValidarTxtBox();
            validacion.validar(e, errorProvider1, txtCantAletas);
        }
        private void limpiar()
        {
            txtNomComun.Clear();
            txtNomCientifico.Clear();
            cbClasificacion.SelectedIndex = -1;
            cbHabitat.SelectedIndex = -1;
            txtCantAletas.Clear();
            cbTipoBranquias.SelectedIndex = -1;
            fotoAnimal.ImageLocation = Application.StartupPath + @"\Images\imagen.png";
            txtRutaFoto.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmIngreso frm = new FrmIngreso();
            try
            {
                Peces pez = new Peces()
                {
                    NomComun = txtNomComun.Text,
                    NomCientifico = txtNomCientifico.Text,
                    Clasificacion = cbClasificacion.Text,
                    Habitat = cbHabitat.Text,
                    RutaFoto = frm.guardarFoto(fotoAnimal, txtNomComun.Text),
                    CantAletas = int.Parse(txtCantAletas.Text),
                    TipoBranquias = cbTipoBranquias.Text
                };
                pez.guardarDatos(pez.guardar(Application.StartupPath));
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
