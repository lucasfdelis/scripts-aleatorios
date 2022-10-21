using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities.BancoEstate
{
    public interface EstadoConta
    {
        void Deposita(ContaBanco contabanco, double valor);
        void Saca(ContaBanco contabanco, double valor);

        void Positivar(ContaBanco conta);
        void Negativar(ContaBanco conta);

    }
}
