using Entidades.Pessoas;
using InterfaceUsuario.Modulos;
using InterfaceUsuario.Pessoas;
using Negocio.Pessoas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUsuario.Produtos
{
    public partial class FrmRotPedidos : Form
    {
        public FrmRotPedidos()
        {
            InitializeComponent();
        }

        private void txtContato_Validating(object sender, CancelEventArgs e)
        {
            var valorCampo = Funcoes.RemoverMascaraCampoNumerico(txtContato);
            if (valorCampo == null)
                return;

            var oCliente = new ClienteNG().BuscarPorContato(Convert.ToInt64(valorCampo));

            if (oCliente == null)
            {
                FrmCadCliente oFrm = new FrmCadCliente();
                oFrm.WindowState = FormWindowState.Normal;
                oFrm.StartPosition = FormStartPosition.CenterScreen;
                oFrm.ShowDialog();
            }
            else
            {

            }
        }
    }
}
