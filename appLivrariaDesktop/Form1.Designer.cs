namespace appLivrariaDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txt_usuario = new TextBox();
            btnAcessar = new Button();
            txt_senha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(529, 168);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(262, 23);
            txt_usuario.TabIndex = 0;
            txt_usuario.TextChanged += textBox1_TextChanged;
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = Color.FromArgb(18, 48, 147);
            btnAcessar.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcessar.ForeColor = Color.White;
            btnAcessar.Location = new Point(529, 297);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(262, 43);
            btnAcessar.TabIndex = 2;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = false;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(529, 232);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(262, 23);
            txt_senha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(91, 138, 255);
            label1.ForeColor = Color.White;
            label1.Location = new Point(529, 214);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(91, 138, 255);
            label2.ForeColor = Color.White;
            label2.Location = new Point(529, 150);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(91, 138, 255);
            label3.ForeColor = Color.White;
            label3.Location = new Point(708, 552);
            label3.Name = "label3";
            label3.Size = new Size(215, 15);
            label3.TabIndex = 6;
            label3.Text = "Login -> usuario: admin ; senha: admin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(935, 576);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_senha);
            Controls.Add(btnAcessar);
            Controls.Add(txt_usuario);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_usuario;
        private Button btnAcessar;
        private TextBox txt_senha;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
