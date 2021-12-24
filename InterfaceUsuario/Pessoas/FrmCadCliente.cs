using Entidades.Enumeradores;
using InterfaceUsuario.Modulos;
using InterfaceUsuario.Pesquisas;
using Negocio.Pessoas;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InterfaceUsuario.Pessoas
{
    public partial class FrmCadCliente : Form
    {
        public bool isNovo;
        public bool isSucesso;
        private int iCodEdicao;

        public FrmCadCliente()
        {
            InitializeComponent();
            MascaraCampoCodigo.AplicarEventos(txtCodigo);
        }

        public void InicializarEdicao(int iCodEdit)
        {
            isSucesso = false;
             iCodEdicao= iCodEdit;
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            //Preparacao da lista
            PrepararLista();

            //btnCancelar ==> LimparCampos
            btnCancelar_Click(btnCancelar, new EventArgs());

            //Verificar codigo de edicao
            if (iCodEdicao > 0)
            {
                txtCodigo.Enabled = false;
                btnBscCliente.Enabled = false;
                btnCancelar.Enabled = false;
                txtCodigo.Text = iCodEdicao.ToString();
                txtCodigo_Validating(txtCodigo, new CancelEventArgs());
            }
        }

        private void PrepararLista()
        {
            lvlListagemEnderecos.Clear();
            lvlListagemEnderecos.View = View.Details;
            lvlListagemEnderecos.Columns.Add("Padrão", 50, HorizontalAlignment.Right);
            lvlListagemEnderecos.Columns.Add("Rua", 180, HorizontalAlignment.Left);
            lvlListagemEnderecos.Columns.Add("Número", 50, HorizontalAlignment.Right);
            lvlListagemEnderecos.Columns.Add("Complemento", 160, HorizontalAlignment.Left);
            lvlListagemEnderecos.Columns.Add("Bairro", 80, HorizontalAlignment.Left);
            lvlListagemEnderecos.Columns.Add("Cidade", 80, HorizontalAlignment.Left);
        }

        //##### Botoes #####
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoverEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnBscCliente_Click(object sender, EventArgs e)
        {
            var frmPesquisa = new FrmPesquisaGenericaCliente(Status.Todos);
            frmPesquisa.gpbStatus.Enabled = true;
            frmPesquisa.ShowDialog();
            var iRetorno = frmPesquisa.iRetorno;
            if (iRetorno < 1)
                return;
            txtCodigo.Text = iRetorno.ToString();
            txtCodigo_Validating(txtCodigo, new CancelEventArgs());
            btnBscCliente.Focus();
        }

        //##### Fim Botoes #####

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigo.Text.Trim().Equals(string.Empty))
                    return;
            //Buscar Cliente no BD
            var oCliente = new ClienteNG().Buscar(Convert.ToInt32(txtCodigo.Text.Trim()));
            if (oCliente == null)
            {
                if (iCodEdicao > 0)
                {
                    MessageBox.Show("Não foi possível alterar este registro. Tente novamente!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                btnExcluir.Enabled = false;
                return;
            }
            isNovo = false;
            txtNome.Text = oCliente.Nome;
            txtTelefone.Text = oCliente.Telefone.ToString();
            txtCelular.Text = oCliente.Celular.ToString();

            LimparCamposEndereco();
            foreach (var item in oCliente.Enderecos)
            {
                PreencherListaEnderecos();
            }
        }

        private void PreencherListaEnderecos()
        {
            
        }

        private void LimparCamposEndereco()
        {
            txtRua.Text = String.Empty;
            txtNumero.Text = String.Empty;
            txtComplemento.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtCidade.Text = String.Empty;
            chkEnderecoPadrao.Checked = false;
        }
    }
}
