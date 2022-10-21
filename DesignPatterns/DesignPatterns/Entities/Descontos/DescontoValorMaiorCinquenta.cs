using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.Descontos
{
    public class DescontoValorMaiorCinquenta : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Compra compra)
        {
            if(compra.Valor > 50)
            {
                return compra.Valor * 0.07;
            }
            else
            {
                return Proximo.Desconta(compra);
            }
        }
    }
}
