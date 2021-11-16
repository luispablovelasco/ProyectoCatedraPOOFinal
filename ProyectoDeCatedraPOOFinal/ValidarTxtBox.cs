using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.UI.WinForms;
using System.Windows.Forms;

namespace ProyectoDeCatedraPOOFinal
{
    class ValidarTxtBox
    {
        public void validar(KeyPressEventArgs e, ErrorProvider error, BunifuTextBox txt)
        {
            error.Clear();
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                error.SetError(txt, "Solo números");
            }
        }
    }
}
