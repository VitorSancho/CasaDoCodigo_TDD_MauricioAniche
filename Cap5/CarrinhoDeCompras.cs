using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap5
{
    public class CarrinhoDeCompras
    {
        public List<Item> ListaDeProdutos;

        public CarrinhoDeCompras()
        {
            ListaDeProdutos = new List<Item>();
        }

        public double MaiorValor()
        {
            if (ListaDeProdutos.Count == 0) return 0;

            var maior = ListaDeProdutos[0].ValorTotal;
            foreach (var item in ListaDeProdutos)
            {
                if (maior < item.ValorTotal)
                {
                    maior = item.ValorTotal;
                }
            }
            return maior;
        }
    }
}
