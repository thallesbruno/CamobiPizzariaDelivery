﻿
namespace InterfaceUsuario
{
    partial class MDIFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIFrm));
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saboresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bordasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamanhosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatõriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.rotinasToolStripMenuItem,
            this.relatõriosToolStripMenuItem});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(1393, 24);
            this.mnsPrincipal.TabIndex = 1;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionaisToolStripMenuItem,
            this.pizzasToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // adicionaisToolStripMenuItem
            // 
            this.adicionaisToolStripMenuItem.Name = "adicionaisToolStripMenuItem";
            this.adicionaisToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.adicionaisToolStripMenuItem.Text = "Adicionais";
            this.adicionaisToolStripMenuItem.Click += new System.EventHandler(this.adicionaisToolStripMenuItem_Click);
            // 
            // pizzasToolStripMenuItem
            // 
            this.pizzasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saboresToolStripMenuItem,
            this.bordasToolStripMenuItem,
            this.tamanhosToolStripMenuItem});
            this.pizzasToolStripMenuItem.Name = "pizzasToolStripMenuItem";
            this.pizzasToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.pizzasToolStripMenuItem.Text = "Pizzas";
            // 
            // saboresToolStripMenuItem
            // 
            this.saboresToolStripMenuItem.Name = "saboresToolStripMenuItem";
            this.saboresToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.saboresToolStripMenuItem.Text = "Sabores";
            this.saboresToolStripMenuItem.Click += new System.EventHandler(this.saboresToolStripMenuItem_Click);
            // 
            // bordasToolStripMenuItem
            // 
            this.bordasToolStripMenuItem.Name = "bordasToolStripMenuItem";
            this.bordasToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.bordasToolStripMenuItem.Text = "Bordas";
            this.bordasToolStripMenuItem.Click += new System.EventHandler(this.bordasToolStripMenuItem_Click);
            // 
            // tamanhosToolStripMenuItem
            // 
            this.tamanhosToolStripMenuItem.Name = "tamanhosToolStripMenuItem";
            this.tamanhosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.tamanhosToolStripMenuItem.Text = "Tamanhos";
            this.tamanhosToolStripMenuItem.Click += new System.EventHandler(this.tamanhosToolStripMenuItem_Click);
            // 
            // rotinasToolStripMenuItem
            // 
            this.rotinasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem});
            this.rotinasToolStripMenuItem.Name = "rotinasToolStripMenuItem";
            this.rotinasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.rotinasToolStripMenuItem.Text = "Rotinas";
            // 
            // relatõriosToolStripMenuItem
            // 
            this.relatõriosToolStripMenuItem.Name = "relatõriosToolStripMenuItem";
            this.relatõriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatõriosToolStripMenuItem.Text = "Relatórios";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // MDIFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfaceUsuario.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(1393, 693);
            this.Controls.Add(this.mnsPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "MDIFrm";
            this.Text = "Camobi Pizzaria Delivery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIFrm_Load);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatõriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saboresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bordasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamanhosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
    }
}

