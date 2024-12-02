namespace appLivrariaDesktop
{
    partial class EstoqueScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstoqueScreen));
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnSair = new ToolStripLabel();
            toolStripSplitButton1 = new ToolStripSplitButton();
            btnVenda = new ToolStripMenuItem();
            btnEstoque = new ToolStripMenuItem();
            btnCadastrarLivro = new ToolStripMenuItem();
            btnCadastrarAutor = new ToolStripMenuItem();
            toolStripSplitButton2 = new ToolStripSplitButton();
            btnCadastrarFuncionario = new ToolStripMenuItem();
            toolStripSplitButton3 = new ToolStripSplitButton();
            btnCadastrarCliente = new ToolStripMenuItem();
            btnTelaConsulta = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 36);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 4;
            label1.Text = "Consultra Livros:";
            // 
            // button1
            // 
            button1.Location = new Point(375, 69);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 8;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 23);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(665, 45);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 16;
            label3.Text = "Ordenar Por:";
            // 
            // button3
            // 
            button3.Location = new Point(653, 69);
            button3.Name = "button3";
            button3.Size = new Size(121, 23);
            button3.TabIndex = 15;
            button3.Text = "Mais antigo";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(513, 69);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 14;
            button2.Text = "Mais recente";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(790, 69);
            button4.Name = "button4";
            button4.Size = new Size(121, 23);
            button4.TabIndex = 13;
            button4.Text = "Hoje";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(885, 490);
            dataGridView1.TabIndex = 17;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSair, toolStripSplitButton1, toolStripSplitButton2, toolStripSplitButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(937, 25);
            toolStrip1.TabIndex = 18;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(39, 22);
            btnSair.Text = "Sair";
            btnSair.Click += btnSair_Click;
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { btnVenda, btnEstoque, btnCadastrarLivro, btnCadastrarAutor });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(32, 22);
            toolStripSplitButton1.Text = "Area Livro";
            // 
            // btnVenda
            // 
            btnVenda.Name = "btnVenda";
            btnVenda.Size = new Size(155, 22);
            btnVenda.Text = "Venda";
            btnVenda.Click += btnVenda_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(155, 22);
            btnEstoque.Text = "Estoque";
            btnEstoque.Click += btnEstoque_Click;
            // 
            // btnCadastrarLivro
            // 
            btnCadastrarLivro.Name = "btnCadastrarLivro";
            btnCadastrarLivro.Size = new Size(155, 22);
            btnCadastrarLivro.Text = "Cadastrar livro";
            btnCadastrarLivro.Click += btnCadastrarLivro_Click;
            // 
            // btnCadastrarAutor
            // 
            btnCadastrarAutor.Name = "btnCadastrarAutor";
            btnCadastrarAutor.Size = new Size(155, 22);
            btnCadastrarAutor.Text = "Cadastrar autor";
            btnCadastrarAutor.Click += btnCadastrarAutor_Click;
            // 
            // toolStripSplitButton2
            // 
            toolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton2.DropDownItems.AddRange(new ToolStripItem[] { btnCadastrarFuncionario });
            toolStripSplitButton2.Image = (Image)resources.GetObject("toolStripSplitButton2.Image");
            toolStripSplitButton2.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton2.Name = "toolStripSplitButton2";
            toolStripSplitButton2.Size = new Size(32, 22);
            toolStripSplitButton2.Text = "Area funcionario";
            // 
            // btnCadastrarFuncionario
            // 
            btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            btnCadastrarFuncionario.Size = new Size(190, 22);
            btnCadastrarFuncionario.Text = "Cadastrar Funcionario";
            btnCadastrarFuncionario.Click += btnCadastrarFuncionario_Click;
            // 
            // toolStripSplitButton3
            // 
            toolStripSplitButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton3.DropDownItems.AddRange(new ToolStripItem[] { btnCadastrarCliente, btnTelaConsulta });
            toolStripSplitButton3.Image = (Image)resources.GetObject("toolStripSplitButton3.Image");
            toolStripSplitButton3.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton3.Name = "toolStripSplitButton3";
            toolStripSplitButton3.Size = new Size(32, 22);
            toolStripSplitButton3.Text = "Area Cliente";
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(180, 22);
            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // btnTelaConsulta
            // 
            btnTelaConsulta.Name = "btnTelaConsulta";
            btnTelaConsulta.Size = new Size(180, 22);
            btnTelaConsulta.Text = "Consultar";
            btnTelaConsulta.Click += btnTelaConsulta_Click;
            // 
            // EstoqueScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(91, 138, 255);
            ClientSize = new Size(937, 628);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EstoqueScreen";
            Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Button button3;
        private Button button2;
        private Button button4;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripLabel btnSair;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem btnVenda;
        private ToolStripMenuItem btnEstoque;
        private ToolStripMenuItem btnCadastrarLivro;
        private ToolStripMenuItem btnCadastrarAutor;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripMenuItem btnCadastrarFuncionario;
        private ToolStripSplitButton toolStripSplitButton3;
        private ToolStripMenuItem btnCadastrarCliente;
        private ToolStripMenuItem btnTelaConsulta;
    }
}