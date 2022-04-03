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
    public partial class FrmCadSaborBorda : Form
    {
        private bool IsNovo;

        public FrmCadSaborBorda()
        {
            InitializeComponent();

            MascaraCampoCodigo.AplicarEventos(txtCodigo);
            MascaraDinheiro.AplicarEventos(txtValorAdicional);
        }

        private void FrmCadSaborBorda_Load(object sender, EventArgs e)
        {
            btnCancelar_Click(btnCancelar, new EventArgs());
        }

        private void btnBscSaborBorda_Click(object sender, EventArgs e)
        {
            var lista = new SaborBordaNG().ListarEntidadesViewPesquisa(Status.Todos);
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
            var frmPesquisa = new FrmPesquisaGenerica("Listagem de Sabores de Borda", Status.Todos);
            frmPesquisa.lista = lista;
            frmPesquisa.ShowDialog();

            var iRetorno = frmPesquisa.iRetorno;
            //iRetorno = 0
            if (iRetorno < 1)
                return;

            txtCodigo.Text = iRetorno.ToString();
            txtCodigo_Validating(txtCodigo, new CancelEventArgs());
            btnBscSaborBorda.Focus();
        }

        private bool VerificarCampos()
        {
            if (txtDescricao.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você precisa informar a descrição do sabor de borda!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!VerificarCampos())
                return;

            var oSaborBorda = new SaborBorda();
            var SaborBordaNG = new SaborBordaNG();

            oSaborBorda.Descricao = txtDescricao.Text.Trim();
            oSaborBorda.Observacao = txtObservacao.Text.Trim();

            MascaraDinheiro.TirarMascara(txtValorAdicional, new EventArgs());
            oSaborBorda.ValorAdicional = Convert.ToDecimal(txtValorAdicional.Text.Trim());
            MascaraDinheiro.RetornarMascara(txtValorAdicional, new EventArgs());

            oSaborBorda.Status = oUcSituacao._status;
            oSaborBorda.CodigoUsrAlteracao = Sessao.Usuario.Codigo;
            //grava no banco primeira vez
            if (IsNovo)
            {
                if (SaborBordaNG.Inserir(oSaborBorda))
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
            else
            {
                oSaborBorda.Codigo = Convert.ToInt32(txtCodigo.Text.Trim());
                if (SaborBordaNG.Alterar(oSaborBorda))
                {
                    MessageBox.Show("Registro alterado com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao alterar registro. Revise as informações!");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim().Equals(String.Empty) || IsNovo)
                return;

            if (MessageBox.Show("Deseja excluir este registro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new SaborBordaNG().Excluir(Convert.ToInt32(txtCodigo.Text.Trim())))
                {
                    MessageBox.Show("Registro excluído com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir este registro. Tente novamente!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigo.Text.Trim().Equals(string.Empty))
                return;

            var oSaborBorda = new SaborBordaNG().Buscar(Convert.ToInt32(txtCodigo.Text.Trim()));
            if (oSaborBorda == null)
            {
                btnExcluir.Enabled = false;
                return;
            }

            IsNovo = false;

            txtDescricao.Text = oSaborBorda.Descricao;
            txtObservacao.Text = oSaborBorda.Observacao;
            txtValorAdicional.Text = oSaborBorda.ValorAdicional.ToString();
            MascaraCampoCodigo.RetornarMascara(txtCodigo, new EventArgs());
            MascaraDinheiro.RetornarMascara(txtValorAdicional, new EventArgs());

            oUcSituacao.InicializarSituacao(oSaborBorda.Status);
            btnExcluir.Enabled = true;
        }

        public void LimparCampos()
        {
            txtCodigo.Text = new SaborBordaNG().BuscarProximoCodigo().ToString();
            txtDescricao.Text = string.Empty;
            txtObservacao.Text = String.Empty;
            txtValorAdicional.Text = string.Empty;
            btnExcluir.Enabled = false;
            oUcSituacao.InicializarSituacao(Status.Ativo);
            MascaraCampoCodigo.RetornarMascara(txtCodigo, new EventArgs());
            MascaraDinheiro.RetornarMascara(txtValorAdicional, new EventArgs());
            IsNovo = true;
            Funcoes.SelecionarCampo(txtDescricao);
        }
    }
}
