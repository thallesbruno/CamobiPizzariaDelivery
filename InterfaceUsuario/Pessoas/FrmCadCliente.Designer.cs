
namespace InterfaceUsuario.Pessoas
{
    partial class FrmCadCliente
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBscCliente = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oUcSituacao = new InterfaceUsuario.UserControls.ucSituacao();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditarEndereco = new System.Windows.Forms.Button();
            this.btnRemoverEndereco = new System.Windows.Forms.Button();
            this.lvlListagemEnderecos = new System.Windows.Forms.ListView();
            this.chkEnderecoPadrao = new System.Windows.Forms.CheckBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdicionarEndereco = new System.Windows.Forms.Button();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNome.Location = new System.Drawing.Point(236, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(625, 20);
            this.txtNome.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome:";
            // 
            // btnBscCliente
            // 
            this.btnBscCliente.Image = global::InterfaceUsuario.Properties.Resources.busca;
            this.btnBscCliente.Location = new System.Drawing.Point(167, 28);
            this.btnBscCliente.Name = "btnBscCliente";
            this.btnBscCliente.Size = new System.Drawing.Size(23, 21);
            this.btnBscCliente.TabIndex = 9;
            this.btnBscCliente.UseVisualStyleBackColor = true;
            this.btnBscCliente.Click += new System.EventHandler(this.btnBscCliente_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigo.Location = new System.Drawing.Point(12, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(149, 20);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodigo_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código:";
            // 
            // oUcSituacao
            // 
            this.oUcSituacao.Location = new System.Drawing.Point(656, 476);
            this.oUcSituacao.Name = "oUcSituacao";
            this.oUcSituacao.Size = new System.Drawing.Size(205, 69);
            this.oUcSituacao.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Controls.Add(this.btnExcluir);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(527, 551);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 54);
            this.flowLayoutPanel1.TabIndex = 16;
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
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(236, 77);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(348, 77);
            this.txtCelular.Mask = "(00) 0 0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditarEndereco);
            this.groupBox1.Controls.Add(this.btnRemoverEndereco);
            this.groupBox1.Controls.Add(this.lvlListagemEnderecos);
            this.groupBox1.Controls.Add(this.chkEnderecoPadrao);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnAdicionarEndereco);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRua);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 352);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // btnEditarEndereco
            // 
            this.btnEditarEndereco.Image = global::InterfaceUsuario.Properties.Resources.editar;
            this.btnEditarEndereco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarEndereco.Location = new System.Drawing.Point(131, 301);
            this.btnEditarEndereco.Name = "btnEditarEndereco";
            this.btnEditarEndereco.Size = new System.Drawing.Size(116, 35);
            this.btnEditarEndereco.TabIndex = 36;
            this.btnEditarEndereco.Text = "Editar";
            this.btnEditarEndereco.UseVisualStyleBackColor = true;
            this.btnEditarEndereco.Click += new System.EventHandler(this.btnEditarEndereco_Click);
            // 
            // btnRemoverEndereco
            // 
            this.btnRemoverEndereco.Image = global::InterfaceUsuario.Properties.Resources.excluir;
            this.btnRemoverEndereco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverEndereco.Location = new System.Drawing.Point(7, 301);
            this.btnRemoverEndereco.Name = "btnRemoverEndereco";
            this.btnRemoverEndereco.Size = new System.Drawing.Size(115, 35);
            this.btnRemoverEndereco.TabIndex = 35;
            this.btnRemoverEndereco.Text = "Remover";
            this.btnRemoverEndereco.UseVisualStyleBackColor = true;
            this.btnRemoverEndereco.Click += new System.EventHandler(this.btnRemoverEndereco_Click);
            // 
            // lvlListagemEnderecos
            // 
            this.lvlListagemEnderecos.CheckBoxes = true;
            this.lvlListagemEnderecos.FullRowSelect = true;
            this.lvlListagemEnderecos.GridLines = true;
            this.lvlListagemEnderecos.HideSelection = false;
            this.lvlListagemEnderecos.Location = new System.Drawing.Point(6, 186);
            this.lvlListagemEnderecos.MultiSelect = false;
            this.lvlListagemEnderecos.Name = "lvlListagemEnderecos";
            this.lvlListagemEnderecos.Size = new System.Drawing.Size(831, 97);
            this.lvlListagemEnderecos.TabIndex = 34;
            this.lvlListagemEnderecos.UseCompatibleStateImageBehavior = false;
            this.lvlListagemEnderecos.DoubleClick += new System.EventHandler(this.lvlListagemEnderecos_DoubleClick);
            // 
            // chkEnderecoPadrao
            // 
            this.chkEnderecoPadrao.AutoSize = true;
            this.chkEnderecoPadrao.Location = new System.Drawing.Point(555, 151);
            this.chkEnderecoPadrao.Name = "chkEnderecoPadrao";
            this.chkEnderecoPadrao.Size = new System.Drawing.Size(85, 17);
            this.chkEnderecoPadrao.TabIndex = 33;
            this.chkEnderecoPadrao.Text = "End. Padrão";
            this.chkEnderecoPadrao.UseVisualStyleBackColor = true;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCidade.Location = new System.Drawing.Point(276, 149);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(264, 20);
            this.txtCidade.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Cidade:";
            // 
            // btnAdicionarEndereco
            // 
            this.btnAdicionarEndereco.Image = global::InterfaceUsuario.Properties.Resources.confirmar;
            this.btnAdicionarEndereco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarEndereco.Location = new System.Drawing.Point(698, 133);
            this.btnAdicionarEndereco.Name = "btnAdicionarEndereco";
            this.btnAdicionarEndereco.Size = new System.Drawing.Size(139, 35);
            this.btnAdicionarEndereco.TabIndex = 3;
            this.btnAdicionarEndereco.Text = "Adicionar";
            this.btnAdicionarEndereco.UseVisualStyleBackColor = true;
            this.btnAdicionarEndereco.Click += new System.EventHandler(this.btnAdicionarEndereco_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBairro.Location = new System.Drawing.Point(6, 149);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(264, 20);
            this.txtBairro.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.SystemColors.Window;
            this.txtComplemento.Location = new System.Drawing.Point(128, 98);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(709, 20);
            this.txtComplemento.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNumero.Location = new System.Drawing.Point(6, 98);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(116, 20);
            this.txtNumero.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Número:";
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRua.Location = new System.Drawing.Point(6, 45);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(831, 20);
            this.txtRua.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Rua:";
            // 
            // FrmCadCliente
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.oUcSituacao);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBscCliente);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmCadCliente_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBscCliente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private UserControls.ucSituacao oUcSituacao;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkEnderecoPadrao;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdicionarEndereco;
        private System.Windows.Forms.Button btnEditarEndereco;
        private System.Windows.Forms.Button btnRemoverEndereco;
        private System.Windows.Forms.ListView lvlListagemEnderecos;
    }
}