
namespace InterfaceUsuario.UserControls
{
    partial class ucSituacao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbSituacao = new System.Windows.Forms.GroupBox();
            this.optAtivo = new System.Windows.Forms.RadioButton();
            this.optInativo = new System.Windows.Forms.RadioButton();
            this.gpbSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbSituacao
            // 
            this.gpbSituacao.Controls.Add(this.optInativo);
            this.gpbSituacao.Controls.Add(this.optAtivo);
            this.gpbSituacao.Location = new System.Drawing.Point(0, 0);
            this.gpbSituacao.Name = "gpbSituacao";
            this.gpbSituacao.Size = new System.Drawing.Size(200, 69);
            this.gpbSituacao.TabIndex = 0;
            this.gpbSituacao.TabStop = false;
            this.gpbSituacao.Text = "Status";
            // 
            // optAtivo
            // 
            this.optAtivo.AutoSize = true;
            this.optAtivo.Location = new System.Drawing.Point(34, 30);
            this.optAtivo.Name = "optAtivo";
            this.optAtivo.Size = new System.Drawing.Size(49, 17);
            this.optAtivo.TabIndex = 0;
            this.optAtivo.TabStop = true;
            this.optAtivo.Text = "Ativo";
            this.optAtivo.UseVisualStyleBackColor = true;
            this.optAtivo.CheckedChanged += new System.EventHandler(this.optAtivo_CheckedChanged);
            // 
            // optInativo
            // 
            this.optInativo.AutoSize = true;
            this.optInativo.Location = new System.Drawing.Point(111, 30);
            this.optInativo.Name = "optInativo";
            this.optInativo.Size = new System.Drawing.Size(57, 17);
            this.optInativo.TabIndex = 1;
            this.optInativo.TabStop = true;
            this.optInativo.Text = "Inativo";
            this.optInativo.UseVisualStyleBackColor = true;
            this.optInativo.CheckedChanged += new System.EventHandler(this.optInativo_CheckedChanged);
            // 
            // ucSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbSituacao);
            this.Name = "ucSituacao";
            this.Size = new System.Drawing.Size(199, 69);
            this.Load += new System.EventHandler(this.ucSituacao_Load);
            this.gpbSituacao.ResumeLayout(false);
            this.gpbSituacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSituacao;
        private System.Windows.Forms.RadioButton optInativo;
        private System.Windows.Forms.RadioButton optAtivo;
    }
}
