using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoaFisiJuri
{
    public class Funcionario : PessoaFisi
    {
        private string cartao;

        public Funcionario()
        {
            this.cartao = null;
        }
        public Funcionario(string nome, string endereco, string telefone, string rg, string cartao)
        {

            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Rg = rg;
            this.cartao = cartao;
        }

        public string Cartao
        {
            get { return cartao; }
            set { cartao = value; }
        }
        public override String ImprimirDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Nome, " ", this.Endereco, " ", this.Telefone, " ", this.Rg, " ", this.Cartao, " ");
            return s;
        }
    }
}
