using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.EstadosPedido
{
    public class Reprovado : EstadoDePedido
    {
        public void AplicaDescontoExtra(Pedido pedido)
        {
            throw new Exception("Orcamento Reprovado não possui desconto extra");
        }
        public void Aprova(Pedido pedido)
        {
            throw new Exception("O estado do pedido já foi reprovado!");
        }

        public void Reprova(Pedido pedido)
        {
            throw new Exception("O pedido já foi reprovado!");
        }

        public void Finaliza(Pedido pedido)
        {
            pedido.estado = new Finalizado();
        }
    }
}
