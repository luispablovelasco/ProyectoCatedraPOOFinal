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
    public partial class FrmVerRegistros : Form
    {
        string[] archivos;
        public FrmVerRegistros(int cantRegistros)
        {
            InitializeComponent();
            if(cantRegistros != 1)
            {
                scrollBar.Maximum = cantRegistros;
            }
            else
            {
                scrollBar.Visible = false;
            }
            string folder = Application.StartupPath + @"\Registros";
            archivos = Directory.GetFiles(folder, "*.txt");
            actualizar(archivos[0]);
        }

        private void actualizar(string ruta)
        {
            string[] lines = File.ReadAllLines(ruta);
            string tipoAnimal = lines[lines.Length - 1];
            lbCategoria.Text = tipoAnimal;
            lbNComun.Text = lines[0];
            lbNCientifico.Text = lines[1];
            lbClasificacion.Text = lines[2];
            lbDHabitat.Text = lines[3];
            pictureBox1.ImageLocation = lines[4];
            lbValorDato1.Text = lines[5];
            lbValorDato2.Text = lines[6];
            if (tipoAnimal == "reptil")
            {
                lbDato1.Text = "Tipo de respiración";
                lbDato2.Text = "Fosas temporales en el cráneo";
            }
            else if (tipoAnimal == "artropodo")
            {
                lbDato1.Text = "Cantidad de apéndices";
                lbDato2.Text = "Tipo de apéndices";
            }
            else if (tipoAnimal == "pez")
            {
                lbDato1.Text = "Cantidad de aletas";
                lbDato2.Text = "Tipo de branquias";
            }
            else if (tipoAnimal == "mamifero")
            {
                lbDato1.Text = "Cantidad de mamas";
                lbDato2.Text = "Color de pelo";
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void scrollBar_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            actualizar(archivos[scrollBar.Value - 1]);
        }
    }
}
