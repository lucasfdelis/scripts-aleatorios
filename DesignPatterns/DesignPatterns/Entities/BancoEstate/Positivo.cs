using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.BancoEstate
{
    public class Positivo : EstadoConta
    {
        public void Deposita(ContaBanco conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Saca(ContaBanco conta, double valor)
        {
            conta.Saldo -= valor;
            if(conta.Saldo < 0)
            {
                Negativar(conta);
            }
        }

        public void Positivar(ContaBanco conta)
        {
            throw new Exception("A conta já está no positivo!");
        }

        public void Negativar(ContaBanco conta)
        {
            conta.estado = new Negativo();
        }
    }
}
