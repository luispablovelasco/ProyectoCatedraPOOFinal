using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoDeCatedraPOOFinal
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
            guardarFoto(fotoAnimal, "imagen");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Aviso de cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Enabled = true;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (MessageBox.Show("¿Desea dejar el registro?", "Regreso al menú", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                FrmMenuIngreso frm = new FrmMenuIngreso();
                frm.Show();
                this.Hide();
            }
            else
            {
                this.Enabled = true;
            }
        }

        public string guardarFoto(PictureBox imagen, string txt)
        {
            string folder = Application.StartupPath + @"\Images";
            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            try
            {
                string rutaFoto = Path.Combine(folder, txt + ".png");
                imagen.Image.Save(rutaFoto, System.Drawing.Imaging.ImageFormat.Png);
                return rutaFoto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            open.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|Archivos PNG (*.png)|*.png";
            open.Title = "Añadir foto al animal...";
            if (open.ShowDialog() == DialogResult.OK)
            {
                fotoAnimal.ImageLocation = open.FileName;
                txtRutaFoto.Text = open.FileName;
            }
        }
    }
}
