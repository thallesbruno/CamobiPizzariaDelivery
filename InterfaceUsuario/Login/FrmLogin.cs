using Entidades.Sistema;
using Negocio.Pessoas;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace InterfaceUsuario.Login
{
    public partial class FrmLogin : Form
    {
        public bool bFlagLogin;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersao.Text = string.Format(lblVersao.Text, version.Major, version.Minor, version.Build, version.Revision);
        }

        public void CarregarUsuarios()
        {
            var lista = new UsuarioNG().ListarUsuariosAtivos();
            if (lista.Count > 0)
            {
                foreach (var item in lista)
                {
                    cmbUsuarios.Items.Add(new ComboBoxItemUsuario(item.Login, item.Codigo, item.Senha));

                }
            }
            //define o primeiro da lista
            cmbUsuarios.SelectedIndex = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Você deve selecionar o login para acessar o sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSenha.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Você deve digitar a sua senha para acessar o sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var item = (ComboBoxItemUsuario)cmbUsuarios.SelectedItem;
            if (item.Senha != txtSenha.Text.Trim())
            {
                MessageBox.Show("Senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bFlagLogin = true;

            Sessao.Usuario = new Entidades.Entidade(item.Codigo, item.Login);
            Sessao.TipoUsuario = new TipoUsuarioNG().BuscarTipoUsuarioDoUsuario(item.Codigo); 

            this.Close();
        }
    }
}
    