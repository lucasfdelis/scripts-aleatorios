using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.EstadosPedido

{
    public class Aprovado : EstadoDePedido
    {
        public void AplicaDescontoExtra(Pedido pedido)
        {
            if (pedido.DescontoFoiAplicado)
            {
                throw new Exception("Já foi aplicado um desconto neste pedido!");
            }
            pedido.DescontoFoiAplicado = true;
            pedido.Valor = pedido.Valor -= pedido.Valor * 0.02;
        }

        public void Aprova(Pedido pedido)
        {
            throw new Exception("O estado do pedido já está em aprovado");
        }

        public void Reprova(Pedido pedido)
        {
            throw new Exception("O pedido já foi aprovado, não se pode reprovar no momento!");
        }

        public void Finaliza(Pedido pedido)
        {
            pedido.estado = new Finalizado();
        }
    }
}
