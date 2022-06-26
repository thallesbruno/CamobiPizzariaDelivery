namespace InterfaceUsuario.Produtos
{
    partial class FrmRotAdicionarPizza
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
            this.btnBscTamanhoPizza = new System.Windows.Forms.Button();
            this.txtCodTamanhoPizza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMstTamanhoPizza = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMstValorTamanhoPizza = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMstValorSabores = new System.Windows.Forms.Label();
            this.lblMstQtdSaboresSelecionados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMstQtdMaxSabores = new System.Windows.Forms.Label();
            this.lvlListagemEscolhidos = new System.Windows.Forms.ListView();
            this.lvlListagemSabores = new System.Windows.Forms.ListView();
            this.gpbSaborBorda = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMstValorSaborBorda = new System.Windows.Forms.Label();
            this.lblMstSaborBorda = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodSaborBorda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkAdicionarBorda = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMstValorTotalPizza = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpbSaborBorda.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBscTamanhoPizza
            // 
            this.btnBscTamanhoPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBscTamanhoPizza.Image = global::InterfaceUsuario.Properties.Resources.busca;
            this.btnBscTamanhoPizza.Location = new System.Drawing.Point(85, 26);
            this.btnBscTamanhoPizza.Name = "btnBscTamanhoPizza";
            this.btnBscTamanhoPizza.Size = new System.Drawing.Size(23, 21);
            this.btnBscTamanhoPizza.TabIndex = 43;
            this.btnBscTamanhoPizza.UseVisualStyleBackColor = true;
            // 
            // txtCodTamanhoPizza
            // 
            this.txtCodTamanhoPizza.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodTamanhoPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodTamanhoPizza.Location = new System.Drawing.Point(12, 26);
            this.txtCodTamanhoPizza.Name = "txtCodTamanhoPizza";
            this.txtCodTamanhoPizza.Size = new System.Drawing.Size(65, 20);
            this.txtCodTamanhoPizza.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tamanho da Pizza:";
            // 
            // lblMstTamanhoPizza
            // 
            this.lblMstTamanhoPizza.BackColor = System.Drawing.SystemColors.Control;
            this.lblMstTamanhoPizza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstTamanhoPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstTamanhoPizza.Location = new System.Drawing.Point(114, 23);
            this.lblMstTamanhoPizza.Name = "lblMstTamanhoPizza";
            this.lblMstTamanhoPizza.Size = new System.Drawing.Size(481, 23);
            this.lblMstTamanhoPizza.TabIndex = 47;
            this.lblMstTamanhoPizza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(601, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Valor:";
            // 
            // lblMstValorTamanhoPizza
            // 
            this.lblMstValorTamanhoPizza.BackColor = System.Drawing.SystemColors.Control;
            this.lblMstValorTamanhoPizza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstValorTamanhoPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstValorTamanhoPizza.Location = new System.Drawing.Point(601, 23);
            this.lblMstValorTamanhoPizza.Name = "lblMstValorTamanhoPizza";
            this.lblMstValorTamanhoPizza.Size = new System.Drawing.Size(132, 23);
            this.lblMstValorTamanhoPizza.TabIndex = 54;
            this.lblMstValorTamanhoPizza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblMstValorSabores);
            this.groupBox1.Controls.Add(this.lblMstQtdSaboresSelecionados);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMstQtdMaxSabores);
            this.groupBox1.Controls.Add(this.lvlListagemEscolhidos);
            this.groupBox1.Controls.Add(this.lvlListagemSabores);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 222);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sabores da Pizza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Valor Total de Sabores:";
            // 
            // lblMstValorSabores
            // 
            this.lblMstValorSabores.BackColor = System.Drawing.SystemColors.Control;
            this.lblMstValorSabores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstValorSabores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstValorSabores.Location = new System.Drawing.Point(590, 188);
            this.lblMstValorSabores.Name = "lblMstValorSabores";
            this.lblMstValorSabores.Size = new System.Drawing.Size(125, 23);
            this.lblMstValorSabores.TabIndex = 60;
            this.lblMstValorSabores.Text = "R$ 0,00";
            this.lblMstValorSabores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMstQtdSaboresSelecionados
            // 
            this.lblMstQtdSaboresSelecionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstQtdSaboresSelecionados.Location = new System.Drawing.Point(425, 170);
            this.lblMstQtdSaboresSelecionados.Name = "lblMstQtdSaboresSelecionados";
            this.lblMstQtdSaboresSelecionados.Size = new System.Drawing.Size(244, 18);
            this.lblMstQtdSaboresSelecionados.TabIndex = 59;
            this.lblMstQtdSaboresSelecionados.Text = "Quantidade de Sabores Selecionados -";
            this.lblMstQtdSaboresSelecionados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "/";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMstQtdMaxSabores
            // 
            this.lblMstQtdMaxSabores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstQtdMaxSabores.Location = new System.Drawing.Point(33, 170);
            this.lblMstQtdMaxSabores.Name = "lblMstQtdMaxSabores";
            this.lblMstQtdMaxSabores.Size = new System.Drawing.Size(355, 18);
            this.lblMstQtdMaxSabores.TabIndex = 57;
            this.lblMstQtdMaxSabores.Text = "Quantidade Máxima de Sabores - ";
            this.lblMstQtdMaxSabores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvlListagemEscolhidos
            // 
            this.lvlListagemEscolhidos.FullRowSelect = true;
            this.lvlListagemEscolhidos.GridLines = true;
            this.lvlListagemEscolhidos.HideSelection = false;
            this.lvlListagemEscolhidos.Location = new System.Drawing.Point(538, 19);
            this.lvlListagemEscolhidos.MultiSelect = false;
            this.lvlListagemEscolhidos.Name = "lvlListagemEscolhidos";
            this.lvlListagemEscolhidos.Size = new System.Drawing.Size(177, 148);
            this.lvlListagemEscolhidos.TabIndex = 2;
            this.lvlListagemEscolhidos.UseCompatibleStateImageBehavior = false;
            // 
            // lvlListagemSabores
            // 
            this.lvlListagemSabores.CheckBoxes = true;
            this.lvlListagemSabores.FullRowSelect = true;
            this.lvlListagemSabores.GridLines = true;
            this.lvlListagemSabores.HideSelection = false;
            this.lvlListagemSabores.Location = new System.Drawing.Point(6, 19);
            this.lvlListagemSabores.MultiSelect = false;
            this.lvlListagemSabores.Name = "lvlListagemSabores";
            this.lvlListagemSabores.Size = new System.Drawing.Size(526, 148);
            this.lvlListagemSabores.TabIndex = 1;
            this.lvlListagemSabores.UseCompatibleStateImageBehavior = false;
            // 
            // gpbSaborBorda
            // 
            this.gpbSaborBorda.Controls.Add(this.label3);
            this.gpbSaborBorda.Controls.Add(this.lblMstValorSaborBorda);
            this.gpbSaborBorda.Controls.Add(this.lblMstSaborBorda);
            this.gpbSaborBorda.Controls.Add(this.button1);
            this.gpbSaborBorda.Controls.Add(this.txtCodSaborBorda);
            this.gpbSaborBorda.Controls.Add(this.label7);
            this.gpbSaborBorda.Location = new System.Drawing.Point(12, 282);
            this.gpbSaborBorda.Name = "gpbSaborBorda";
            this.gpbSaborBorda.Size = new System.Drawing.Size(721, 100);
            this.gpbSaborBorda.TabIndex = 57;
            this.gpbSaborBorda.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Valor:";
            // 
            // lblMstValorSaborBorda
            // 
            this.lblMstValorSaborBorda.BackColor = System.Drawing.SystemColors.Control;
            this.lblMstValorSaborBorda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstValorSaborBorda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstValorSaborBorda.Location = new System.Drawing.Point(557, 31);
            this.lblMstValorSaborBorda.Name = "lblMstValorSaborBorda";
            this.lblMstValorSaborBorda.Size = new System.Drawing.Size(155, 23);
            this.lblMstValorSaborBorda.TabIndex = 60;
            this.lblMstValorSaborBorda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMstSaborBorda
            // 
            this.lblMstSaborBorda.BackColor = System.Drawing.SystemColors.Control;
            this.lblMstSaborBorda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstSaborBorda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstSaborBorda.Location = new System.Drawing.Point(123, 31);
            this.lblMstSaborBorda.Name = "lblMstSaborBorda";
            this.lblMstSaborBorda.Size = new System.Drawing.Size(428, 23);
            this.lblMstSaborBorda.TabIndex = 59;
            this.lblMstSaborBorda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::InterfaceUsuario.Properties.Resources.busca;
            this.button1.Location = new System.Drawing.Point(88, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 21);
            this.button1.TabIndex = 58;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtCodSaborBorda
            // 
            this.txtCodSaborBorda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodSaborBorda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSaborBorda.Location = new System.Drawing.Point(6, 34);
            this.txtCodSaborBorda.Name = "txtCodSaborBorda";
            this.txtCodSaborBorda.Size = new System.Drawing.Size(76, 20);
            this.txtCodSaborBorda.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Sabor da Borda:";
            // 
            // chkAdicionarBorda
            // 
            this.chkAdicionarBorda.AutoSize = true;
            this.chkAdicionarBorda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdicionarBorda.Location = new System.Drawing.Point(21, 280);
            this.chkAdicionarBorda.Name = "chkAdicionarBorda";
            this.chkAdicionarBorda.Size = new System.Drawing.Size(116, 17);
            this.chkAdicionarBorda.TabIndex = 58;
            this.chkAdicionarBorda.Text = "Adicionar Borda";
            this.chkAdicionarBorda.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(473, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Valor Total da Pizza:";
            // 
            // lblMstValorTotalPizza
            // 
            this.lblMstValorTotalPizza.BackColor = System.Drawing.SystemColors.Control;
            this.lblMstValorTotalPizza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstValorTotalPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstValorTotalPizza.Location = new System.Drawing.Point(606, 386);
            this.lblMstValorTotalPizza.Name = "lblMstValorTotalPizza";
            this.lblMstValorTotalPizza.Size = new System.Drawing.Size(125, 23);
            this.lblMstValorTotalPizza.TabIndex = 60;
            this.lblMstValorTotalPizza.Text = "R$ 0,00";
            this.lblMstValorTotalPizza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(376, 424);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 54);
            this.flowLayoutPanel1.TabIndex = 59;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::InterfaceUsuario.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(247, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 45);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::InterfaceUsuario.Properties.Resources.confirmar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmar.Location = new System.Drawing.Point(136, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(105, 45);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // FrmRotAdicionarPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 485);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblMstValorTotalPizza);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.chkAdicionarBorda);
            this.Controls.Add(this.gpbSaborBorda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMstValorTamanhoPizza);
            this.Controls.Add(this.lblMstTamanhoPizza);
            this.Controls.Add(this.btnBscTamanhoPizza);
            this.Controls.Add(this.txtCodTamanhoPizza);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRotAdicionarPizza";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Adicionar Pizza";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbSaborBorda.ResumeLayout(false);
            this.gpbSaborBorda.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBscTamanhoPizza;
        private System.Windows.Forms.TextBox txtCodTamanhoPizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMstTamanhoPizza;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMstValorTamanhoPizza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvlListagemEscolhidos;
        private System.Windows.Forms.ListView lvlListagemSabores;
        private System.Windows.Forms.Label lblMstQtdSaboresSelecionados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMstQtdMaxSabores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMstValorSabores;
        private System.Windows.Forms.GroupBox gpbSaborBorda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMstValorSaborBorda;
        private System.Windows.Forms.Label lblMstSaborBorda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCodSaborBorda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAdicionarBorda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMstValorTotalPizza;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}