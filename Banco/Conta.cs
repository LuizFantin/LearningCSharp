using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class Conta
    {
        public static int TotalDeContasCriadas { get; set; }

        public Cliente titular;
        public int agencia;
        public int numero;
        public double Saldo { get; set; }

        public Conta(Cliente titular, int agencia, int numero, double saldo)
        {
            this.titular = titular;
            this.agencia = agencia;
            this.numero = numero;
            Saldo = saldo;
        }

      

        public bool Sacar(double valor)
        {
            Saldo -= valor;
            return true;
        }
    }
}
