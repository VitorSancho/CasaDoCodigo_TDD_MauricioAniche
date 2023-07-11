using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cap8
{
    public class Pedido
    {
        public string Cliente;
        public double ValorTotal;
        public int QuantidadeItens;

        public Pedido(string cliente, double valorTotal, int quantidadeitens)
        {
            this.Cliente = cliente; 
            this.ValorTotal = valorTotal;
            this.QuantidadeItens= quantidadeitens;
        }
    }
}
