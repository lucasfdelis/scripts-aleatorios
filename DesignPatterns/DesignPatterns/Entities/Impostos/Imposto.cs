using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities
{
    public abstract class Imposto
    { 
        public Imposto OutroImposto { get; set; }
        public abstract double Calcula(Orcamento orcamento);
        
        public Imposto()
        {
            OutroImposto = null;
        }
        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if(OutroImposto == null)
            {
                return 0;
            }
            return OutroImposto.Calcula(orcamento);
        }
    }
}
