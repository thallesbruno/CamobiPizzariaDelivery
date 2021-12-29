using System;
using System.Windows.Forms;

namespace InterfaceUsuario.Modulos
{
    public static class MascaraCampoNumero
    {
        public static void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim().Equals(string.Empty))
                return;
            txt.Text = Int32.Parse(txt.Text).ToString();
        }

        public static void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim().Equals(string.Empty))
                return;
            txt.Text = Convert.ToInt32(txt.Text.Trim()).ToString();
            txt.Focus();
            txt.Select(0, txt.Text.Length);
        }

        public static void ApenasValoresNumericos(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                e.Handled = true;
        }

        public static void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValoresNumericos;
        }
    }
}
