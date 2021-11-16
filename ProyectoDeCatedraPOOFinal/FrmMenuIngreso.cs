using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDeCatedraPOOFinal
{
    public partial class FrmMenuIngreso: Form
    {
        public FrmMenuIngreso()
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

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }

        private void btnMamiferos_Click(object sender, EventArgs e)
        {
            FrmMamifero frm = new FrmMamifero();
            frm.Show();
            this.Hide();
        }

        private void btnReptiles_Click(object sender, EventArgs e)
        {
            FrmReptil frm = new FrmReptil();
            frm.Show();
            this.Hide();
        }

        private void btnPeces_Click(object sender, EventArgs e)
        {
            FrmPez frm = new FrmPez();
            frm.Show();
            this.Hide();
        }

        private void btnArtropodos_Click(object sender, EventArgs e)
        {
            FrmArtropodo frm = new FrmArtropodo();
            frm.Show();
            this.Hide();
        }
    }
}
