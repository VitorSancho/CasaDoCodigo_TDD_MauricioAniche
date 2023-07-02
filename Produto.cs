using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap1
{
    public class Produto
    {
        public string nome;
        public decimal preco;


        public Produto(string nome, decimal preco)
        {
            this.nome = nome;
            this.preco = preco; 
        }
    }
}
