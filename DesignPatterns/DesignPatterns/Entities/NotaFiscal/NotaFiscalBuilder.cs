using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.NotaFiscal
{
    internal class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }

        public DateTime Data { get; private set; }
        public string Observacoes { get; private set; }
        public double impostos;
        public double valorTotal;
        public IList<ItemDaNota> TodosItens = new List<ItemDaNota>();

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;

            return this;

        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;

            return this;

        }

        public NotaFiscalBuilder comItem(ItemDaNota item)
        {
            TodosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;

            return this;

        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {

            return this;
        }


        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, TodosItens, Observacoes);
        }
    }
}
