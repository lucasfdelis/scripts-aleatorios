using System;

namespace DesignPatterns.Entities.BancoEstate
{
    public class Negativo : EstadoConta
    {
        public void Deposita(ContaBanco conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if(conta.Saldo > 0)
            {
                Positivar(conta);
            }
        }

        public void Saca(ContaBanco conta, double valor)
        {
            conta.Saldo -= valor;
        }

        public void Positivar(ContaBanco conta)
        {
            conta.estado = new Positivo();
        }

        public void Negativar(ContaBanco conta)
        {
            throw new Exception("A conta já está no negativo!");
        }

        
    }
}
