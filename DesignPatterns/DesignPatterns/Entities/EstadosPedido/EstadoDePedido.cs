using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.EstadosPedido

{
    public interface EstadoDePedido
    {
        public void AplicaDescontoExtra(Pedido pedido);
        void Aprova(Pedido pedido);
        void Reprova(Pedido pedido);
        void Finaliza(Pedido pedido);
    }
}
