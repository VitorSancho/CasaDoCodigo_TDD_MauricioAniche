using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap6
{
    public class MaiorPreco
    {
        public double Encontra(CarrinhoDeCompras carrinho)
        {
            if(carrinho.ListaDeProdutos.Count==0) return 0;

            var maior = carrinho.ListaDeProdutos[0].ValorTotal;
            foreach(var item in carrinho.ListaDeProdutos)
            {
                if(maior < item.ValorTotal)
                {
                    maior = item.ValorTotal;
                }
            }
            return maior;
        }
    }
}
