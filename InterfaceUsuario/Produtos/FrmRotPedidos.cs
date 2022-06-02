using Entidades.Enumeradores;
using Entidades.Pessoas;
using InterfaceUsuario.Modulos;
using InterfaceUsuario.Pesquisas;
using InterfaceUsuario.Pessoas;
using Negocio.Pessoas;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace InterfaceUsuario.Produtos
{
    public partial class FrmRotPedidos : Form
    {
        public FrmRotPedidos()
        {
            InitializeComponent();

            MascaraCampoCodigo.AplicarEventos(txtCodigoCliente);
            MascaraDinheiro.AplicarEventos(txtValorTeleentrega);
        }

        private void txtContato_Validating(object sender, CancelEventArgs e)
        {
            var valorCampo = Funcoes.RemoverMascaraCampoNumerico(txtContato);
            if (valorCampo == null)
                return;

            var oCliente = new ClienteNG().BuscarPorContato(Convert.ToInt64(valorCampo));

            if (oCliente == null)
            {
                if (MessageBox.Show("Cliente não encontrado, deseja realizar o cadastro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmCadCliente oFrm = new FrmCadCliente();
                    oFrm.WindowState = FormWindowState.Normal;
                    oFrm.StartPosition = FormStartPosition.CenterScreen;
                    oFrm.ShowDialog();
                }
            }
            else
            {
                txtCodigoCliente.Text = oCliente.Codigo.ToString();
                MascaraCampoCodigo.RetornarMascara(txtCodigoCliente, new EventArgs());

                lblMstNomeCliente.Text = oCliente.Nome;

                Endereco oEndereco = (from end in oCliente.Enderecos where end.IsEnderecoPadrao select end).First();

                if (oEndereco == null)
                    return;

                gpbEndereco.Enabled = true;

                //Preencher campos do endereço de entrega
                lblCodEnderecoEntrega.Text = oEndereco.Codigo.ToString();
                lblMstRua.Text = oEndereco.Rua;
                lblMstNumero.Text = oEndereco.Numero.ToString();
                lblMstComplemento.Text = oEndereco.Complemento;
                lblMstBairro.Text = oEndereco.Bairro;
                lblMstCidade.Text = oEndereco.Cidade;

                btnEditarCliente.Enabled = true;
            }
        }

        private void btnBscCliente_Click(object sender, EventArgs e)
        {
            var oFrm = new FrmPesquisaGenericaCliente(Status.Ativo);
            oFrm.gpbStatus.Enabled = false;
            oFrm.ShowDialog();
            var iRetorno = oFrm.iRetorno;

            if (iRetorno < 1)
                return;

            txtCodigoCliente.Text = iRetorno.ToString();
            txtCodigoCliente_Validating(txtCodigoCliente, new CancelEventArgs());

            MascaraCampoCodigo.RetornarMascara(txtCodigoCliente, new EventArgs());
            btnBscCliente.Focus();
        }

        private void txtCodigoCliente_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigoCliente.Text.Trim().Equals(string.Empty))
                return;

            var oCliente = new ClienteNG().Buscar(Convert.ToInt32(txtCodigoCliente.Text.Trim()));

            if (oCliente == null)
                return;

            lblMstNomeCliente.Text = oCliente.Nome;

            if (!oCliente.Telefone.Equals(string.Empty))
                txtContato.Text = oCliente.Telefone.ToString();
            else
                txtContato.Text = oCliente.Celular.ToString();

            Endereco oEndereco = (from end in oCliente.Enderecos where end.IsEnderecoPadrao select end).First();

            if (oEndereco == null)
                return;

            gpbEndereco.Enabled = true;

            //Preencher campos do endereço de entrega
            lblCodEnderecoEntrega.Text = oEndereco.Codigo.ToString();
            lblMstRua.Text = oEndereco.Rua;
            lblMstNumero.Text = oEndereco.Numero.ToString();
            lblMstComplemento.Text = oEndereco.Complemento;
            lblMstBairro.Text = oEndereco.Bairro;
            lblMstCidade.Text = oEndereco.Cidade;

            btnEditarCliente.Enabled = true;
        }

        private void LimparCampos()
        {
            txtContato.Text = string.Empty;
            txtCodigoCliente.Text = string.Empty;

            lblCodEnderecoEntrega.Visible = false; ;
            lblMstRua.Text = string.Empty;
            lblMstNumero.Text = string.Empty;
            lblMstComplemento.Text = string.Empty;
            lblMstBairro.Text = string.Empty;
            lblMstCidade.Text = string.Empty;

            gpbEndereco.Enabled = false;
            btnEditarCliente.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void FrmRotPedidos_Load(object sender, EventArgs e)
        {
            btnCancelar_Click(btnCancelar, new EventArgs());
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text.Trim().Equals(String.Empty))
                return;

            FrmCadCliente oFrm = new FrmCadCliente();
            oFrm.WindowState = FormWindowState.Normal;
            oFrm.StartPosition = FormStartPosition.CenterScreen;


        }
    }
}
