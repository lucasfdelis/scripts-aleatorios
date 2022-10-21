using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.Descontos
{
    public class CalculadoraDeDescontos
    {
        public double Calcula(Compra compra)
        {
            Desconto d1 = new DescontoCincoItens();
            Desconto d2 = new DescontoValorMaiorCinquenta();
            Desconto d3 = new DescontoVendaCasada();
            Desconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Desconta(compra);
        }
        
    }
}
