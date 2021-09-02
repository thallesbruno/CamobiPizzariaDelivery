using Entidades.Entidades;
using InterfaceUsuario.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUsuario.Pesquisas
{
    public partial class FrmPesquisaGenerica : Form
    {
        public List<EntidadeViewPesquisa> lista = new List<EntidadeViewPesquisa>();
        public int iRetorno = 0;
        public FrmPesquisaGenerica()
        {
            InitializeComponent();
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
            PreencherLista(lista);
        }

        private void PreencherLista(List<EntidadeViewPesquisa> list)
        {
            lvlListagem.Clear();
            lvlListagem.View = View.Details;

            lvlListagem.Columns.Add("Código", 80, HorizontalAlignment.Right);
            lvlListagem.Columns.Add("Descrição", 280, HorizontalAlignment.Left);

            foreach (var item in list)
            {
                if (!optTodos.Checked)
                {
                    if (optSomenteAtivos.Checked && item.Status != Entidades.Enumeradores.Status.Ativo)
                        continue;
                    else if (optSomenteInativos.Checked && item.Status != Entidades.Enumeradores.Status.Inativo)
                        continue;
                }
                var linha = new string[2];
                linha[0] = item.Codigo.ToString();
                linha[1] = item.Descricao;
                var itemX = new ListViewItem(linha);
                lvlListagem.Items.Add(itemX);
            }
            Funcoes.ListViewColor(lvlListagem);
        }
    }
}
