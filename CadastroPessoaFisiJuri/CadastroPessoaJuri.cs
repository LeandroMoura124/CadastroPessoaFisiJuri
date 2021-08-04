using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroPessoaFisiJuri
{
    public partial class Form3 : Form
    {
        PessoaJuri pessoaJuri;
        public Form3()
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
            pessoaJuri = new PessoaJuri(txtNome.Text, txtEndereco.Text, txtTelefone.Text, txtCnpj.Text);
            {
                txtNome.Clear();
                txtEndereco.Clear();
                txtTelefone.Clear();
                txtCnpj.Clear();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pessoaJuri.ImprimirDados());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtCnpj.Clear();
        }

        private void btnFuncio_Click(object sender, EventArgs e)
        {
         
        }

        private void lblCnpj_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
