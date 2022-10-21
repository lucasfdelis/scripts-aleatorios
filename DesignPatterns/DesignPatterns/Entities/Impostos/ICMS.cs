using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities
{
    public class ICMS : Imposto
    {
        public ICMS() : base() { }
        public ICMS(Imposto outroImposto) : base(outroImposto) { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + 50 + CalculoDoOutroImposto(orcamento);
        }
    }
}
