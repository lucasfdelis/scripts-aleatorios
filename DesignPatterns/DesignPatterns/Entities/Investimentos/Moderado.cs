using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.Investimentos
{
    public class Moderado : Estrategia
    {
        public double Investir(Conta conta)
        {
            Random random = new Random();
            int chance = random.Next(10);

            if(chance < 5)
            {
                return conta.Saldo * 0.25;
            }
            else
            {
                return conta.Saldo * 0.07;
            }
        }
    }
}
