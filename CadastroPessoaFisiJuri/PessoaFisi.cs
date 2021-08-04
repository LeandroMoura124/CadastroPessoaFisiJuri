using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoaFisiJuri
{
    public class PessoaFisi : Pessoa
    {
        private string rg;

        public PessoaFisi()
        {
            this.rg = null;
        }
        public PessoaFisi(string nome, string endereco, string telefone, string rg)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Rg = rg;
        }



        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public override String ImprimirDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Nome, " ", this.Endereco, " ", this.Telefone, " ",  this.Rg, " ");
            return s;
        }
    }
}

    

