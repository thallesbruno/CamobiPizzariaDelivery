
namespace InterfaceUsuario.Produtos
{
    partial class FrmRotPedidos
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
            this.tbcPedidos = new System.Windows.Forms.TabControl();
            this.tbpRegistro = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblMstValorTotal = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAlterarEndereco = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMstCidade = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMstBairro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMstComplemento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMstNumero = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblMstRua = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMstNomeCliente = new System.Windows.Forms.Label();
            this.btnAdicionarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnBscCliente = new System.Windows.Forms.Button();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.MaskedTextBox();
            this.tbpAndamento = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lvlListagemPedidosPizzas = new System.Windows.Forms.ListView();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.btnDelPizza = new System.Windows.Forms.Button();
            this.btnDelAdicional = new System.Windows.Forms.Button();
            this.btnAddAdicional = new System.Windows.Forms.Button();
            this.lvlListagemPedidosAdicionais = new System.Windows.Forms.ListView();
            this.chkTeleentrega = new System.Windows.Forms.CheckBox();
            this.txtValorTeleentrega = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbcPedidos.SuspendLayout();
            this.tbpRegistro.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.lblMstValorTotal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPedidos
            // 
            this.tbcPedidos.Controls.Add(this.tbpRegistro);
            this.tbcPedidos.Controls.Add(this.tbpAndamento);
            this.tbcPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPedidos.Location = new System.Drawing.Point(0, 0);
            this.tbcPedidos.Name = "tbcPedidos";
            this.tbcPedidos.SelectedIndex = 0;
            this.tbcPedidos.Size = new System.Drawing.Size(1180, 701);
            this.tbcPedidos.TabIndex = 0;
            // 
            // tbpRegistro
            // 
            this.tbpRegistro.Controls.Add(this.flowLayoutPanel1);
            this.tbpRegistro.Controls.Add(this.lblMstValorTotal);
            this.tbpRegistro.Controls.Add(this.groupBox1);
            this.tbpRegistro.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistro.Name = "tbpRegistro";
            this.tbpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistro.Size = new System.Drawing.Size(1172, 675);
            this.tbpRegistro.TabIndex = 0;
            this.tbpRegistro.Text = "Registro";
            this.tbpRegistro.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(811, 613);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 54);
            this.flowLayoutPanel1.TabIndex = 35;
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
            // lblMstValorTotal
            // 
            this.lblMstValorTotal.Controls.Add(this.label12);
            this.lblMstValorTotal.Controls.Add(this.label11);
            this.lblMstValorTotal.Controls.Add(this.txtValorTeleentrega);
            this.lblMstValorTotal.Controls.Add(this.label6);
            this.lblMstValorTotal.Controls.Add(this.chkTeleentrega);
            this.lblMstValorTotal.Controls.Add(this.groupBox5);
            this.lblMstValorTotal.Controls.Add(this.groupBox4);
            this.lblMstValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstValorTotal.Location = new System.Drawing.Point(10, 202);
            this.lblMstValorTotal.Name = "lblMstValorTotal";
            this.lblMstValorTotal.Size = new System.Drawing.Size(1154, 382);
            this.lblMstValorTotal.TabIndex = 1;
            this.lblMstValorTotal.TabStop = false;
            this.lblMstValorTotal.Text = "Itens do Pedido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblMstNomeCliente);
            this.groupBox1.Controls.Add(this.btnAdicionarCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnEditarCliente);
            this.groupBox1.Controls.Add(this.btnBscCliente);
            this.groupBox1.Controls.Add(this.txtCodigoCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtContato);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1154, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificação do Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAlterarEndereco);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblMstCidade);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblMstBairro);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblMstComplemento);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblMstNumero);
            this.groupBox3.Controls.Add(this.lblRua);
            this.groupBox3.Controls.Add(this.lblMstRua);
            this.groupBox3.Location = new System.Drawing.Point(498, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(650, 168);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço:";
            // 
            // btnAlterarEndereco
            // 
            this.btnAlterarEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarEndereco.Image = global::InterfaceUsuario.Properties.Resources.adicionar;
            this.btnAlterarEndereco.Location = new System.Drawing.Point(6, 113);
            this.btnAlterarEndereco.Name = "btnAlterarEndereco";
            this.btnAlterarEndereco.Size = new System.Drawing.Size(23, 21);
            this.btnAlterarEndereco.TabIndex = 57;
            this.btnAlterarEndereco.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Alterar Endereço de Entrega";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(471, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Cidade:";
            // 
            // lblMstCidade
            // 
            this.lblMstCidade.BackColor = System.Drawing.SystemColors.Control;
            this.lblMstCidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstCidade.Location = new System.Drawing.Point(471, 82);
            this.lblMstCidade.Name = "lblMstCidade";
            this.lblMstCidade.Size = new System.Drawing.Size(168, 23);
            this.lblMstCidade.TabIndex = 54;
            this.lblMstCidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(334, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Bairro:";
            // 
            // lblMstBairro
            // 
            this.lblMstBairro.BackColor = System.Drawing.SystemColors.Control;
            this.lblMstBairro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstBairro.Location = new System.Drawing.Point(334, 83);
            this.lblMstBairro.Name = "lblMstBairro";
            this.lblMstBairro.Size = new System.Drawing.Size(132, 23);
            this.lblMstBairro.TabIndex = 52;
            this.lblMstBairro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Complemento:";
            // 
            // lblMstComplemento
            // 
            this.lblMstComplemento.BackColor = System.Drawing.SystemColors.Control;
            this.lblMstComplemento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstComplemento.Location = new System.Drawing.Point(6, 83);
            this.lblMstComplemento.Name = "lblMstComplemento";
            this.lblMstComplemento.Size = new System.Drawing.Size(322, 23);
            this.lblMstComplemento.TabIndex = 50;
            this.lblMstComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(548, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Número:";
            // 
            // lblMstNumero
            // 
            this.lblMstNumero.BackColor = System.Drawing.SystemColors.Control;
            this.lblMstNumero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstNumero.Location = new System.Drawing.Point(551, 36);
            this.lblMstNumero.Name = "lblMstNumero";
            this.lblMstNumero.Size = new System.Drawing.Size(88, 23);
            this.lblMstNumero.TabIndex = 48;
            this.lblMstNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(6, 23);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 47;
            this.lblRua.Text = "Rua:";
            // 
            // lblMstRua
            // 
            this.lblMstRua.BackColor = System.Drawing.SystemColors.Control;
            this.lblMstRua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstRua.Location = new System.Drawing.Point(6, 36);
            this.lblMstRua.Name = "lblMstRua";
            this.lblMstRua.Size = new System.Drawing.Size(539, 23);
            this.lblMstRua.TabIndex = 46;
            this.lblMstRua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nome:";
            // 
            // lblMstNomeCliente
            // 
            this.lblMstNomeCliente.BackColor = System.Drawing.SystemColors.Control;
            this.lblMstNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMstNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMstNomeCliente.Location = new System.Drawing.Point(6, 122);
            this.lblMstNomeCliente.Name = "lblMstNomeCliente";
            this.lblMstNomeCliente.Size = new System.Drawing.Size(489, 62);
            this.lblMstNomeCliente.TabIndex = 44;
            this.lblMstNomeCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCliente.Image = global::InterfaceUsuario.Properties.Resources.adicionar;
            this.btnAdicionarCliente.Location = new System.Drawing.Point(469, 82);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(23, 21);
            this.btnAdicionarCliente.TabIndex = 43;
            this.btnAdicionarCliente.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Adicionar";
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.Image = global::InterfaceUsuario.Properties.Resources.editar;
            this.btnEditarCliente.Location = new System.Drawing.Point(108, 78);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(23, 21);
            this.btnEditarCliente.TabIndex = 41;
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // btnBscCliente
            // 
            this.btnBscCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBscCliente.Image = global::InterfaceUsuario.Properties.Resources.busca;
            this.btnBscCliente.Location = new System.Drawing.Point(79, 78);
            this.btnBscCliente.Name = "btnBscCliente";
            this.btnBscCliente.Size = new System.Drawing.Size(23, 21);
            this.btnBscCliente.TabIndex = 40;
            this.btnBscCliente.UseVisualStyleBackColor = true;
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(6, 78);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(65, 20);
            this.txtCodigoCliente.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Contato:";
            // 
            // txtContato
            // 
            this.txtContato.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.Location = new System.Drawing.Point(9, 32);
            this.txtContato.Mask = "(00) 0 0000-0000";
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(93, 20);
            this.txtContato.TabIndex = 37;
            this.txtContato.Validating += new System.ComponentModel.CancelEventHandler(this.txtContato_Validating);
            // 
            // tbpAndamento
            // 
            this.tbpAndamento.Location = new System.Drawing.Point(4, 22);
            this.tbpAndamento.Name = "tbpAndamento";
            this.tbpAndamento.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAndamento.Size = new System.Drawing.Size(1172, 675);
            this.tbpAndamento.TabIndex = 1;
            this.tbpAndamento.Text = "Andamento";
            this.tbpAndamento.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelPizza);
            this.groupBox4.Controls.Add(this.btnAddPizza);
            this.groupBox4.Controls.Add(this.lvlListagemPedidosPizzas);
            this.groupBox4.Location = new System.Drawing.Point(8, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1140, 138);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pizzas";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDelAdicional);
            this.groupBox5.Controls.Add(this.btnAddAdicional);
            this.groupBox5.Controls.Add(this.lvlListagemPedidosAdicionais);
            this.groupBox5.Location = new System.Drawing.Point(8, 164);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1139, 138);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Adicionais";
            // 
            // lvlListagemPedidosPizzas
            // 
            this.lvlListagemPedidosPizzas.CheckBoxes = true;
            this.lvlListagemPedidosPizzas.FullRowSelect = true;
            this.lvlListagemPedidosPizzas.GridLines = true;
            this.lvlListagemPedidosPizzas.HideSelection = false;
            this.lvlListagemPedidosPizzas.Location = new System.Drawing.Point(6, 19);
            this.lvlListagemPedidosPizzas.Name = "lvlListagemPedidosPizzas";
            this.lvlListagemPedidosPizzas.Size = new System.Drawing.Size(1099, 113);
            this.lvlListagemPedidosPizzas.TabIndex = 0;
            this.lvlListagemPedidosPizzas.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPizza.Image = global::InterfaceUsuario.Properties.Resources.adicionar;
            this.btnAddPizza.Location = new System.Drawing.Point(1105, 19);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(35, 31);
            this.btnAddPizza.TabIndex = 44;
            this.btnAddPizza.UseVisualStyleBackColor = true;
            // 
            // btnDelPizza
            // 
            this.btnDelPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelPizza.Image = global::InterfaceUsuario.Properties.Resources.excluir;
            this.btnDelPizza.Location = new System.Drawing.Point(1105, 56);
            this.btnDelPizza.Name = "btnDelPizza";
            this.btnDelPizza.Size = new System.Drawing.Size(35, 31);
            this.btnDelPizza.TabIndex = 45;
            this.btnDelPizza.UseVisualStyleBackColor = true;
            // 
            // btnDelAdicional
            // 
            this.btnDelAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAdicional.Image = global::InterfaceUsuario.Properties.Resources.excluir;
            this.btnDelAdicional.Location = new System.Drawing.Point(1101, 53);
            this.btnDelAdicional.Name = "btnDelAdicional";
            this.btnDelAdicional.Size = new System.Drawing.Size(35, 31);
            this.btnDelAdicional.TabIndex = 48;
            this.btnDelAdicional.UseVisualStyleBackColor = true;
            // 
            // btnAddAdicional
            // 
            this.btnAddAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdicional.Image = global::InterfaceUsuario.Properties.Resources.adicionar;
            this.btnAddAdicional.Location = new System.Drawing.Point(1101, 16);
            this.btnAddAdicional.Name = "btnAddAdicional";
            this.btnAddAdicional.Size = new System.Drawing.Size(35, 31);
            this.btnAddAdicional.TabIndex = 47;
            this.btnAddAdicional.UseVisualStyleBackColor = true;
            // 
            // lvlListagemPedidosAdicionais
            // 
            this.lvlListagemPedidosAdicionais.CheckBoxes = true;
            this.lvlListagemPedidosAdicionais.FullRowSelect = true;
            this.lvlListagemPedidosAdicionais.GridLines = true;
            this.lvlListagemPedidosAdicionais.HideSelection = false;
            this.lvlListagemPedidosAdicionais.Location = new System.Drawing.Point(2, 16);
            this.lvlListagemPedidosAdicionais.Name = "lvlListagemPedidosAdicionais";
            this.lvlListagemPedidosAdicionais.Size = new System.Drawing.Size(1099, 113);
            this.lvlListagemPedidosAdicionais.TabIndex = 46;
            this.lvlListagemPedidosAdicionais.UseCompatibleStateImageBehavior = false;
            // 
            // chkTeleentrega
            // 
            this.chkTeleentrega.AutoSize = true;
            this.chkTeleentrega.Location = new System.Drawing.Point(8, 309);
            this.chkTeleentrega.Name = "chkTeleentrega";
            this.chkTeleentrega.Size = new System.Drawing.Size(98, 17);
            this.chkTeleentrega.TabIndex = 2;
            this.chkTeleentrega.Text = "Tele-entrega";
            this.chkTeleentrega.UseVisualStyleBackColor = true;
            // 
            // txtValorTeleentrega
            // 
            this.txtValorTeleentrega.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtValorTeleentrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTeleentrega.Location = new System.Drawing.Point(7, 353);
            this.txtValorTeleentrega.Name = "txtValorTeleentrega";
            this.txtValorTeleentrega.Size = new System.Drawing.Size(112, 20);
            this.txtValorTeleentrega.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Valor da Tele-entrega:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1023, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 23);
            this.label11.TabIndex = 49;
            this.label11.Text = "R$ 0,00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(883, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Valor Total do Pedido:";
            // 
            // FrmRotPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 701);
            this.Controls.Add(this.tbcPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRotPedidos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pedidos";
            this.tbcPedidos.ResumeLayout(false);
            this.tbpRegistro.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.lblMstValorTotal.ResumeLayout(false);
            this.lblMstValorTotal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPedidos;
        private System.Windows.Forms.TabPage tbpRegistro;
        private System.Windows.Forms.GroupBox lblMstValorTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tbpAndamento;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtContato;
        private System.Windows.Forms.Button btnAdicionarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnBscCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMstCidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMstBairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMstComplemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMstNumero;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblMstRua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMstNomeCliente;
        private System.Windows.Forms.Button btnAlterarEndereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDelAdicional;
        private System.Windows.Forms.Button btnAddAdicional;
        private System.Windows.Forms.ListView lvlListagemPedidosAdicionais;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDelPizza;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.ListView lvlListagemPedidosPizzas;
        private System.Windows.Forms.TextBox txtValorTeleentrega;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkTeleentrega;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}