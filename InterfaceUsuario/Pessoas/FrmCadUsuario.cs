using Entidades.Enumeradores;
using InterfaceUsuario.Pesquisas;
using Negocio.Pessoas;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InterfaceUsuario.Pessoas
{
    public partial class FrmCadUsuario : Form
    {

        private bool IsNovo;
        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnBscUsuario_Click(object sender, EventArgs e)
        {
            var lista = new UsuarioNG().ListarEntidadesViewPesquisa(Status.Todos);
            //verifica se a lista está vazia
            if (lista.Count < 1)
            {
                MessageBox.Show("Sem da dos para serem exibidos!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            //passar a lista para o formulario generico de pesquisa
            var frmPesquisa = new FrmPesquisaGenerica("Listagem de Usuários", Status.Todos);
            frmPesquisa.lista = lista;
            frmPesquisa.ShowDialog();

            var iRetorno = frmPesquisa.iRetorno;
            //iRetorno = 0
            if (iRetorno < 1)
                return;

            txtCodigoUsuario.Text = iRetorno.ToString();
            txtCodigoUsuario_Validating(txtCodigoUsuario, new CancelEventArgs());
            btnBscUsuario.Focus();
        }

        private void btnBscTipoUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCodigoUsuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //verificar se esta vazio
            if (txtCodigoUsuario.Text.Trim().Equals(string.Empty))
                return;

            var oUsuario = new UsuarioNG().Buscar(Convert.ToInt32(txtCodigoTipoUsuario.Text.Trim()));
            if (oUsuario == null)
            {
                btnExcluir.Enabled = false;
                return;
            }

        }
    }
}
