using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUsuario.Modulos
{
    public static class MascaraDinheiro
    {
        public static void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim().Equals(string.Empty))
                txt.Text = "0";
            TirarMascara(sender, e);

            txt.Text = double.Parse(txt.Text).ToString("C2");
        }

        public static void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        public static void ApenasValoresNumericos(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                    e.Handled = txt.Text.Contains(',');
                else
                    e.Handled = true;
            }
        }

        public static void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValoresNumericos;
        }
    }
}
