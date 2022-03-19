using Entidades.Enumeradores;
using InterfaceUsuario.Modulos;
using InterfaceUsuario.Pesquisas;
using Negocio.Produtos;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InterfaceUsuario.Produtos
{
    public partial class FrmCadSaborPizza : Form
    {
        private bool IsNovo;

        public FrmCadSaborPizza()
        {
            InitializeComponent();

            MascaraCampoCodigo.AplicarEventos(txtCodigo);
            MascaraDinheiro.AplicarEventos(txtValorAdicional);
        }

        private void FrmCadSaborPizza_Load(object sender, EventArgs e)
        {

        }

        private void btnBscSaborPizza_Click(object sender, EventArgs e)
        {
            var lista = new SaborPizzaNG().ListarEntidadesViewPesquisa(Status.Todos);
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
            btnBscSaborPizza.Focus();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
