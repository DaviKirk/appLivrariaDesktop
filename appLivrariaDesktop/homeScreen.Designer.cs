namespace appLivrariaDesktop
{
    partial class homeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeScreen));
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
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSair, toolStripSplitButton1, toolStripSplitButton2, toolStripSplitButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(937, 25);
            toolStrip1.TabIndex = 0;
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
            btnVenda.Size = new Size(180, 22);
            btnVenda.Text = "Venda";
            btnVenda.Click += btnVenda_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(180, 22);
            btnEstoque.Text = "Estoque";
            btnEstoque.Click += btnEstoque_Click;
            // 
            // btnCadastrarLivro
            // 
            btnCadastrarLivro.Name = "btnCadastrarLivro";
            btnCadastrarLivro.Size = new Size(180, 22);
            btnCadastrarLivro.Text = "Cadastrar livro";
            btnCadastrarLivro.Click += btnCadastrarLivro_Click;
            // 
            // btnCadastrarAutor
            // 
            btnCadastrarAutor.Name = "btnCadastrarAutor";
            btnCadastrarAutor.Size = new Size(180, 22);
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
            btnCadastrarCliente.Size = new Size(164, 22);
            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // btnTelaConsulta
            // 
            btnTelaConsulta.Name = "btnTelaConsulta";
            btnTelaConsulta.Size = new Size(164, 22);
            btnTelaConsulta.Text = "Consultar";
            btnTelaConsulta.Click += btnTelaConsulta_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(32, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 198);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(16, 155);
            label8.Name = "label8";
            label8.Size = new Size(132, 21);
            label8.TabIndex = 18;
            label8.Text = "Data do pedido:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(16, 114);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 17;
            label7.Text = "Numero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(16, 69);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 16;
            label6.Text = "CPF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 30);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 15;
            label5.Text = "Nome:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(498, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(413, 198);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 51);
            label1.Name = "label1";
            label1.Size = new Size(185, 21);
            label1.TabIndex = 3;
            label1.Text = "Informações do cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(626, 51);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 4;
            label2.Text = "Livros solicitados";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 288);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 23);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(346, 288);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 6;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(309, 336);
            button4.Name = "button4";
            button4.Size = new Size(121, 23);
            button4.TabIndex = 9;
            button4.Text = "Hoje";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(32, 336);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 10;
            button2.Text = "Mais recente";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(172, 336);
            button3.Name = "button3";
            button3.Size = new Size(121, 23);
            button3.TabIndex = 11;
            button3.Text = "Mais antigo";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(181, 312);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 12;
            label3.Text = "Ordenar Por:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(32, 384);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(879, 219);
            dataGridView2.TabIndex = 13;
            // 
            // homeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(91, 138, 255);
            ClientSize = new Size(937, 628);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "homeScreen";
            Text = "Home";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button4;
        private Button button2;
        private Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dataGridView2;
    }
}