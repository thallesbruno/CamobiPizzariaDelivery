using Entidades.Enumeradores;
using Entidades.Produtos;
using Entidades.Sistema;
using InterfaceUsuario.Modulos;
using InterfaceUsuario.Pesquisas;
using Negocio.Produtos;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InterfaceUsuario.Produtos
{
    public partial class FrmCadAdicional : Form
    {
        private bool IsNovo;

        public FrmCadAdicional()
        {
            InitializeComponent();

            MascaraCampoCodigo.AplicarEventos(txtCodigo);
            MascaraDinheiro.AplicarEventos(txtValor);
        }

        private void btnBscAdicional_Click(object sender, EventArgs e)
        {
            var lista = new AdicionalNG().ListarEntidadesViewPesquisa(Status.Todos);
            //verifica se a lista está vazia
            if (lista.Count < 1)
            {
                MessageBox.Show("Sem dados para serem exibidos!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            //passar a lista para o formulario generico de pesquisa
            var frmPesquisa = new FrmPesquisaGenerica("Listagem de Adicionais", Status.Todos);
            frmPesquisa.lista = lista;
            frmPesquisa.ShowDialog();

            var iRetorno = frmPesquisa.iRetorno;
            //iRetorno = 0
            if (iRetorno < 1)
                return;

            txtCodigo.Text = iRetorno.ToString();
            txtCodigo_Validating(txtCodigo, new CancelEventArgs());
            btnBscAdicional.Focus();
        }

        private bool VerificarCampos()
        {
            if (txtDescricao.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você precisa informar a descrição do adicional!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtValor.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você precisa informar o valor do adicional!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!VerificarCampos())
                return;

            var oAdicional = new Adicional();
            var adicionalNG = new AdicionalNG();

            oAdicional.Descricao = txtDescricao.Text.Trim();
            oAdicional.Observacao = txtObservacao.Text.Trim();
            oAdicional.Valor = Convert.ToDecimal(txtValor.Text.Trim());
            oAdicional.Status = oUcSituacao._status;
            oAdicional.CodigoUsrAlteracao = Sessao.Usuario.Codigo;
            //grava no banco primeira vez
            if (IsNovo)
            {
                if (adicionalNG.Inserir(oAdicional))
                {
                    MessageBox.Show("Registro cadastrado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar registro. Revise as informações!");
                }
            }
            //atualiza registro no banco
            //else
            //{
            //    oAdicional.Codigo = Convert.ToInt32(txtCodigo.Text.Trim());
            //    if (adicionalNG.Alterar(oAdicional))
            //    {
            //        MessageBox.Show("Registro alterado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        LimparCampos();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Erro ao alterar registro. Revise as informações!");
            //    }
            //}
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigo.Text.Trim().Equals(string.Empty))
                return;

            var oAdicional = new AdicionalNG().Buscar(Convert.ToInt32(txtCodigo.Text.Trim()));
            if (oAdicional == null)
            {
                btnExcluir.Enabled = false;
                return;
            }

            IsNovo = false;

            txtDescricao.Text = oAdicional.Descricao;
            txtObservacao.Text = oAdicional.Observacao;
            txtValor.Text = oAdicional.Valor.ToString();
            MascaraCampoCodigo.RetornarMascara(txtCodigo, new EventArgs());
            MascaraDinheiro.RetornarMascara(txtValor, new EventArgs());

            oUcSituacao.InicializarSituacao(oAdicional.Status);
            btnExcluir.Enabled = true;
        }

        public void LimparCampos()
        {
            txtCodigo.Text = new AdicionalNG().BuscarProximoCodigo().ToString();
            txtDescricao.Text = string.Empty;
            txtValor.Text = string.Empty;

            btnExcluir.Enabled = false;

            oUcSituacao.InicializarSituacao(Status.Ativo);

            MascaraCampoCodigo.RetornarMascara(txtCodigo, new EventArgs());
            MascaraDinheiro.RetornarMascara(txtValor, new EventArgs());
            IsNovo = true;
            Funcoes.SelecionarCampo(txtDescricao);
        }

        private void FrmCadAdicional_Load(object sender, EventArgs e)
        {
            btnCancelar_Click(btnCancelar, new EventArgs());
        }
    }
}
