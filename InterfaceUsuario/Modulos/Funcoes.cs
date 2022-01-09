using System;
using System.Windows.Forms;

namespace InterfaceUsuario.Modulos
{
    public static class Funcoes
    {
        public static void ListViewColor(ListView lvl)
        {
            foreach (ListViewItem item in lvl.Items)
            {
                if ((item.Index % 2) == 0)
                    item.BackColor = System.Drawing.Color.White;
                else
                    item.BackColor = System.Drawing.Color.LightBlue;
            }
        }

        public static void SelecionarCampo(TextBox textBox)
        {
            textBox.Focus();
            textBox.Select();
        }

        public static long? RemoverMascaraCampoNumerico(MaskedTextBox maskedTextBox)
        {
            maskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var str = RemoverEspacosVazios(maskedTextBox.Text);
            maskedTextBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            if (str.Equals(string.Empty))
                return null;
            else
                return Convert.ToInt64(str);
        }

        public static string RemoverEspacosVazios(string str)
        {
            return str.Trim().Replace(" ", "");
        }
    }
}
