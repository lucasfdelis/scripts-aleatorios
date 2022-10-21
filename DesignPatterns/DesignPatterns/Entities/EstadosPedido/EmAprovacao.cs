using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.EstadosPedido
{
    public class EmAprovacao : EstadoDePedido
    {
        public void AplicaDescontoExtra(Pedido pedido)
        {
            if (pedido.DescontoFoiAplicado)
            {
                throw new Exception("Já foi aplicado um desconto neste pedido!");
            }
            pedido.Valor = pedido.Valor -= pedido.Valor * 0.05;
            pedido.DescontoFoiAplicado = true;
        }

        public void Aprova(Pedido pedido)
        {
            pedido.estado = new Aprovado();
        }

        public void Reprova(Pedido pedido)
        {
            pedido.estado = new Reprovado();
        }

        public void Finaliza(Pedido pedido)
        {
            throw new Exception("Não se pode passar de EmAprovacao para finalizado");
        }

    }
}
