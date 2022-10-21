using DesignPatterns.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Tests
{
    public class TesteImpostos
    {
        [Fact]
        public void Orcamento500reais_ImpostoICCCAplicado_Sucesso()
        {
            // Arrange
            Orcamento orcamento = new Orcamento(500);
            Imposto iccc = new ICCC();
            CalculadorDeImposto calc = new CalculadorDeImposto();

            // Act
            double resultado = calc.Calcula(orcamento, iccc);

            // Assert
            Assert.Equal(25,resultado);
        }

        [Fact]
        public void Orcamento3500reais_ImpostoICCCAplicado_Sucesso()
        {
            // Arrange
            Orcamento orcamento = new Orcamento(3500);
            Imposto iccc = new ICCC();
            CalculadorDeImposto calc = new CalculadorDeImposto();

            // Act
            double resultado = calc.Calcula(orcamento, iccc);

            // Assert
            Assert.Equal(310, resultado);
        }

        [Fact]
        public void Orcamento100reais_ImpostoICMSAplicado_Sucesso()
        {
            // Arrange
            Orcamento orcamento = new Orcamento(100);
            Imposto icms = new ICMS();
            CalculadorDeImposto calc = new CalculadorDeImposto();

            // Act
            double resultado = calc.Calcula(orcamento, icms);

            // Assert
            Assert.Equal(55, resultado);
        }

        [Fact]
        public void Orcamento6000reais_ImpostoISSAplicado_Sucesso()
        {
            // Arrange
            Orcamento orcamento = new Orcamento(6000);
            Imposto iss = new ISS();
            CalculadorDeImposto calc = new CalculadorDeImposto();

            // Act
            double resultado = calc.Calcula(orcamento, iss);

            // Assert
            Assert.Equal(360, resultado);
        }

        [Fact]
        public void Orcamento1000reais_ImpostoICKSAplicado_Sucesso()
        {
            // Arrange
            Orcamento orcamento = new Orcamento(1149.97);
            Item i1 = new Item("Machado", 99.99);
            Item i2 = new Item("Martelo", 149.99);
            Item i3 = new Item("Serra Eletrica", 899.99);

            orcamento.AdicionaItem(i1);
            orcamento.AdicionaItem(i2);
            orcamento.AdicionaItem(i3);

            Imposto icks = new ICKS();
            CalculadorDeImposto calc = new CalculadorDeImposto();

            // Act
            double resultado = calc.Calcula(orcamento, icks);

            // Assert
            Assert.Equal(114.997, Math.Round(resultado, 3));
        }

        [Fact]
        public void Orcamento1000reais_ImpostoIHITAplicado_Sucesso()
        {
            // Arrange
            Orcamento orcamento = new Orcamento(1099.97);
            Item i1 = new Item("Machado", 99.99);
            Item i2 = new Item("Machado", 99.99);
            Item i3 = new Item("Serra Eletrica", 899.99);

            orcamento.AdicionaItem(i1);
            orcamento.AdicionaItem(i2);
            orcamento.AdicionaItem(i3);

            Imposto ihit = new IHIT();
            CalculadorDeImposto calc = new CalculadorDeImposto();

            // Act
            double resultado = calc.Calcula(orcamento, ihit);

            // Assert
            Assert.Equal(242.996, Math.Round(resultado, 3));
        }

        [Fact]
        public void Orcamento1000reais_ImpostoIHITeICKSAplicado_Sucesso()
        {
            // Arrange
            Orcamento orcamento = new Orcamento(1099.97);
            Item i1 = new Item("Machado", 99.99);
            Item i2 = new Item("Machado", 99.99);
            Item i3 = new Item("Serra Eletrica", 899.99);

            orcamento.AdicionaItem(i1);
            orcamento.AdicionaItem(i2);
            orcamento.AdicionaItem(i3);

            Imposto ihit = new IHIT(new ICKS());
            CalculadorDeImposto calc = new CalculadorDeImposto();

            // Act
            double resultado = calc.Calcula(orcamento, ihit);

            // Assert
            Assert.Equal(352.993, Math.Round(resultado, 3));
        }

        [Fact]
        public void Orcamento1000reais_ImpostoICCCeISSAplicado_Sucesso()
        {
            // Arrange
            Orcamento orcamento = new Orcamento(1099.97);
            Item i1 = new Item("Machado", 99.99);
            Item i2 = new Item("Machado", 99.99);
            Item i3 = new Item("Serra Eletrica", 899.99);

            orcamento.AdicionaItem(i1);
            orcamento.AdicionaItem(i2);
            orcamento.AdicionaItem(i3);

            Imposto iccc = new ICCC(new ISS());
            CalculadorDeImposto calc = new CalculadorDeImposto();

            // Act
            double resultado = calc.Calcula(orcamento, iccc);

            // Assert
            Assert.Equal(142.996, Math.Round(resultado, 3));
        }

        [Fact]
        public void Orcamento5000reais_ImpostoMuitoAltoAplicado_Sucesso()
        {
            // Arrange
            Orcamento orcamento = new Orcamento(5000);

            Imposto muitoAlto = new ImpostoMuitoAlto();
            CalculadorDeImposto calc = new CalculadorDeImposto();

            // Act
            double resultado = calc.Calcula(orcamento, muitoAlto);

            // Assert
            Assert.Equal(1000.000, Math.Round(resultado, 3));
        }


    }
}
