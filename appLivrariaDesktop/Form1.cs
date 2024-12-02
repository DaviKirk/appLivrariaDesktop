namespace appLivrariaDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "admin";

            if (txt_usuario.Text == usuario && txt_senha.Text == senha) { 
                homeScreen formulario = new homeScreen();
                formulario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalido");
            }
        }
    }
}
