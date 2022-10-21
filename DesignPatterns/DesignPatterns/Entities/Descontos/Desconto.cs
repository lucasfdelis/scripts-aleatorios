using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.Descontos
{
    public interface Desconto
    {
        double Desconta(Compra compra);
        Desconto Proximo { get; set; }
    }
}
