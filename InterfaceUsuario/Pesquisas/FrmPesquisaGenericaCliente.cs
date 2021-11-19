using Entidades.Enumeradores;
using InterfaceUsuario.Modulos;
using Negocio.Pessoas;
using System;
using System.Windows.Forms;

namespace InterfaceUsuario.Pesquisas
{
    public partial class FrmPesquisaGenericaCliente : Form
    {
        public int iRetorno = 0;
        public FrmPesquisaGenericaCliente( Status status)
        {
            InitializeComponent();

            if (status == Status.Ativo)
                optSomenteAtivos.Checked = true;
            else if (status == Status.Inativo)
                optSomenteInativos.Checked = true;
            else
                optTodos.Checked = true;
        }

        private void FrmPesquisaGenerica_Load(object sender, EventArgs e)
        {
            var form = new Form()
            {
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true,
                Top = 0,
                Left = 0
            };
            LimparCampos();
            PrepararListView();
            BuscarClientes();
        }

        private void BuscarClientes()
        {
            Status status;

            if (optSomenteAtivos.Checked)
            {
                status = Status.Ativo;
            }
            else if (optSomenteInativos.Checked)
            {
                status = Status.Inativo;
            }
            else
            {
                status = Status.Todos;
            }
            lvlListagem.Items.Clear();

            var lista = new ClienteNG().ListarPesquisaCliente(status, txtBusca.Text.Trim());
            if (lista.Count < 1)
                return;
            foreach (var item in lista)
            {
                var linha = new string[4];
                linha[0] = item.Codigo.ToString();
                linha[1] = item.Nome;
                linha[2] = item.Telefone;
                linha[3] = item.Celular;
                var itmx = new ListViewItem(linha);
                lvlListagem.Items.Add(itmx);
            }
            Funcoes.ListViewColor(lvlListagem);
        }

        private void PrepararListView()
        {
            lvlListagem.Clear();
            lvlListagem.View = View.Details;
            lvlListagem.Columns.Add("Código", 80, HorizontalAlignment.Right);
            lvlListagem.Columns.Add("Nome", 280, HorizontalAlignment.Left);
            lvlListagem.Columns.Add("Telefone", 90, HorizontalAlignment.Left);
            lvlListagem.Columns.Add("Celular", 90, HorizontalAlignment.Left);
        }

        public void LimparCampos()
        {
            txtBusca.Text = string.Empty;
            iRetorno = 0;
        }

        private void lvlListagem_DoubleClick(object sender, EventArgs e)
        {
            btnConfirmar_Click(btnConfirmar, new EventArgs());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (lvlListagem.SelectedItems.Count <= 0)
                return;

            var iSelectecIndex = Convert.ToInt32(lvlListagem.SelectedIndices[0]);
            if (iSelectecIndex >= 0)
            {
                iRetorno = Convert.ToInt32(lvlListagem.Items[iSelectecIndex].Text);
                btnSair_Click(btnSair, new EventArgs());
            }
        }

        private void optTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (!optTodos.Checked)
                return;
            BuscarClientes();
        }

        private void optSomenteAtivos_CheckedChanged(object sender, EventArgs e)
        {
            if (!optSomenteAtivos.Checked)
                return;
            BuscarClientes();
        }

        private void optSomenteInativos_CheckedChanged(object sender, EventArgs e)
        {
            if (!optSomenteInativos.Checked)
                return;
            BuscarClientes();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Trim().Length > 2)
                BuscarClientes();
        }
    }
}
