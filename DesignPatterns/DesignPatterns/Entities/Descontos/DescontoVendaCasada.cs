using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.Descontos
{
    public class DescontoVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Compra compra)
        {
            if (AconteceuVendaCasadaEm(compra))
            {
                return compra.Valor * 0.05;
            }

            return Proximo.Desconta(compra);
        }

        private bool AconteceuVendaCasadaEm(Compra compra)
        {
            return existe("CANETA", compra) && existe("LAPIS", compra);
        }

        private bool existe(string produto, Compra compra)
        {
            foreach(Item item in compra.Itens)
            {
                if(item.Nome == produto)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
