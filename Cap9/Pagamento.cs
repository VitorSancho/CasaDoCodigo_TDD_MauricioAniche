using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap9
{
    public class Pagamento
    {
        public double valor;
        public EMeioDePagamento meioDePagamento;

        public Pagamento(double valor, EMeioDePagamento meioDePagamento)
        {
            this.valor = valor;
            this.meioDePagamento = meioDePagamento;
        }
    }
}
