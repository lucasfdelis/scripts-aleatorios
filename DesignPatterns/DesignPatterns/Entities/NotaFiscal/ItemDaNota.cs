using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.NotaFiscal
{
    public class ItemDaNota
    {
        public String Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

    }
}
