using DesignPatterns.Entities.EstadosPedido;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Tests
{
    public class TestePedidos
    {
        [Fact]
        public void Pedido100Reais_TrocaDeEstadosComDescontoAplicado_Sucesso()
        {
            // Arrange
            Pedido pedido = new Pedido(100);

            // Act
            pedido.Aprova();
            pedido.AplicaDescontoExtra();
            pedido.Finaliza();

            // Assert
            Assert.Equal(98, pedido.Valor);
        }

        [Fact]
        public void NovoPedido_ErroTrocaDeEstadoAprovadoParaAprovado_Erro()
        {
            // Arrange
            Pedido pedido = new Pedido(100);

            // Act
            pedido.AplicaDescontoExtra();
            pedido.Aprova();

            // Assert
            Assert.Throws<Exception>(pedido.Aprova);
        }

        [Fact]
        public void NovoPedido_ErroTrocaDeEstadoFinalizadoParaFinalizado_Erro()
        {
            // Arrange
            Pedido pedido = new Pedido(100);

            // Act
            pedido.AplicaDescontoExtra();
            pedido.Aprova();
            pedido.Finaliza();

            // Assert
            Assert.Throws<Exception>(pedido.Finaliza);
        }

        [Fact]
        public void NovoPedidoCriado_ErroAplicarDescontoDuasVezes_Erro()
        {
            // Arrange
            Pedido pedido = new Pedido(100);

            // Act
            pedido.AplicaDescontoExtra();

            // Assert
            Assert.Throws<Exception>(pedido.AplicaDescontoExtra);
        }


    }
}
