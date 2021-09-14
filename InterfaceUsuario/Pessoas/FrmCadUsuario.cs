﻿using Entidades.Enumeradores;
using InterfaceUsuario.Modulos;
using InterfaceUsuario.Pesquisas;
using Negocio.Pessoas;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InterfaceUsuario.Pessoas
{
    public partial class FrmCadUsuario : Form
    {

        private bool IsNovo;
        public FrmCadUsuario()
        {
            InitializeComponent();
            MascaraCampoCodigo.AplicarEventos(txtCodigoUsuario);
            MascaraCampoCodigo.AplicarEventos(txtCodigoTipoUsuario);
        }

        private void btnBscUsuario_Click(object sender, EventArgs e)
        {
            var lista = new UsuarioNG().ListarEntidadesViewPesquisa(Status.Todos);
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
            var frmPesquisa = new FrmPesquisaGenerica("Listagem de Usuários", Status.Todos);
            frmPesquisa.lista = lista;
            frmPesquisa.ShowDialog();

            var iRetorno = frmPesquisa.iRetorno;
            //iRetorno = 0
            if (iRetorno < 1)
                return;

            txtCodigoUsuario.Text = iRetorno.ToString();
            txtCodigoUsuario_Validating(txtCodigoUsuario, new CancelEventArgs());
            btnBscUsuario.Focus();
        }

        private void btnBscTipoUsuario_Click(object sender, EventArgs e)
        {
            var lista = new TipoUsuarioNG().ListarEntidadesViewPesquisa();
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
            var frmPesquisa = new FrmPesquisaGenerica("Listagem de Tipos de Usuários", Status.Todos);
            frmPesquisa.lista = lista;
            frmPesquisa.ShowDialog();

            var iRetorno = frmPesquisa.iRetorno;
            //iRetorno = 0
            if (iRetorno < 1)
                return;

            txtCodigoTipoUsuario.Text = iRetorno.ToString();
            txtCodigoTipoUsuario_Validating(txtCodigoTipoUsuario, new CancelEventArgs());
            btnBscTipoUsuario.Focus();
        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {
            btnCancelar_Click(btnCancelar, new EventArgs());
        }

        public void LimparCampos()
        {
            txtCodigoUsuario.Text = new UsuarioNG().BuscarProximoCodigo().ToString();
            txtNomeUsuario.Text = string.Empty;
            txtLoginUsuario.Text = string.Empty;
            txtSenhaUsuario.Text = string.Empty;
            txtCodigoTipoUsuario.Text = string.Empty;
            btnExcluir.Enabled = false;
            oUcSituacao.InicializarSituacao(Status.Ativo);

            MascaraCampoCodigo.RetornarMascara(txtCodigoUsuario, new EventArgs());
            MascaraCampoCodigo.RetornarMascara(txtCodigoTipoUsuario, new EventArgs());
            IsNovo = true;
            Funcoes.SelecionarCampo(txtNomeUsuario);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        
        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
        
        private void txtCodigoUsuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //verificar se esta vazio
            if (txtCodigoUsuario.Text.Trim().Equals(string.Empty))
                return;

            var oUsuario = new UsuarioNG().Buscar(Convert.ToInt32(txtCodigoUsuario.Text.Trim()));
            if (oUsuario == null)
            {
                btnExcluir.Enabled = false;
                return;
            }

            IsNovo = false;
            txtNomeUsuario.Text = oUsuario.Nome;
            txtLoginUsuario.Text = oUsuario.Login;
            txtSenhaUsuario.Text = oUsuario.Senha;
            txtCodigoTipoUsuario.Text = oUsuario.TipoUsuario.Codigo.ToString();

            //1 - Validar o tipo usuario
            txtCodigoTipoUsuario_Validating(txtCodigoTipoUsuario, new CancelEventArgs());
            //2 - mascara do campo codigo usuario
            MascaraCampoCodigo.RetornarMascara(txtCodigoUsuario, new EventArgs());
            //3 - mascara do campo codigo tipo usuario
            MascaraCampoCodigo.RetornarMascara(txtCodigoTipoUsuario, new EventArgs());

            oUcSituacao.InicializarSituacao(oUsuario.Status);
            btnExcluir.Enabled = true;
        }

        private void txtCodigoTipoUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigoTipoUsuario.Text.Trim().Equals(string.Empty))
            {
                lblMstTipoUsuario.Text = string.Empty;
                return;
            }

            var oTipoUsuario = new TipoUsuarioNG().Buscar(Convert.ToInt32(txtCodigoTipoUsuario.Text.Trim()));
            if (oTipoUsuario == null)
            {
                MessageBox.Show("Tipo de usuário não encontrado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoTipoUsuario.Select();
                return;
            }
            lblMstTipoUsuario.Text = oTipoUsuario.Descricao;
        }
    }
}
