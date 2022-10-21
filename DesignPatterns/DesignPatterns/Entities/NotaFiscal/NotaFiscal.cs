using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.NotaFiscal
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public String Observacoes { get; set; }

        public NotaFiscal(string razaoSocial, String cnpj, DateTime dataDeEmissao,
            double valorBruto, double impostos, IList<ItemDaNota> itens, string observacoes)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataDeEmissao = dataDeEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Observacoes = observacoes;
            Itens = itens;
        }

        public override bool Equals(Object obj)
        {

            return
                this.RazaoSocial.Equals(((NotaFiscal)obj).RazaoSocial) &&
                this.Cnpj.Equals(((NotaFiscal)obj).Cnpj) &&
                this.DataDeEmissao.Equals(((NotaFiscal)obj).DataDeEmissao) &&
                this.Impostos.Equals(((NotaFiscal)obj).Impostos) &&
                this.ValorBruto.Equals(((NotaFiscal)obj).ValorBruto) &&
                this.Observacoes.Equals(((NotaFiscal)obj).Observacoes);
        }
        public override int GetHashCode()
        {
            return
                this.RazaoSocial.GetHashCode() ^
                this.Impostos.GetHashCode() ^
                this.ValorBruto.GetHashCode() ^
                this.Observacoes.GetHashCode() ^
                this.Cnpj.GetHashCode();
        }
    }
}
