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
    public partial class FrmCadTamanhoPizza : Form
    {
        private bool IsNovo;

        public FrmCadTamanhoPizza()
        {
            InitializeComponent();

            MascaraCampoCodigo.AplicarEventos(txtCodigo);
            MascaraDinheiro.AplicarEventos(txtValor);
        }        

        private void FrmCadTamanhoPizza_Load(object sender, EventArgs e)
        {
            btnCancelar_Click(btnCancelar, new EventArgs());
        }

        private void btnBscTamanhoPizza_Click(object sender, EventArgs e)
        {
            var lista = new TamanhoPizzaNG().ListarEntidadesViewPesquisa(Status.Todos);
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
            var frmPesquisa = new FrmPesquisaGenerica("Listagem de Tamanho de Pizzas", Status.Todos);
            frmPesquisa.lista = lista;
            frmPesquisa.ShowDialog();

            var iRetorno = frmPesquisa.iRetorno;
            //iRetorno = 0
            if (iRetorno < 1)
                return;

            txtCodigo.Text = iRetorno.ToString();
            txtCodigo_Validating(txtCodigo, new CancelEventArgs());
            btnBscTamanhoPizza.Focus();
        }

        private bool VerificarCampos()
        {
            if (txtDescricao.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você precisa informar a descrição do tamanho de pizza!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            MascaraDinheiro.TirarMascara(txtValor, new EventArgs());
            var dValor = Convert.ToDecimal(txtValor.Text.Trim());
            MascaraDinheiro.RetornarMascara(txtValor, new EventArgs());

            if (dValor <= 0)
            {
                MessageBox.Show("Você precisa informar um valor válido para o tamanho de pizza!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbQtdSabores.SelectedIndex == -1)
            {
                MessageBox.Show("Você precisa informar a quantidade de sabores do tamanho de pizza!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!VerificarCampos())
                return;

            var oTamanhoPizza = new TamanhoPizza();
            var tamanhoPizzaNG = new TamanhoPizzaNG();

            oTamanhoPizza.Descricao = txtDescricao.Text.Trim();
            oTamanhoPizza.Observacao = txtObservacao.Text.Trim();

            MascaraDinheiro.TirarMascara(txtValor, new EventArgs());
            oTamanhoPizza.Valor = Convert.ToDecimal(txtValor.Text.Trim());
            MascaraDinheiro.RetornarMascara(txtValor, new EventArgs());

            /*
             *  1 2 3 4 5 6
             *  0 1 2 3 4 5
             * 
             */

            oTamanhoPizza.QtdSabores = cmbQtdSabores.SelectedIndex + 1;

            oTamanhoPizza.Status = oUcSituacao._status;
            oTamanhoPizza.CodigoUsrAlteracao = Sessao.Usuario.Codigo;
            //grava no banco primeira vez
            if (IsNovo)
            {
                if (tamanhoPizzaNG.Inserir(oTamanhoPizza))
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
                oTamanhoPizza.Codigo = Convert.ToInt32(txtCodigo.Text.Trim());
                if (tamanhoPizzaNG.Alterar(oTamanhoPizza))
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
                if (new TamanhoPizzaNG().Excluir(Convert.ToInt32(txtCodigo.Text.Trim())))
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

        public void LimparCampos()
        {
            txtCodigo.Text = new TamanhoPizzaNG().BuscarProximoCodigo().ToString();
            txtDescricao.Text = string.Empty;
            txtObservacao.Text = String.Empty;
            txtValor.Text = string.Empty;
            cmbQtdSabores.SelectedIndex = -1;
            btnExcluir.Enabled = false;
            oUcSituacao.InicializarSituacao(Status.Ativo);
            MascaraCampoCodigo.RetornarMascara(txtCodigo, new EventArgs());
            MascaraDinheiro.RetornarMascara(txtValor, new EventArgs());
            IsNovo = true;
            Funcoes.SelecionarCampo(txtDescricao);
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigo.Text.Trim().Equals(string.Empty))
                return;

            var oTamanhoPizza = new TamanhoPizzaNG().Buscar(Convert.ToInt32(txtCodigo.Text.Trim()));
            if (oTamanhoPizza == null)
            {
                btnExcluir.Enabled = false;
                return;
            }

            IsNovo = false;

            txtDescricao.Text = oTamanhoPizza.Descricao;
            txtObservacao.Text = oTamanhoPizza.Observacao;
            txtValor.Text = oTamanhoPizza.Valor.ToString();
            MascaraCampoCodigo.RetornarMascara(txtCodigo, new EventArgs());
            MascaraDinheiro.RetornarMascara(txtValor, new EventArgs());

            cmbQtdSabores.SelectedIndex = oTamanhoPizza.QtdSabores - 1;

            oUcSituacao.InicializarSituacao(oTamanhoPizza.Status);
            btnExcluir.Enabled = true;
        }
    }
}
