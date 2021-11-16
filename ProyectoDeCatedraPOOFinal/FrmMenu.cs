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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            FrmMenuIngreso frm = new FrmMenuIngreso();
            frm.Show();
            this.Hide();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string folder = Application.StartupPath + @"\Registros";
            if (Directory.Exists(folder))
            {
                string[] archivos = Directory.GetFiles(folder, "*.txt");
                int cantArchivos = archivos.Length;

                if (cantArchivos > 0)
                {
                    if(cantArchivos == 1)
                    {
                        MessageBox.Show("Existe solamente un archivo");
                    }
                    else
                    {
                        MessageBox.Show("Existen " + cantArchivos + " archivos");
                    }
                    FrmVerRegistros frm = new FrmVerRegistros(cantArchivos);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No hay animales ingresados aún");
                }
            }
            else
            {
                MessageBox.Show("No hay animales ingresados aún");
            }
        }
    }
}
