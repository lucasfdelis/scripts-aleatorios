using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.Investimentos
{
    public class RealizadorDeInvestimentos
    {
        public void Realiza(Conta conta, Estrategia estrategia)
        {
            double result = estrategia.Investir(conta);

            conta.deposita(result);
            Console.WriteLine(conta.Saldo);
        }
    }
}
