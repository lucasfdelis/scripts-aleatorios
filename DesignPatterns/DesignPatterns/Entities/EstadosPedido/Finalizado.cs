using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.EstadosPedido
{
    public class Finalizado : EstadoDePedido
    {
        public void AplicaDescontoExtra(Pedido pedido )
        {
            throw new Exception("Orcamento Finalizado não possui desconto extra");
        }

        public void Aprova(Pedido pedido)
        {
            throw new Exception("O estado do pedido já foi finalizado");
        }

        public void Reprova(Pedido pedido)
        {
            throw new Exception("O estado do pedido já foi finalizado");
        }

        public void Finaliza(Pedido pedido)
        {
            throw new Exception("O estado do pedido já foi finalizado");
        }
    }
}
