using Entidades.Enumeradores;
using Entidades.Pessoas;
using InterfaceUsuario.Modulos;
using InterfaceUsuario.Pesquisas;
using InterfaceUsuario.Pessoas;
using Negocio.Pessoas;
using Negocio.Produtos;
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

        private void FrmRotPedidos_Load(object sender, EventArgs e)
        {
            btnCancelar_Click(btnCancelar, new EventArgs());
            PrepararListas();
        }

        #region Eventos Click
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnAlterarEndereco_Click(object sender, EventArgs e)
        {
            var ngEnderecoCliente = new EnderecoClienteNG();
            var lista = ngEnderecoCliente.ListarEntidadesViewPesquisa(Convert.ToInt32(txtCodigoCliente.Text.Trim()));

            if (lista.Count < 1)
            {
                MessageBox.Show("Este cliente não possui endereços!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var frmPesquisa = new FrmPesquisaGenerica("Listagem de Endereços do Cliente", Status.Ativo);
            frmPesquisa.gpbStatus.Enabled = false;
            frmPesquisa.lista = lista;
            frmPesquisa.ShowDialog();

            var iRetorno = frmPesquisa.iRetorno;

            if (iRetorno < 1)
                return;

            var oEndereco = new EnderecoClienteNG().BuscarEndereco(iRetorno);

            if (oEndereco == null)
                return;

            PreencherCamposEnderecoEntrega(oEndereco);

            btnAlterarEndereco.Focus();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            var oFrm = new FrmCadCliente();
            oFrm.WindowState = FormWindowState.Normal;
            oFrm.StartPosition = FormStartPosition.CenterScreen;
            oFrm.ShowDialog();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text.Trim().Equals(String.Empty))
                return;

            FrmCadCliente oFrm = new FrmCadCliente();
            oFrm.WindowState = FormWindowState.Normal;
            oFrm.StartPosition = FormStartPosition.CenterScreen;

            oFrm.InicializarEdicao(Convert.ToInt32(txtCodigoCliente.Text.Trim()));
            oFrm.ShowDialog();

            if (oFrm.isSucesso)
                txtCodigoCliente_Validating(txtCodigoCliente, new CancelEventArgs());
        }

        private void btnDelAdicional_Click(object sender, EventArgs e)
        {
            if (lvlListagemPedidosAdicionais.SelectedIndices.Count < 1)
                return;

            var iSelectedIndex = Convert.ToInt32(lvlListagemPedidosAdicionais.SelectedIndices[0]);

            if (iSelectedIndex >= 0)
                lvlListagemPedidosAdicionais.Items[iSelectedIndex].Remove();
        }

        private void btnAddAdicional_Click(object sender, EventArgs e)
        {
            var ngAdicional = new AdicionalNG();
            var lista = ngAdicional.ListarEntidadesViewPesquisa(Status.Ativo);

            if(lista.Count < 1)
            {
                MessageBox.Show("Nenhum adicional encontrado!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            var oFrm = new FrmPesquisaGenerica("Listagem de Adicionais", Status.Ativo);
            oFrm.gpbStatus.Enabled = false;
            oFrm.lista = lista;
            oFrm.ShowDialog();
            var iRetorno = oFrm.iRetorno;
            if (iRetorno < 1)
                return;
            PreencherListaAdicionais(iRetorno);
            btnAddAdicional.Focus();
        }
        #endregion

        #region Eventos Validating
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
                PreencherCamposEnderecoEntrega(oEndereco);

                btnEditarCliente.Enabled = true;
            }
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
            PreencherCamposEnderecoEntrega(oEndereco);

            btnEditarCliente.Enabled = true;
        }
        #endregion

        #region Outros médotos
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

        private void PreencherCamposEnderecoEntrega(Endereco oEndereco)
        {
            lblCodEnderecoEntrega.Text = oEndereco.Codigo.ToString();
            lblMstRua.Text = oEndereco.Rua;
            lblMstNumero.Text = oEndereco.Numero.ToString();
            lblMstComplemento.Text = oEndereco.Complemento;
            lblMstBairro.Text = oEndereco.Bairro;
            lblMstCidade.Text = oEndereco.Cidade;
        }

        private void PrepararListas()
        {
            //lista de pizzas
            lvlListagemPedidosPizzas.Clear();
            lvlListagemPedidosPizzas.View = View.Details;
            lvlListagemPedidosPizzas.Columns.Add("Cod Tamanho", 0, HorizontalAlignment.Right);
            lvlListagemPedidosPizzas.Columns.Add("Cod Sabor", 0, HorizontalAlignment.Right);
            lvlListagemPedidosPizzas.Columns.Add("Cod Borda", 0, HorizontalAlignment.Right);
            lvlListagemPedidosPizzas.Columns.Add("Descrição do Item", 700, HorizontalAlignment.Left);
            lvlListagemPedidosPizzas.Columns.Add("Valor (R$)", 70, HorizontalAlignment.Right);

            //lista de adicionais
            lvlListagemPedidosAdicionais.Clear();
            lvlListagemPedidosAdicionais.View = View.Details;
            lvlListagemPedidosAdicionais.Columns.Add("Cod Adicional", 0, HorizontalAlignment.Right);
            lvlListagemPedidosAdicionais.Columns.Add("Descrição do Item", 700, HorizontalAlignment.Left);
            lvlListagemPedidosAdicionais.Columns.Add("Valor (R$)", 70, HorizontalAlignment.Right);
        }

        private void PreencherListaAdicionais(int codigo)
        {
            var ngAdicional = new AdicionalNG();
            var oAdicional = ngAdicional.Buscar(codigo);
            if (oAdicional == null)
            {
                MessageBox.Show("Adicional não encontrado!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var linha = new string[3];
            linha[0] = oAdicional.Codigo.ToString();
            linha[1] = oAdicional.Descricao;
            linha[2] = oAdicional.Valor.ToString("C2");

            var itmx = new ListViewItem(linha);
            lvlListagemPedidosAdicionais.Items.Add(itmx);

            Funcoes.ListViewColor(lvlListagemPedidosAdicionais);

            AtualizarValorTotalPedido();
        }

        private void AtualizarValorTotalPedido()
        {
            decimal dValorTotal = 0;

            foreach (ListViewItem item in lvlListagemPedidosPizzas.Items)
                dValorTotal += Convert.ToDecimal(item.SubItems[4].Text.Replace("R$", "").Trim());

            foreach (ListViewItem item in lvlListagemPedidosAdicionais.Items)
                dValorTotal += Convert.ToDecimal(item.SubItems[2].Text.Replace("R$", "").Trim());

            if (chkTeleentrega.Checked)
            {
                MascaraDinheiro.TirarMascara(txtValorTeleentrega, new EventArgs());
                dValorTotal += Convert.ToDecimal(txtValorTeleentrega.Text.Trim());
                MascaraDinheiro.RetornarMascara(txtValorTeleentrega, new EventArgs());
            }

            lblMstValorTotal.Text = dValorTotal.ToString("C2");
        }

        #endregion

        private void chkTeleentrega_CheckedChanged(object sender, EventArgs e)
        {
            txtValorTeleentrega.Text = String.Empty;
            lblValorTele.Enabled = chkTeleentrega.Checked;
            txtValorTeleentrega.Enabled = chkTeleentrega.Checked;

            MascaraDinheiro.RetornarMascara(txtValorTeleentrega, new EventArgs());
        }
    }
}
