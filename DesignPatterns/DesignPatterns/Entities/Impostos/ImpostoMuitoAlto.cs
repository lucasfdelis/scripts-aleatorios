using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto() : base() { }
        public ImpostoMuitoAlto(Imposto outroimposto) : base(outroimposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
        }
    }
}
