using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSimu.Contas
{
    public abstract class Conta
    {
        public int Agencia { get; protected set; }
        public int Numero { get; protected set; }
        public double Saldo { get; protected set; }

        protected Conta(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
        }

        public abstract bool Sacar(double valor);
        public abstract bool Depositar(double valor);
    }
}
