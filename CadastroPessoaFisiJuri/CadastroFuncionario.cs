using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroPessoaFisiJuri
{
    public partial class Form4 : Form
    {
        Funcionario funcionario;
        public Form4()
        {
            InitializeComponent();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtRg.Clear();
            txtCartao.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CadastroPessoaFisi = new Form2();
            CadastroPessoaFisi.Show();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            funcionario = new Funcionario(txtNome.Text, txtEndereco.Text, txtTelefone.Text, txtRg.Text, txtCartao.Text);
            {
                txtNome.Clear();
                txtEndereco.Clear();
                txtTelefone.Clear();
                txtRg.Clear();
                txtCartao.Clear();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(funcionario.ImprimirDados());
        }
    }
}
