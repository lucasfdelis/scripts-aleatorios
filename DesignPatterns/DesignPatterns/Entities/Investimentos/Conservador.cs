using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.Investimentos
{
    public class Conservador : Estrategia
    {
        public double Investir(Conta conta)
        {
            return conta.Saldo * 0.08;
        }
    }
}
