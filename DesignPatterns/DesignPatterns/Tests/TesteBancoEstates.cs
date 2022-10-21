using DesignPatterns.Entities.BancoEstate;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Tests
{
    public class TesteBancoEstates
    {
        [Fact]
        public void TestaContaPositiva_SacarParaNegativarEDepositarValor_Sucesso()
        {
            // Arrange
            ContaBanco conta = new ContaBanco(500);

            // Act
            conta.Saca(600);
            conta.Deposita(600);

            // Assert 
            Assert.Equal(470, conta.Saldo);
        }

        [Fact]
        public void TestaContaPositiva_DepositaValor_Sucesso()
        {
            // Arrange
            ContaBanco conta = new ContaBanco(500);

            // Act
            conta.Deposita(500);

            // Act 
            Assert.Equal(990, conta.Saldo);
        }
    }
}
