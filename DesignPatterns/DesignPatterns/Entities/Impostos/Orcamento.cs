

using System.Collections.Generic;

namespace DesignPatterns.Entities
{
    public class Orcamento
    {
        public double Valor { get;  set; }
        public List<Item> Itens { get; private set; }


        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }


        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
