using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap2
{
    public class Produto :IEqualityComparer<Produto>
    {
        public string nome;
        public decimal preco;


        public Produto(string nome, decimal preco)
        {
            this.nome = nome;
            this.preco = preco; 
        }

        public bool Equals(Produto? x, Produto? y)
        {
            var prop1 = x.preco == y.preco;
            var prop2 = x.nome == y.nome;

            return prop1 == prop2;

        }

        public int GetHashCode([DisallowNull] Produto obj)
        {
            throw new NotImplementedException();
        }
    }
}
