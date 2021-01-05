using BancoSimu.Contas;
using BancoSimu.Funcionarios;
using BancoSimu.Sistemas;
using System;

namespace BancoSimu
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04")
            {
                Nome = "Roberta",
                Senha = "123"
            };

            sistemaInterno.Logar(roberta, "123");
        }
    }
}
