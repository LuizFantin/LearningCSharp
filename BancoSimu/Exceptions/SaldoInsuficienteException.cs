using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSimu.Exceptions
{
    class SaldoInsuficienteException : Exception
    {
        public double Saldo { get;}
        public double Saque { get;}

        public SaldoInsuficienteException(double saldo, double saque)
            : this("Saldo insuficiente para realizar o saque de " + saque)
        {
            Saldo = saldo;
            Saque = saque;
        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
    }
}
