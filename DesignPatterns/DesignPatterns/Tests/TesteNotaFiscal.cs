using DesignPatterns.Entities.NotaFiscal;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Tests
{
    public class TesteNotaFiscal
    {
        [Fact]
        public void CriacaoNotaFiscal_Sucesso()
        {
            // Arrange
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador
                    .ParaEmpresa("CIT TESTE")
                    .ComCnpj("23.242.612/0001-12")
                    .comItem(new ItemDaNota("Item 1", 100))
                    .comItem(new ItemDaNota("Item 2", 200))
                    .NaDataAtual()
                    .ComObservacoes("obs aleatoria");


            IList<ItemDaNota> lista = new List<ItemDaNota>();
            lista.Add(new ItemDaNota("Item 1", 100));
            lista.Add(new ItemDaNota("Item 2", 200));

            NotaFiscal esperada = new NotaFiscal("CIT TESTE", "23.242.612/0001-12", new DateTime(), 300, 300 * 0.05, lista, "obs aleatoria");

            // Act
            NotaFiscal resultado = criador.Constroi();

            // Assert
            Assert.NotNull(resultado);
            Assert.Equal(esperada, resultado);
        }
    }
}
