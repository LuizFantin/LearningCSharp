using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSimu.Contas
{
    public class ContaCorrente : Conta
    {
        public static int TaxaOperacao { get; private set; }
        public static int TotalContaCorrenteCriada { get; private set; }

        public ContaCorrente(int numero, int agencia) : base(agencia, numero)
        {
            TotalContaCorrenteCriada++;
            TaxaOperacao = 10 / TotalContaCorrenteCriada;
        }

        public override bool Depositar(double valor)
        {
            Saldo += valor;
            return true;
        }
        public override bool Sacar(double valor)
        {
            if (Saldo - TaxaOperacao - valor >= 0)
            {
                Saldo -= (valor + TaxaOperacao);
                return true;
            }
            return false;
        }
    }
}
