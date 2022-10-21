using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.Descontos
{
    public class Compra
    { 
        public double Valor { get; private set; }
        public List<Item> Itens { get; private set; }
        
        public Compra()
        {
            Valor = 0;
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
            Valor += item.Valor;
        }

    }


}
