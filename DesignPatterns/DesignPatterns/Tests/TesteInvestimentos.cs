using DesignPatterns.Entities;
using Xunit;

namespace DesignPatterns.Tests
{
    public class TesteInvestimentos
    {
        [Fact]
        public void ImpostoOrcamento_ISS_Igual()
        {
            // Arrange
            Orcamento orcamentoTeste = new Orcamento(500);
            Imposto iss = new ISS();
            CalculadorDeImposto calcImposto = new CalculadorDeImposto();

            // Act 
            double result = calcImposto.Calcula(orcamentoTeste, iss);

            //Assert
            Assert.Equal(30, result);
        }

        [Fact]
        public void ImpostoOrcamento_ISS_NaoIgual()
        {
            // Arrange
            Orcamento orcamentoTeste = new Orcamento(500);
            Imposto iss = new ISS();
            CalculadorDeImposto calcImposto = new CalculadorDeImposto();

            // Act 
            double result = calcImposto.Calcula(orcamentoTeste, iss);

            //Assert
            Assert.NotEqual(55, result);
        }
        
        [Fact]
        public void OrcamentoMenorQueMil_ICCC_Igual()
        {
            // Arrange
            Orcamento orcamentoTeste = new Orcamento(999);
            Imposto iss = new ICCC();
            CalculadorDeImposto calcImposto = new CalculadorDeImposto();

            // Act 
            double result = calcImposto.Calcula(orcamentoTeste, iss);

            //Assert
            Assert.Equal(49.95, result);
        }

        [Fact]
        public void OrcamentoMaiorQueMilEMenorQueTresMil_ICCC_Igual()
        {
            // Arrange
            Orcamento orcamentoTeste = new Orcamento(2999);
            Imposto iss = new ICCC();
            CalculadorDeImposto calcImposto = new CalculadorDeImposto();

            // Act 
            double result = calcImposto.Calcula(orcamentoTeste, iss);

            //Assert
            Assert.Equal(209.93, result);
        }

        [Fact]
        public void OrcamentoMaiorQueTresMil_ICCC_Igual()
        {
            // Arrange
            Orcamento orcamentoTeste = new Orcamento(5000);
            Imposto iss = new ICCC();
            CalculadorDeImposto calcImposto = new CalculadorDeImposto();

            // Act 
            double result = calcImposto.Calcula(orcamentoTeste, iss);

            //Assert
            Assert.Equal(430, result);
        }

        [Fact]
        public void Orcamento_ICMS_Igual()
        {
            // Arrange
            Orcamento orcamentoTeste = new Orcamento(1500);
            Imposto iss = new ICMS();
            CalculadorDeImposto calcImposto = new CalculadorDeImposto();

            // Act 
            double result = calcImposto.Calcula(orcamentoTeste, iss);

            //Assert
            Assert.Equal(125, result);
        }

        [Fact]
        public void Orcamento_ICMS_Diferente()
        {
            // Arrange
            Orcamento orcamentoTeste = new Orcamento(20);
            Imposto iss = new ICMS();
            CalculadorDeImposto calcImposto = new CalculadorDeImposto();

            // Act 
            double result = calcImposto.Calcula(orcamentoTeste, iss);

            //Assert
            Assert.NotEqual(1, result);
        }
    }
}
