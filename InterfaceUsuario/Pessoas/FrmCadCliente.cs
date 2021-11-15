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

namespace InterfaceUsuario.Pessoas
{
    public partial class FrmCadCliente : Form
    {
        public FrmCadCliente()
        {
            InitializeComponent();
            MascaraCampoCodigo.AplicarEventos(txtCodigo);
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {

        }

        //##### Botoes #####
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoverEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarEndereco_Click(object sender, EventArgs e)
        {

        }

        private void btnBscCliente_Click(object sender, EventArgs e)
        {
             
        }

        //##### Fim Botoes #####
    }
}
