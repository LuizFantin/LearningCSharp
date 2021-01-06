using System;
using System.Collections.Generic;
using System.Text;

namespace BancoSimu.Contas
{
    public abstract class Conta
    {
        public int Agencia { get;}
        public int Numero { get;}
        public double Saldo { get; protected set; }

        protected Conta(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
        }

        public abstract void Sacar(double valor);
        public abstract void Depositar(double valor);
    }
}
