using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroPessoaFisiJuri
{
    public abstract class Pessoa
    {
       public string nome, endereco, telefone;
       


        //Construtor sem parâmetro

        public Pessoa()
        {
            this.nome = null;
            this.endereco = null;
            this.telefone = null;
        }

        //Construtor com parâmetro

        public Pessoa(string nome, string endereco, string telefone)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        //Imprimir dados MÉTODO
        public abstract String ImprimirDados();
       

    }
}
