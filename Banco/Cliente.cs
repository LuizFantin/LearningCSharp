using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class Cliente
    {
        public string nome;
        public string profissao;
        public string Cpf { get; set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            this.nome = nome;
            this.Cpf = cpf;
            this.profissao = profissao;
        }



    }
}
