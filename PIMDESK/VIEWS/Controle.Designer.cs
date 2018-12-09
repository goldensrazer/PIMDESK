using System;
using System.Windows.Forms;

namespace PIM.VIEWS
{
    partial class Controle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controle));
            this.btnSair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelDeControleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ChamadosPag = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.ListBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grau = new System.Windows.Forms.ListBox();
            this.Titulo = new System.Windows.Forms.ListBox();
            this.Descricao = new System.Windows.Forms.ListBox();
            this.Cliente = new System.Windows.Forms.ListBox();
            this.Funcionario = new System.Windows.Forms.ListBox();
            this.Conclusao = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Atbbtn = new System.Windows.Forms.Button();
            this.MeusChamados = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.MeuAtribuicao = new System.Windows.Forms.ListBox();
            this.MeuEmail = new System.Windows.Forms.ListBox();
            this.MeuDescricao = new System.Windows.Forms.ListBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.MeuTitulo = new System.Windows.Forms.ListBox();
            this.MeuGrau = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FuncionariosPag = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listEmail = new System.Windows.Forms.ListBox();
            this.listNome = new System.Windows.Forms.ListBox();
            this.listID = new System.Windows.Forms.ListBox();
            this.ClientesPag = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.listDepartamentoCliente = new System.Windows.Forms.ListBox();
            this.listEmailCliente = new System.Windows.Forms.ListBox();
            this.listNomeCliente = new System.Windows.Forms.ListBox();
            this.listIdCliente = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ContatosPag = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ChamadosPag.SuspendLayout();
            this.MeusChamados.SuspendLayout();
            this.FuncionariosPag.SuspendLayout();
            this.ClientesPag.SuspendLayout();
            this.ContatosPag.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(851, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(62, 24);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.contaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.painelDeControleToolStripMenuItem});
            this.contaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.contaToolStripMenuItem.Text = "Conta";
            this.contaToolStripMenuItem.Click += new System.EventHandler(this.contaToolStripMenuItem_Click);
            // 
            // painelDeControleToolStripMenuItem
            // 
            this.painelDeControleToolStripMenuItem.Name = "painelDeControleToolStripMenuItem";
            this.painelDeControleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.painelDeControleToolStripMenuItem.Text = "Painel de Controle";
            this.painelDeControleToolStripMenuItem.Click += new System.EventHandler(this.painelDeControleToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ChamadosPag);
            this.tabControl1.Controls.Add(this.MeusChamados);
            this.tabControl1.Controls.Add(this.FuncionariosPag);
            this.tabControl1.Controls.Add(this.ClientesPag);
            this.tabControl1.Controls.Add(this.ContatosPag);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(889, 416);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ChamadosPag
            // 
            this.ChamadosPag.BackColor = System.Drawing.Color.White;
            this.ChamadosPag.Controls.Add(this.button5);
            this.ChamadosPag.Controls.Add(this.label7);
            this.ChamadosPag.Controls.Add(this.ID);
            this.ChamadosPag.Controls.Add(this.txtID);
            this.ChamadosPag.Controls.Add(this.textBox2);
            this.ChamadosPag.Controls.Add(this.textBox1);
            this.ChamadosPag.Controls.Add(this.label6);
            this.ChamadosPag.Controls.Add(this.label5);
            this.ChamadosPag.Controls.Add(this.label4);
            this.ChamadosPag.Controls.Add(this.label3);
            this.ChamadosPag.Controls.Add(this.label2);
            this.ChamadosPag.Controls.Add(this.label1);
            this.ChamadosPag.Controls.Add(this.Grau);
            this.ChamadosPag.Controls.Add(this.Titulo);
            this.ChamadosPag.Controls.Add(this.Descricao);
            this.ChamadosPag.Controls.Add(this.Cliente);
            this.ChamadosPag.Controls.Add(this.Funcionario);
            this.ChamadosPag.Controls.Add(this.Conclusao);
            this.ChamadosPag.Controls.Add(this.comboBox1);
            this.ChamadosPag.Controls.Add(this.Atbbtn);
            this.ChamadosPag.ForeColor = System.Drawing.Color.Black;
            this.ChamadosPag.Location = new System.Drawing.Point(4, 22);
            this.ChamadosPag.Name = "ChamadosPag";
            this.ChamadosPag.Size = new System.Drawing.Size(881, 390);
            this.ChamadosPag.TabIndex = 2;
            this.ChamadosPag.Text = "Chamados";
            this.ChamadosPag.Click += new System.EventHandler(this.ChamadosPag_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(789, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 30);
            this.button5.TabIndex = 22;
            this.button5.Text = "Carregar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(3, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ID
            // 
            this.ID.FormattingEnabled = true;
            this.ID.Location = new System.Drawing.Point(0, 97);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(25, 290);
            this.ID.TabIndex = 20;
            this.ID.SelectedIndexChanged += new System.EventHandler(this.ID_SelectedIndexChanged_1);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(477, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(21, 20);
            this.txtID.TabIndex = 19;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(504, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(504, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(779, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(683, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "funcionario";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(593, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cliente";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(281, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descrição";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(129, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Titulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(28, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Grau";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Grau
            // 
            this.Grau.FormattingEnabled = true;
            this.Grau.Location = new System.Drawing.Point(31, 97);
            this.Grau.Name = "Grau";
            this.Grau.Size = new System.Drawing.Size(92, 290);
            this.Grau.TabIndex = 10;
            this.Grau.SelectedIndexChanged += new System.EventHandler(this.ID_SelectedIndexChanged_1);
            // 
            // Titulo
            // 
            this.Titulo.FormattingEnabled = true;
            this.Titulo.Location = new System.Drawing.Point(129, 97);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(146, 290);
            this.Titulo.TabIndex = 9;
            this.Titulo.SelectedIndexChanged += new System.EventHandler(this.ID_SelectedIndexChanged_1);
            // 
            // Descricao
            // 
            this.Descricao.FormattingEnabled = true;
            this.Descricao.Location = new System.Drawing.Point(281, 97);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(306, 290);
            this.Descricao.TabIndex = 8;
            this.Descricao.SelectedIndexChanged += new System.EventHandler(this.ID_SelectedIndexChanged_1);
            // 
            // Cliente
            // 
            this.Cliente.FormattingEnabled = true;
            this.Cliente.Location = new System.Drawing.Point(593, 97);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(84, 290);
            this.Cliente.TabIndex = 7;
            this.Cliente.SelectedIndexChanged += new System.EventHandler(this.ID_SelectedIndexChanged_1);
            // 
            // Funcionario
            // 
            this.Funcionario.FormattingEnabled = true;
            this.Funcionario.Location = new System.Drawing.Point(683, 97);
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.Size = new System.Drawing.Size(90, 290);
            this.Funcionario.TabIndex = 6;
            this.Funcionario.SelectedIndexChanged += new System.EventHandler(this.ID_SelectedIndexChanged_1);
            // 
            // Conclusao
            // 
            this.Conclusao.FormattingEnabled = true;
            this.Conclusao.Location = new System.Drawing.Point(779, 97);
            this.Conclusao.Name = "Conclusao";
            this.Conclusao.Size = new System.Drawing.Size(99, 290);
            this.Conclusao.TabIndex = 5;
            this.Conclusao.SelectedIndexChanged += new System.EventHandler(this.ID_SelectedIndexChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(650, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Estados";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Atbbtn
            // 
            this.Atbbtn.BackColor = System.Drawing.Color.Red;
            this.Atbbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atbbtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.Atbbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Atbbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Atbbtn.Location = new System.Drawing.Point(650, 39);
            this.Atbbtn.Name = "Atbbtn";
            this.Atbbtn.Size = new System.Drawing.Size(136, 30);
            this.Atbbtn.TabIndex = 3;
            this.Atbbtn.Text = "Atribuir Chamado";
            this.Atbbtn.UseVisualStyleBackColor = false;
            this.Atbbtn.Click += new System.EventHandler(this.Atbbtn_Click);
            // 
            // MeusChamados
            // 
            this.MeusChamados.Controls.Add(this.button1);
            this.MeusChamados.Controls.Add(this.label24);
            this.MeusChamados.Controls.Add(this.label23);
            this.MeusChamados.Controls.Add(this.label22);
            this.MeusChamados.Controls.Add(this.label21);
            this.MeusChamados.Controls.Add(this.label20);
            this.MeusChamados.Controls.Add(this.MeuAtribuicao);
            this.MeusChamados.Controls.Add(this.MeuEmail);
            this.MeusChamados.Controls.Add(this.MeuDescricao);
            this.MeusChamados.Controls.Add(this.btnAbrir);
            this.MeusChamados.Controls.Add(this.MeuTitulo);
            this.MeusChamados.Controls.Add(this.MeuGrau);
            this.MeusChamados.Controls.Add(this.label9);
            this.MeusChamados.Location = new System.Drawing.Point(4, 22);
            this.MeusChamados.Name = "MeusChamados";
            this.MeusChamados.Padding = new System.Windows.Forms.Padding(3);
            this.MeusChamados.Size = new System.Drawing.Size(881, 390);
            this.MeusChamados.TabIndex = 4;
            this.MeusChamados.Text = "Meus chamados";
            this.MeusChamados.UseVisualStyleBackColor = true;
            this.MeusChamados.Click += new System.EventHandler(this.MeusChamados_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(623, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Carregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label24.Location = new System.Drawing.Point(620, 53);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 17);
            this.label24.TabIndex = 12;
            this.label24.Text = "ATRIBUIÇÃO";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(477, 52);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(126, 17);
            this.label23.TabIndex = 11;
            this.label23.Text = "EMAIL DO CLIENTE";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label22.Location = new System.Drawing.Point(269, 52);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 17);
            this.label22.TabIndex = 10;
            this.label22.Text = "DESCRIÇÃO";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(141, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 17);
            this.label21.TabIndex = 9;
            this.label21.Text = "TITULO";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(3, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(132, 17);
            this.label20.TabIndex = 8;
            this.label20.Text = "GRAU DE URGENCIA";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // MeuAtribuicao
            // 
            this.MeuAtribuicao.FormattingEnabled = true;
            this.MeuAtribuicao.Location = new System.Drawing.Point(618, 73);
            this.MeuAtribuicao.Name = "MeuAtribuicao";
            this.MeuAtribuicao.Size = new System.Drawing.Size(120, 316);
            this.MeuAtribuicao.TabIndex = 7;
            this.MeuAtribuicao.SelectedIndexChanged += new System.EventHandler(this.MeuAtribuicao_SelectedIndexChanged);
            // 
            // MeuEmail
            // 
            this.MeuEmail.FormattingEnabled = true;
            this.MeuEmail.Location = new System.Drawing.Point(480, 72);
            this.MeuEmail.Name = "MeuEmail";
            this.MeuEmail.Size = new System.Drawing.Size(120, 316);
            this.MeuEmail.TabIndex = 6;
            this.MeuEmail.SelectedIndexChanged += new System.EventHandler(this.MeuEmail_SelectedIndexChanged);
            // 
            // MeuDescricao
            // 
            this.MeuDescricao.FormattingEnabled = true;
            this.MeuDescricao.Location = new System.Drawing.Point(272, 72);
            this.MeuDescricao.Name = "MeuDescricao";
            this.MeuDescricao.Size = new System.Drawing.Size(202, 316);
            this.MeuDescricao.TabIndex = 5;
            this.MeuDescricao.SelectedIndexChanged += new System.EventHandler(this.MeuDescricao_SelectedIndexChanged);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnAbrir.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAbrir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAbrir.Location = new System.Drawing.Point(711, 15);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(128, 32);
            this.btnAbrir.TabIndex = 4;
            this.btnAbrir.Text = "Abrir Chamado";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // MeuTitulo
            // 
            this.MeuTitulo.FormattingEnabled = true;
            this.MeuTitulo.Location = new System.Drawing.Point(146, 71);
            this.MeuTitulo.Name = "MeuTitulo";
            this.MeuTitulo.Size = new System.Drawing.Size(120, 316);
            this.MeuTitulo.TabIndex = 3;
            this.MeuTitulo.SelectedIndexChanged += new System.EventHandler(this.MeuTitulo_SelectedIndexChanged);
            // 
            // MeuGrau
            // 
            this.MeuGrau.FormattingEnabled = true;
            this.MeuGrau.Location = new System.Drawing.Point(6, 72);
            this.MeuGrau.Name = "MeuGrau";
            this.MeuGrau.Size = new System.Drawing.Size(120, 316);
            this.MeuGrau.TabIndex = 2;
            this.MeuGrau.SelectedIndexChanged += new System.EventHandler(this.MeuGrau_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(365, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Meus Chamdos";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // FuncionariosPag
            // 
            this.FuncionariosPag.Controls.Add(this.button3);
            this.FuncionariosPag.Controls.Add(this.btnCadastrarFuncionario);
            this.FuncionariosPag.Controls.Add(this.label13);
            this.FuncionariosPag.Controls.Add(this.label12);
            this.FuncionariosPag.Controls.Add(this.label11);
            this.FuncionariosPag.Controls.Add(this.label10);
            this.FuncionariosPag.Controls.Add(this.listEmail);
            this.FuncionariosPag.Controls.Add(this.listNome);
            this.FuncionariosPag.Controls.Add(this.listID);
            this.FuncionariosPag.Location = new System.Drawing.Point(4, 22);
            this.FuncionariosPag.Name = "FuncionariosPag";
            this.FuncionariosPag.Padding = new System.Windows.Forms.Padding(3);
            this.FuncionariosPag.Size = new System.Drawing.Size(881, 390);
            this.FuncionariosPag.TabIndex = 5;
            this.FuncionariosPag.Text = "funcionarios";
            this.FuncionariosPag.UseVisualStyleBackColor = true;
            this.FuncionariosPag.Click += new System.EventHandler(this.FuncionariosPag_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(626, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "Carregar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarFuncionario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(707, 89);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(156, 31);
            this.btnCadastrarFuncionario.TabIndex = 9;
            this.btnCadastrarFuncionario.Text = "Cadastrar Funcionario";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(393, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "EMAIL FUNCIONÁRIO";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(240, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "NOME FUNCIONÁRIO";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(128, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "ID FUNCIONÁRIO";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(358, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 36);
            this.label10.TabIndex = 4;
            this.label10.Text = "Funcionários";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // listEmail
            // 
            this.listEmail.FormattingEnabled = true;
            this.listEmail.Location = new System.Drawing.Point(396, 89);
            this.listEmail.Name = "listEmail";
            this.listEmail.Size = new System.Drawing.Size(213, 290);
            this.listEmail.TabIndex = 2;
            this.listEmail.SelectedIndexChanged += new System.EventHandler(this.listEmail_SelectedIndexChanged);
            // 
            // listNome
            // 
            this.listNome.FormattingEnabled = true;
            this.listNome.Location = new System.Drawing.Point(243, 89);
            this.listNome.Name = "listNome";
            this.listNome.Size = new System.Drawing.Size(147, 290);
            this.listNome.TabIndex = 1;
            this.listNome.SelectedIndexChanged += new System.EventHandler(this.listNome_SelectedIndexChanged);
            // 
            // listID
            // 
            this.listID.FormattingEnabled = true;
            this.listID.Location = new System.Drawing.Point(129, 89);
            this.listID.Name = "listID";
            this.listID.Size = new System.Drawing.Size(103, 290);
            this.listID.TabIndex = 0;
            this.listID.SelectedIndexChanged += new System.EventHandler(this.listID_SelectedIndexChanged);
            // 
            // ClientesPag
            // 
            this.ClientesPag.Controls.Add(this.button4);
            this.ClientesPag.Controls.Add(this.button2);
            this.ClientesPag.Controls.Add(this.label19);
            this.ClientesPag.Controls.Add(this.label18);
            this.ClientesPag.Controls.Add(this.label17);
            this.ClientesPag.Controls.Add(this.label16);
            this.ClientesPag.Controls.Add(this.listDepartamentoCliente);
            this.ClientesPag.Controls.Add(this.listEmailCliente);
            this.ClientesPag.Controls.Add(this.listNomeCliente);
            this.ClientesPag.Controls.Add(this.listIdCliente);
            this.ClientesPag.Controls.Add(this.label15);
            this.ClientesPag.Location = new System.Drawing.Point(4, 22);
            this.ClientesPag.Name = "ClientesPag";
            this.ClientesPag.Size = new System.Drawing.Size(881, 390);
            this.ClientesPag.TabIndex = 6;
            this.ClientesPag.Text = "Clientes";
            this.ClientesPag.UseVisualStyleBackColor = true;
            this.ClientesPag.Click += new System.EventHandler(this.ClientesPag_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(586, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 10;
            this.button4.Text = "Carregar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(667, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cadastrar Clientes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(590, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 16);
            this.label19.TabIndex = 8;
            this.label19.Text = "DEPARTAMENTO CLIENTE";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(401, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 16);
            this.label18.TabIndex = 7;
            this.label18.Text = "EMAIL CLIENTE";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(245, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 16);
            this.label17.TabIndex = 6;
            this.label17.Text = "NOME CLIENTE";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(129, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "ID CLIENTE";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // listDepartamentoCliente
            // 
            this.listDepartamentoCliente.FormattingEnabled = true;
            this.listDepartamentoCliente.Location = new System.Drawing.Point(593, 87);
            this.listDepartamentoCliente.Name = "listDepartamentoCliente";
            this.listDepartamentoCliente.Size = new System.Drawing.Size(163, 290);
            this.listDepartamentoCliente.TabIndex = 4;
            this.listDepartamentoCliente.SelectedIndexChanged += new System.EventHandler(this.listDepartamentoCliente_SelectedIndexChanged);
            // 
            // listEmailCliente
            // 
            this.listEmailCliente.FormattingEnabled = true;
            this.listEmailCliente.Location = new System.Drawing.Point(401, 87);
            this.listEmailCliente.Name = "listEmailCliente";
            this.listEmailCliente.Size = new System.Drawing.Size(186, 290);
            this.listEmailCliente.TabIndex = 3;
            this.listEmailCliente.SelectedIndexChanged += new System.EventHandler(this.listEmailCliente_SelectedIndexChanged);
            // 
            // listNomeCliente
            // 
            this.listNomeCliente.FormattingEnabled = true;
            this.listNomeCliente.Location = new System.Drawing.Point(248, 87);
            this.listNomeCliente.Name = "listNomeCliente";
            this.listNomeCliente.Size = new System.Drawing.Size(147, 290);
            this.listNomeCliente.TabIndex = 2;
            this.listNomeCliente.SelectedIndexChanged += new System.EventHandler(this.listNomeCliente_SelectedIndexChanged);
            // 
            // listIdCliente
            // 
            this.listIdCliente.FormattingEnabled = true;
            this.listIdCliente.Location = new System.Drawing.Point(132, 87);
            this.listIdCliente.Name = "listIdCliente";
            this.listIdCliente.Size = new System.Drawing.Size(110, 290);
            this.listIdCliente.TabIndex = 1;
            this.listIdCliente.SelectedIndexChanged += new System.EventHandler(this.listIdCliente_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(369, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 36);
            this.label15.TabIndex = 0;
            this.label15.Text = "Clientes";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // ContatosPag
            // 
            this.ContatosPag.Controls.Add(this.label29);
            this.ContatosPag.Controls.Add(this.label28);
            this.ContatosPag.Controls.Add(this.label27);
            this.ContatosPag.Controls.Add(this.label26);
            this.ContatosPag.Controls.Add(this.label25);
            this.ContatosPag.Controls.Add(this.label14);
            this.ContatosPag.Location = new System.Drawing.Point(4, 22);
            this.ContatosPag.Name = "ContatosPag";
            this.ContatosPag.Size = new System.Drawing.Size(881, 390);
            this.ContatosPag.TabIndex = 3;
            this.ContatosPag.Text = "Contato";
            this.ContatosPag.UseVisualStyleBackColor = true;
            this.ContatosPag.Click += new System.EventHandler(this.ContatosPag_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label29.Location = new System.Drawing.Point(308, 256);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(198, 26);
            this.label29.TabIndex = 5;
            this.label29.Text = "PIM@hdesk.com.br";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label28.Location = new System.Drawing.Point(360, 221);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 26);
            this.label28.TabIndex = 4;
            this.label28.Text = "Contato";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label27.Location = new System.Drawing.Point(370, 153);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(64, 26);
            this.label27.TabIndex = 3;
            this.label27.Text = "Ligue";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label26.Location = new System.Drawing.Point(282, 179);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(254, 26);
            this.label26.TabIndex = 2;
            this.label26.Text = "Telefone: (13) 4009-2000";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label25.Location = new System.Drawing.Point(90, 107);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(686, 26);
            this.label25.TabIndex = 1;
            this.label25.Text = "Endereço: Av. Francisco Manoel - Vila Mathias, Santos - SP, 11045-300";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(356, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 26);
            this.label14.TabIndex = 0;
            this.label14.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(575, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(913, 455);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Controle";
            this.Text = "Controle";
            this.Load += new System.EventHandler(this.Controle_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ChamadosPag.ResumeLayout(false);
            this.ChamadosPag.PerformLayout();
            this.MeusChamados.ResumeLayout(false);
            this.MeusChamados.PerformLayout();
            this.FuncionariosPag.ResumeLayout(false);
            this.FuncionariosPag.PerformLayout();
            this.ClientesPag.ResumeLayout(false);
            this.ClientesPag.PerformLayout();
            this.ContatosPag.ResumeLayout(false);
            this.ContatosPag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            l.HorizontalScrollbar = true;
            if (l.SelectedIndex != -1)
            {
                ID.SelectedIndex = l.SelectedIndex;
                Grau.SelectedIndex = l.SelectedIndex;
                Titulo.SelectedIndex = l.SelectedIndex;
                Descricao.SelectedIndex = l.SelectedIndex;
                Cliente.SelectedIndex = l.SelectedIndex;
                Funcionario.SelectedIndex = l.SelectedIndex;
                Conclusao.SelectedIndex = l.SelectedIndex;

                textBox1.Text = Titulo.SelectedItem.ToString();
                textBox2.Text = Conclusao.SelectedItem.ToString();
                txtID.Text = ID.SelectedItem.ToString();

            }
        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem painelDeControleToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ChamadosPag;
        private System.Windows.Forms.TabPage ContatosPag;
        private System.Windows.Forms.Button Atbbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox Conclusao;
        private System.Windows.Forms.ListBox Funcionario;
        private System.Windows.Forms.ListBox Titulo;
        private System.Windows.Forms.ListBox Descricao;
        private System.Windows.Forms.ListBox Cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ID;
        private Label label8;
        private TabPage MeusChamados;
        private Label label9;
        private TabPage FuncionariosPag;
        private ListBox MeuTitulo;
        private ListBox MeuGrau;
        private Button btnAbrir;
        private TabPage ClientesPag;
        private ListBox listID;
        private ListBox listEmail;
        private ListBox listNome;
        private Label label10;
        private Label label13;
        private Label label12;
        private Label label11;
        private ListBox listIdCliente;
        private Label label15;
        private ListBox listDepartamentoCliente;
        private ListBox listEmailCliente;
        private ListBox listNomeCliente;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Button btnCadastrarFuncionario;
        private Button button2;
        private ListBox MeuAtribuicao;
        private ListBox MeuEmail;
        private ListBox MeuDescricao;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private ListBox Grau;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label14;
    }
}