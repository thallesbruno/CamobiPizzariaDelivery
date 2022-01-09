using Entidades.Enumeradores;
using Entidades.Pessoas;
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
        private bool isInibirAutoCheck;
        private int iCodEdicao;

        public FrmCadCliente()
        {
            InitializeComponent();
            MascaraCampoCodigo.AplicarEventos(txtCodigo);
            MascaraCampoNumero.AplicarEventos(txtNumero);
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
            if (!VerificarCampos())
                return;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnAdicionarEndereco_Click(object sender, EventArgs e)
        {
            if (VerificarCamposEndereco())
            {
                return;
            }

            var oEndereco = new Endereco();

            oEndereco.Rua = txtRua.Text.Trim();
            oEndereco.Numero = Convert.ToInt32(txtNumero.Text.Trim());
            oEndereco.Complemento = txtComplemento.Text.Trim();
            oEndereco.Bairro = txtBairro.Text.Trim();
            oEndereco.Cidade = txtCidade.Text.Trim();
            oEndereco.IsEnderecoPadrao = chkEnderecoPadrao.Checked;

            PreencherListaEnderecos(oEndereco);
            LimparCamposEndereco();
        }

        private void btnRemoverEndereco_Click(object sender, EventArgs e)
        {
            if (lvlListagemEnderecos.SelectedIndices.Count <= 0)
                return;
           
            var iSelectedIndex = Convert.ToInt32(lvlListagemEnderecos.SelectedIndices[0]);
            if (iSelectedIndex >= 0)
                lvlListagemEnderecos.Items[iSelectedIndex].Remove();
        }

        private void btnEditarEndereco_Click(object sender, EventArgs e)
        {
            if (lvlListagemEnderecos.SelectedIndices.Count <= 0)
                return;

            var iSelectedIndex = Convert.ToInt32(lvlListagemEnderecos.SelectedIndices[0]);
            if (iSelectedIndex >= 0)
            {
                var oEndereco = new Endereco();
                oEndereco.IsEnderecoPadrao = lvlListagemEnderecos.Items[iSelectedIndex].Checked;
                oEndereco.Rua = lvlListagemEnderecos.Items[iSelectedIndex].SubItems[1].Text;
                oEndereco.Numero = Convert.ToInt32(lvlListagemEnderecos.Items[iSelectedIndex].SubItems[2].Text);
                oEndereco.Complemento = lvlListagemEnderecos.Items[iSelectedIndex].SubItems[3].Text;
                oEndereco.Bairro = lvlListagemEnderecos.Items[iSelectedIndex].SubItems[4].Text;
                oEndereco.Cidade = lvlListagemEnderecos.Items[iSelectedIndex].SubItems[5].Text;

                PreencherCamposEndereco(oEndereco);

                lvlListagemEnderecos.Items[iSelectedIndex].Remove();
            }
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
        
        private bool VerificarCampos()
        {
            if (txtNome.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe o nome do cliente. Tente novamente!", 
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTelefone.Text.Trim().Equals(string.Empty) && txtCelular.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar o telefone ou o celular do cliente. Tente novamente!", 
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (lvlListagemEnderecos.Items.Count < 1)
            {
                MessageBox.Show("Você deve informar pelo menos um endereço para o cliente. Tente novamente!", 
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int iCountCheck = 0;
            foreach (ListViewItem item in lvlListagemEnderecos.Items)
            {
                if (item.Checked)
                    iCountCheck++;
            }
            if (iCountCheck == 0)
            {
                MessageBox.Show("Você deve informar pelo menos um endereço padrão para o cliente. Tente novamente!", 
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (iCountCheck > 1)
            {
                MessageBox.Show("Você deve informar apenas um endereço padrão para o cliente. Tente novamente!",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void PreencherCamposEndereco(Endereco oEndereco)
        {
            txtRua.Text = oEndereco.Rua;
            txtNumero.Text = oEndereco.Numero.ToString();
            txtComplemento.Text = oEndereco.Complemento.ToString();
            txtBairro.Text = oEndereco.Bairro.ToString();
            txtCidade.Text = oEndereco.Cidade.ToString();
            chkEnderecoPadrao.Checked = oEndereco.IsEnderecoPadrao;
        }
        private bool VerificarCamposEndereco()
        {
            if (txtRua.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar o nome da rua!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNumero.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar o número!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtBairro.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar o bairro!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtCidade.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar a cidade!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

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
                PreencherListaEnderecos(item);
            }
            oUcSituacao.InicializarSituacao(oCliente.Status);

            MascaraCampoCodigo.RetornarMascara(txtCodigo, new EventArgs());
            MascaraCampoNumero.RetornarMascara(txtNumero, new EventArgs());
            btnExcluir.Enabled = true;
        }

        private void PreencherListaEnderecos(Endereco obj)
        {
            var linha = new string[6];

            linha[0] = string.Empty;
            linha[1] = obj.Rua;
            linha[2] = obj.Numero.ToString();
            linha[3] = obj.Complemento;
            linha[4] = obj.Bairro;
            linha[5] = obj.Cidade;

            var itmx = new ListViewItem(linha);
            if (obj.IsEnderecoPadrao)
                itmx.Checked = true;
            else
                itmx.Checked = false;
            lvlListagemEnderecos.Items.Add(itmx);
        }

        private void LimparCampos()
        {
            LimparCamposEndereco();
            
            txtCodigo.Text = new ClienteNG().BuscarProximoCodigo().ToString();
            txtNome.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtCelular.Text = String.Empty;

            lvlListagemEnderecos.Items.Clear();
            btnExcluir.Enabled = false;

            MascaraCampoCodigo.RetornarMascara(txtCodigo, new EventArgs());
            MascaraCampoNumero.RetornarMascara(txtNumero, new EventArgs());
            oUcSituacao.InicializarSituacao(Status.Ativo);

            isNovo = true;
            Funcoes.SelecionarCampo(txtNome);
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

        private void lvlListagemEnderecos_DoubleClick(object sender, EventArgs e)
        {
            btnEditarEndereco_Click(btnEditarEndereco, new EventArgs());
        }


        private void lvlListagemEnderecos_MouseDown(object sender, MouseEventArgs e)
        {
            isInibirAutoCheck = true;
        }

        private void lvlListagemEnderecos_MouseUp(object sender, MouseEventArgs e)
        {
            isInibirAutoCheck = false;
        }

        private void lvlListagemEnderecos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (isInibirAutoCheck)
            {
                e.NewValue = e.CurrentValue;
                return;
            }

            if (VerificarSeExisteEnderecoPadrao() && e.NewValue == CheckState.Checked)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("Deve ter somente um endereço padrão!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool VerificarSeExisteEnderecoPadrao()
        {
            foreach (ListViewItem item in lvlListagemEnderecos.Items)
            {
                if (item.Checked)
                    return true;
            }
            return false;
        }
    }
}
