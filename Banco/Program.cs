using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta
            (
                new Cliente("Luiz", "143.432.434.34", "Desenvolvedor Júnior"),
                1,
                1,
                120.5
            );

            Console.WriteLine(conta.Sacar(100.0));
            Console.WriteLine(conta.Saldo);


        }
    }
}
