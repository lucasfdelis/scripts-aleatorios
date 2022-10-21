using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities
{
    public class CalculadorDeImposto
    {
        public double Calcula(Orcamento orcamento, Imposto estrategiaDeImposto)
        {
            return estrategiaDeImposto.Calcula(orcamento);
        }
    }
}
