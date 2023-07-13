using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap9
{
    public class Fatura
    {
        public string Cliente;
        public double valor;
        public IList<Pagamento> pagamentos;
        public bool Pago;

        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.valor = valor;
            this.pagamentos = new List<Pagamento>();
            this.Pago = false;
        }

        public void AdicionaPagamento(Pagamento pagamento) 
        {
            this.pagamentos.Add(pagamento);
            double valorTotal = 0;
            foreach(var p in pagamentos)
            {
                valorTotal += p.valor;
            }

            if(valorTotal >= this.valor) { this.Pago = true; }
        }
    }
}
