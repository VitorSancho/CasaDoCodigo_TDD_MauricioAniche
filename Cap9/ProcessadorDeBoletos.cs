using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap9
{
    public class ProcessadorDeBoletos
    {
        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {
            foreach (var boleto in boletos)
            {
                var pagamento = new Pagamento(boleto.Valor, EMeioDePagamento.BOLETO);
                fatura.AdicionaPagamento(pagamento);
            }
        }
    }
}
