using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap2
{
    public class MaiorEmenor
    {
        public Produto Menor;
        public Produto Maior;

        public void Encontra(CarrinhoDeCompras carrinho)
        {
            foreach( var produto in carrinho.ListaDeProdutos)
            {
                if (Menor == null || produto.preco <  Menor.preco)
                {
                    Menor = produto;
                }
                //else if (Maior == null || produto.preco < Maior.preco)
                
                if (Maior == null || produto.preco > Maior.preco)
                {
                    Maior = produto;
                }
            }

        }
    }
}
