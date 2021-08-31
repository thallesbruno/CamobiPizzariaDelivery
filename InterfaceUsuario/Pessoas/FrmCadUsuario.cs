using Entidades.Enumeradores;
using Negocio.Pessoas;
using System;
using System.Windows.Forms;

namespace InterfaceUsuario.Pessoas
{
    public partial class FrmCadUsuario : Form
    {
        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnBscUsuario_Click(object sender, EventArgs e)
        {
            var lista = new UsuarioNG().ListarEntidadesViewPesquisa(Status.Todos);
            //verifica se a lista está vazia
            if (lista.Count < 1)
            {
                MessageBox.Show("Sem da dos para serem exibidos!",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            //passar a lista para o formulario generico de pesquisa

        }

        private void btnBscTipoUsuario_Click(object sender, EventArgs e)
        {
            
        }
    }
}
