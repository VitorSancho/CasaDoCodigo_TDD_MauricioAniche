using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap8
{
    public class NotaFiscal
    {
        public string Cliente;
        public double ValorTotal;
        public DateTime Data;

        public NotaFiscal(string cliente, double valorTotal, DateTime data)
        {
            this.Cliente = cliente;
            this.ValorTotal = valorTotal;
            this.Data = data;
        }
    }
}
