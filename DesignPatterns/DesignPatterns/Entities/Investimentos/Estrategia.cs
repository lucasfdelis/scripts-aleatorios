using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.Investimentos
{
    public interface Estrategia
    {
        double Investir(Conta conta);
    }
}
