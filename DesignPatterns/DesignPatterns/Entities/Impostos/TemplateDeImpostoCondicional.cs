using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public TemplateDeImpostoCondicional() : base() { }
        public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTransacao(orcamento);
            }
            return MinimaTaxacao(orcamento);
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTransacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);

    }
}
