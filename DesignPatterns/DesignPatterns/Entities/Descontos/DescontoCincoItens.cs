using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.Descontos
{
    public  class DescontoCincoItens : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Compra compra)
        {
            if(compra.Itens.Count > 5)
            {
                return compra.Valor * 0.1;
            }

            return Proximo.Desconta(compra);
        }
    }
}
