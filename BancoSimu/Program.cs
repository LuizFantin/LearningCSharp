using BancoSimu.Contas;
using BancoSimu.Funcionarios;
using BancoSimu.Sistemas;
using System;
using System.Text.RegularExpressions;

namespace BancoSimu
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(23, 41);
            Console.WriteLine(conta.ToString());
            
            Console.ReadLine();
        }

        public static void TesteExpressaoRegular()
        {
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string frase = "meu telefone é 99999-0000";
            Console.WriteLine(Regex.IsMatch(frase, padrao));
            Match resultado = Regex.Match(frase, padrao);
            Console.WriteLine(resultado.Value);
        }

        public static void TesteString()
        {
            string url = "pagina?moeda1=real&moeda2=dolar";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);


            Console.WriteLine(extrator.Argumentos);
            Console.WriteLine(extrator.GetValor("moeda1"));
            Console.WriteLine(extrator.GetValor("moeda2"));
        }

        public static void TesteDatas()
        {
            DateTime data = new DateTime(2021, 01, 07, 10, 20, 30);
            TimeSpan time = TimeSpan.FromMinutes(120);
            Console.WriteLine(Humanizer.TimeSpanHumanizeExtensions.Humanize(time));
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
