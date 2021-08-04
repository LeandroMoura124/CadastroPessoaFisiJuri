using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoaFisiJuri
{
     public class PessoaJuri : Pessoa
    {
        private string cnpj;
        public PessoaJuri()
        {
            this.cnpj = null;
        }
        public PessoaJuri(string nome, string endereco, string telefone, string cnpj)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.cnpj = cnpj;
        }
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public override String ImprimirDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Nome, " ", this.Endereco, " ", this.Telefone, " ", this.Cnpj, " ");
            return s;
        }
    }
    
}
