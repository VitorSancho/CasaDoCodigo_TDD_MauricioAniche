using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap5
{
    public class Item
    {
        public string descricao;
        public double valorunitario;
        public int quantidade;


        public Item(string descricao
            , int quantidade
            , double valorunitario)
        {
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.valorunitario= valorunitario;
        }

        public double ValorTotal
        {
            get { return this.valorunitario * this.quantidade; }
        }
    }
}
