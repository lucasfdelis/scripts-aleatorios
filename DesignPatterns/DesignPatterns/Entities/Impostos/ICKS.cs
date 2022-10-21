using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities
{
    public class ICKS : TemplateDeImpostoCondicional
    {
        public ICKS() : base() { }
        public ICKS(Imposto outroImposto) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 1000 && TemItemMaiorQue100ReaisNo(orcamento);
        }

        protected override double MaximaTransacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.08 + CalculoDoOutroImposto(orcamento);
        }

        private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }
            }
            return false;
        }
        }
    }
