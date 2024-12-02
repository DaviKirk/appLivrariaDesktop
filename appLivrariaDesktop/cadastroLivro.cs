using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appLivrariaDesktop
{
    public partial class cadastroLivro : Form
    {
        public cadastroLivro()
        {
            InitializeComponent();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Exemplo Projeto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            homeScreen formulario = new homeScreen();
            formulario.Show();
            this.Hide();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            EstoqueScreen formulario = new EstoqueScreen();
            formulario.Show();
            this.Hide();
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            cadastroLivro formulario = new cadastroLivro();
            formulario.Show();
            this.Hide();
        }

        private void btnCadastrarAutor_Click(object sender, EventArgs e)
        {
            cadastroAutor formulario = new cadastroAutor();
            formulario.Show();
            this.Hide();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            cadastroFuncionario formulario = new cadastroFuncionario();
            formulario.Show();
            this.Hide();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            cadastroCliente formulario = new cadastroCliente();
            formulario.Show();
            this.Hide();
        }

        private void btnTelaConsulta_Click(object sender, EventArgs e)
        {
            clienteScreen formulario = new clienteScreen();
            formulario.Show();
            this.Hide();
        }
    }
}
