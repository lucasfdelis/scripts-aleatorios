using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities
{
    public class ISS : Imposto
    {
        public ISS() : base() { }
        public ISS(Imposto outroImposto): base(outroImposto) { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }
    }
}
