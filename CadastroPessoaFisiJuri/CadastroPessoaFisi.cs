using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroPessoaFisiJuri
{
    public partial class Form2 : Form
    {
        PessoaFisi pessoafisi;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CadastroPessFisiJuri = new Form1();
            CadastroPessFisiJuri.Show();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            pessoafisi = new PessoaFisi(txtNome.Text, txtEndereco.Text, txtTelefone.Text, txtRg.Text);
            {
               txtNome.Clear();
               txtEndereco.Clear();
               txtTelefone.Clear();
               txtRg.Clear();

            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pessoafisi.ImprimirDados());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtRg.Clear();
        }

        private void btnFuncio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form CadastroFuncionario = new Form4();
            CadastroFuncionario.Show();
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
