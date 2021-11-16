using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoDeCatedraPOOFinal
{
    public partial class FrmReptil : ProyectoDeCatedraPOOFinal.FrmIngreso
    {
        public FrmReptil()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtNomComun.Clear();
            txtNomCientifico.Clear();
            cbClasificacion.SelectedIndex = -1;
            cbHabitat.SelectedIndex = -1;
            cbFosasCraneales.SelectedIndex = -1;
            cbTipoResp.SelectedIndex = -1;
            fotoAnimal.ImageLocation = Application.StartupPath + @"\Images\imagen.png";
            txtRutaFoto.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmIngreso frm = new FrmIngreso();
            try
            {
                Reptiles reptil = new Reptiles()
                {
                    NomComun = txtNomComun.Text,
                    NomCientifico = txtNomCientifico.Text,
                    Clasificacion = cbClasificacion.Text,
                    Habitat = cbHabitat.Text,
                    RutaFoto = frm.guardarFoto(fotoAnimal, txtNomComun.Text),
                    TipoResp = cbTipoResp.Text,
                    CantFosas = cbFosasCraneales.Text
                };
                reptil.guardarDatos(reptil.guardar(Application.StartupPath));
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
