using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.EstadosPedido
{
    public class Pedido
    {
        public EstadoDePedido estado { get; set; }
        public double Valor { get; set; }
        public bool DescontoFoiAplicado { get; set; }

        public Pedido(double valor)
        {
            Valor = valor;
            estado = new EmAprovacao();
            DescontoFoiAplicado = false;
        }

        public void AplicaDescontoExtra()
        {
            estado.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            estado.Aprova(this);
        }

        public void Reprova()
        {
            estado.Reprova(this);
        }

        public void Finaliza()
        {
            estado.Finaliza(this);
        }
    }
}
