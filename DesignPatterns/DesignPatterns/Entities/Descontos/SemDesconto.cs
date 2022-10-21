using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.Descontos
{
    public class SemDesconto : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Compra compra)
        {
            return 0;
        }
    }
}
