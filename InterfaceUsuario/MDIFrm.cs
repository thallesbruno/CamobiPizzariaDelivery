using InterfaceUsuario.Login;
using System;
using System.Windows.Forms;

namespace InterfaceUsuario
{
    public partial class MDIFrm : Form
    {
        public MDIFrm()
        {
            InitializeComponent();
        }

        private void MDIFrm_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is MdiClient)
                {
                    control.BackgroundImage = Properties.Resources.fundo;
                    control.BackgroundImageLayout = ImageLayout.Zoom;
                    break;
                }
            }

            var frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

        }
    }
}
