using BancoSimu.Exceptions;
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

        public override void Depositar(double valor)
        {
            Saldo += valor;
        }
        public override void Sacar(double valor)
        {
            if (valor <= 0)
                throw new ArgumentException("O valor do saque deve ser maior que zero", nameof(valor));

            if (Saldo - TaxaOperacao - valor < 0)
                throw new SaldoInsuficienteException(Saldo, valor);

            Saldo -= (valor + TaxaOperacao);
        }
    }
}
