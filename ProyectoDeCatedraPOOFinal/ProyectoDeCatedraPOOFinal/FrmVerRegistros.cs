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
    public partial class FrmVerRegistros : Form
    {
        public FrmVerRegistros()
        {
            InitializeComponent();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }
    }
}
