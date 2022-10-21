using DesignPatterns.Entities;
using DesignPatterns.Entities.Descontos;

using Xunit;

namespace DesignPatterns.Tests
{
    public class TesteDescontos
    {
        [Fact]
        public void CompraComSeisItens_DescontoAplicado_Sucesso()
        {
            // Arrange
            CalculadoraDeDescontos calculadora = new CalculadoraDeDescontos();
            Compra compra = new Compra();

            Item i1 = new Item("BORRACHA", 3);
            Item i2 = new Item("LAPIS", 2.50);
            Item i3 = new Item("APONTADOR", 2);
            Item i4 = new Item("ESTOJO", 10);
            Item i5 = new Item("CADERNO",15);
            Item i6 = new Item("PAPEL", 8);

            // Act
            compra.AdicionaItem(i1);
            compra.AdicionaItem(i2);
            compra.AdicionaItem(i3);
            compra.AdicionaItem(i4);
            compra.AdicionaItem(i5);
            compra.AdicionaItem(i6);

            double desconto = calculadora.Calcula(compra);

            // Assert
            Assert.Equal(4.05, desconto);
        }

        [Fact]
        public void CompraValorMaiorCinquenta_DescontoAplicado_Sucesso()
        {
            // Arrange
            CalculadoraDeDescontos calculadora = new CalculadoraDeDescontos();
            Compra compra = new Compra();

            Item i1 = new Item("BORRACHA", 30);
            Item i2 = new Item("LAPIS", 25);
            Item i3 = new Item("APONTADOR", 2);
            

            // Act
            compra.AdicionaItem(i1);
            compra.AdicionaItem(i2);
            compra.AdicionaItem(i3);
            

            double desconto = calculadora.Calcula(compra);

            // Assert
            Assert.Equal(3.99, desconto);
        }

        [Fact]
        public void CompraVendaCasada_DescontoAplicado_Sucesso()
        {
            // Arrange
            CalculadoraDeDescontos calculadora = new CalculadoraDeDescontos();
            Compra compra = new Compra();

            Item i1 = new Item("CANETA", 5);
            Item i2 = new Item("LAPIS", 10);


            // Act
            compra.AdicionaItem(i1);
            compra.AdicionaItem(i2);

            double desconto = calculadora.Calcula(compra);

            // Assert
            Assert.Equal(0.75, desconto);
        }

        [Fact]
        public void CompraSemDesconto_DescontoAplicado_NenhumDesconto()
        {
            // Arrange
            CalculadoraDeDescontos calculadora = new CalculadoraDeDescontos();
            Compra compra = new Compra();

            Item i1 = new Item("CANETA", 5);

            // Act
            compra.AdicionaItem(i1);

            double desconto = calculadora.Calcula(compra);

            // Assert
            Assert.Equal(0, desconto);
        }
    }
}
