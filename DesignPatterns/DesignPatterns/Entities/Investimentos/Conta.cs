using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.Investimentos
{
    public class Conta
    {
        public double Saldo { get; private set; }

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}
