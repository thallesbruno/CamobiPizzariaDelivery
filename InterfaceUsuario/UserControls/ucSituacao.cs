using Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceUsuario.UserControls
{
    public partial class ucSituacao : UserControl
    {
        public Status _status;
        public ucSituacao()
        {
            InitializeComponent();
        }

        private void ucSituacao_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            InicializarSituacao(Status.Ativo);
        }

        public void InicializarSituacao(Status status)
        {
            if (DesignMode) return;
            _status = status;
            if (status == Status.Ativo)
                optAtivo.Checked = true;
            else
                optInativo.Checked = true;
        }

        private void optAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (optAtivo.Checked)
            {
                _status = Status.Ativo;
            }
        }

        private void optInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (optInativo.Checked)
            {
                _status = Status.Ativo;
            }
        }
    }
}
