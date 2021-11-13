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
            FrmVerRegistros frm = new FrmVerRegistros();
            frm.Show();
            this.Hide();
        }
    }
}
