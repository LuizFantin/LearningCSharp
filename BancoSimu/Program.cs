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
            DateTime data = new DateTime(2021,01,07,10,20,30);
            TimeSpan time = TimeSpan.FromMinutes(120);
            Console.WriteLine(Humanizer.TimeSpanHumanizeExtensions.Humanize(time));
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
