
namespace InterfaceUsuario.Pesquisas
{
    partial class FrmPesquisaGenerica
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optSomenteInativos = new System.Windows.Forms.RadioButton();
            this.optSomenteAtivos = new System.Windows.Forms.RadioButton();
            this.optTodos = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvlListagem = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSair);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(242, 465);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(299, 52);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Image = global::InterfaceUsuario.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(191, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(105, 45);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::InterfaceUsuario.Properties.Resources.confirmar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmar.Location = new System.Drawing.Point(80, 3);
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
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Busca";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(15, 36);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(523, 20);
            this.txtBusca.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optSomenteInativos);
            this.groupBox1.Controls.Add(this.optSomenteAtivos);
            this.groupBox1.Controls.Add(this.optTodos);
            this.groupBox1.Location = new System.Drawing.Point(15, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            // 
            // optSomenteInativos
            // 
            this.optSomenteInativos.AutoSize = true;
            this.optSomenteInativos.Location = new System.Drawing.Point(369, 20);
            this.optSomenteInativos.Name = "optSomenteInativos";
            this.optSomenteInativos.Size = new System.Drawing.Size(107, 17);
            this.optSomenteInativos.TabIndex = 2;
            this.optSomenteInativos.TabStop = true;
            this.optSomenteInativos.Text = "Somente Inativos";
            this.optSomenteInativos.UseVisualStyleBackColor = true;
            // 
            // optSomenteAtivos
            // 
            this.optSomenteAtivos.AutoSize = true;
            this.optSomenteAtivos.Location = new System.Drawing.Point(189, 20);
            this.optSomenteAtivos.Name = "optSomenteAtivos";
            this.optSomenteAtivos.Size = new System.Drawing.Size(99, 17);
            this.optSomenteAtivos.TabIndex = 1;
            this.optSomenteAtivos.TabStop = true;
            this.optSomenteAtivos.Text = "Somente Ativos";
            this.optSomenteAtivos.UseVisualStyleBackColor = true;
            // 
            // optTodos
            // 
            this.optTodos.AutoSize = true;
            this.optTodos.Location = new System.Drawing.Point(44, 20);
            this.optTodos.Name = "optTodos";
            this.optTodos.Size = new System.Drawing.Size(55, 17);
            this.optTodos.TabIndex = 0;
            this.optTodos.TabStop = true;
            this.optTodos.Text = "Todos";
            this.optTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvlListagem);
            this.groupBox2.Location = new System.Drawing.Point(15, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 342);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listagem de Dados";
            // 
            // lvlListagem
            // 
            this.lvlListagem.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvlListagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvlListagem.FullRowSelect = true;
            this.lvlListagem.GridLines = true;
            this.lvlListagem.HideSelection = false;
            this.lvlListagem.Location = new System.Drawing.Point(3, 16);
            this.lvlListagem.Name = "lvlListagem";
            this.lvlListagem.Size = new System.Drawing.Size(517, 323);
            this.lvlListagem.TabIndex = 0;
            this.lvlListagem.UseCompatibleStateImageBehavior = false;
            this.lvlListagem.DoubleClick += new System.EventHandler(this.lvlListagem_DoubleClick);
            // 
            // FrmPesquisaGenerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPesquisaGenerica";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "á podendpo";
            this.Load += new System.EventHandler(this.FrmPesquisaGenerica_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optSomenteInativos;
        private System.Windows.Forms.RadioButton optSomenteAtivos;
        private System.Windows.Forms.RadioButton optTodos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvlListagem;
    }
}