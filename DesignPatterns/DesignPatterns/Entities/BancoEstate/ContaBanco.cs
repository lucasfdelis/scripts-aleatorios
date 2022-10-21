using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.BancoEstate
{
    public class ContaBanco
    {

        public double Saldo { get; set; }
        public EstadoConta estado { get; set; }

        public ContaBanco(double saldo)
        {
            Saldo = saldo;
            estado = new Positivo();
        }

        public void Saca(double valor)
        {
            estado.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            estado.Deposita(this, valor);
        }
    }
}
