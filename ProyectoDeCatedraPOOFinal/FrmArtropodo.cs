using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoDeCatedraPOOFinal
{
    public partial class FrmArtropodo : ProyectoDeCatedraPOOFinal.FrmIngreso
    {
        public FrmArtropodo()
        {
            InitializeComponent();
        }

        private void txtCantApendices_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTxtBox validacion = new ValidarTxtBox();
            validacion.validar(e, errorProvider1, txtCantApendices);
        }
        private void limpiar()
        {
            txtNomComun.Clear();
            txtNomCientifico.Clear();
            cbClasificacion.SelectedIndex = -1;
            cbHabitat.SelectedIndex = -1;
            txtCantApendices.Clear();
            cbTipoApendices.SelectedIndex = -1;
            fotoAnimal.ImageLocation = Application.StartupPath + @"\Images\imagen.png";
            txtRutaFoto.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmIngreso frm = new FrmIngreso();
            try
            {
                Artropodos artropodo = new Artropodos()
                {
                    NomComun = txtNomComun.Text,
                    NomCientifico = txtNomCientifico.Text,
                    Clasificacion = cbClasificacion.Text,
                    Habitat = cbHabitat.Text,
                    RutaFoto = frm.guardarFoto(fotoAnimal, txtNomComun.Text),
                    CantApendices = int.Parse(txtCantApendices.Text),
                    TiposApendices = cbTipoApendices.Text
                };
                artropodo.guardarDatos(artropodo.guardar(Application.StartupPath));
                MessageBox.Show("Registro ingresado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
