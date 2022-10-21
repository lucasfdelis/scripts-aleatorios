using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public IHIT() : base() { }
        public IHIT(Imposto outroImposto) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 1000 && TemItensComMesmoNomeNo(orcamento);
        }

        protected override double MaximaTransacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100 + CalculoDoOutroImposto(orcamento);
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01 * orcamento.Itens.Count + CalculoDoOutroImposto(orcamento);
        }

        private bool TemItensComMesmoNomeNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                foreach (Item item2 in orcamento.Itens)
                {
                    if(item.Valor == item2.Valor && item.Nome == item2.Nome)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
