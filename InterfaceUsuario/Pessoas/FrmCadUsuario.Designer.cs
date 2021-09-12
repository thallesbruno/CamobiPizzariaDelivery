
namespace InterfaceUsuario.Pessoas
{
    partial class FrmCadUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoTipoUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMstTipoUsuario = new System.Windows.Forms.Label();
            this.oUcSituacao = new InterfaceUsuario.UserControls.ucSituacao();
            this.btnBscTipoUsuario = new System.Windows.Forms.Button();
            this.btnBscUsuario = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Controls.Add(this.btnExcluir);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(394, 265);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 54);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::InterfaceUsuario.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(226, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 45);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::InterfaceUsuario.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(115, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 45);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::InterfaceUsuario.Properties.Resources.confirmar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmar.Location = new System.Drawing.Point(4, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(105, 45);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoUsuario.Location = new System.Drawing.Point(12, 25);
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.Size = new System.Drawing.Size(149, 20);
            this.txtCodigoUsuario.TabIndex = 2;
            this.txtCodigoUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoUsuario_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNomeUsuario.Location = new System.Drawing.Point(236, 25);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(489, 20);
            this.txtNomeUsuario.TabIndex = 6;
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLoginUsuario.Location = new System.Drawing.Point(236, 81);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(244, 20);
            this.txtLoginUsuario.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login:";
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSenhaUsuario.Location = new System.Drawing.Point(486, 81);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(242, 20);
            this.txtSenhaUsuario.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senha:";
            // 
            // txtCodigoTipoUsuario
            // 
            this.txtCodigoTipoUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoTipoUsuario.Location = new System.Drawing.Point(12, 162);
            this.txtCodigoTipoUsuario.Name = "txtCodigoTipoUsuario";
            this.txtCodigoTipoUsuario.Size = new System.Drawing.Size(149, 20);
            this.txtCodigoTipoUsuario.TabIndex = 12;
            this.txtCodigoTipoUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigoTipoUsuario_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo Usuário:";
            // 
            // lblMstTipoUsuario
            // 
            this.lblMstTipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstTipoUsuario.Location = new System.Drawing.Point(233, 165);
            this.lblMstTipoUsuario.Name = "lblMstTipoUsuario";
            this.lblMstTipoUsuario.Size = new System.Drawing.Size(495, 18);
            this.lblMstTipoUsuario.TabIndex = 14;
            this.lblMstTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // oUcSituacao
            // 
            this.oUcSituacao.Location = new System.Drawing.Point(523, 190);
            this.oUcSituacao.Name = "oUcSituacao";
            this.oUcSituacao.Size = new System.Drawing.Size(205, 69);
            this.oUcSituacao.TabIndex = 15;
            // 
            // btnBscTipoUsuario
            // 
            this.btnBscTipoUsuario.Image = global::InterfaceUsuario.Properties.Resources.busca;
            this.btnBscTipoUsuario.Location = new System.Drawing.Point(167, 162);
            this.btnBscTipoUsuario.Name = "btnBscTipoUsuario";
            this.btnBscTipoUsuario.Size = new System.Drawing.Size(23, 21);
            this.btnBscTipoUsuario.TabIndex = 13;
            this.btnBscTipoUsuario.UseVisualStyleBackColor = true;
            this.btnBscTipoUsuario.Click += new System.EventHandler(this.btnBscTipoUsuario_Click);
            // 
            // btnBscUsuario
            // 
            this.btnBscUsuario.Image = global::InterfaceUsuario.Properties.Resources.busca;
            this.btnBscUsuario.Location = new System.Drawing.Point(167, 25);
            this.btnBscUsuario.Name = "btnBscUsuario";
            this.btnBscUsuario.Size = new System.Drawing.Size(23, 21);
            this.btnBscUsuario.TabIndex = 3;
            this.btnBscUsuario.UseVisualStyleBackColor = true;
            this.btnBscUsuario.Click += new System.EventHandler(this.btnBscUsuario_Click);
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 327);
            this.Controls.Add(this.oUcSituacao);
            this.Controls.Add(this.lblMstTipoUsuario);
            this.Controls.Add(this.btnBscTipoUsuario);
            this.Controls.Add(this.txtCodigoTipoUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSenhaUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBscUsuario);
            this.Controls.Add(this.txtCodigoUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.FrmCadUsuario_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoUsuario;
        private System.Windows.Forms.Button btnBscUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBscTipoUsuario;
        private System.Windows.Forms.TextBox txtCodigoTipoUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMstTipoUsuario;
        private UserControls.ucSituacao oUcSituacao;
    }
}