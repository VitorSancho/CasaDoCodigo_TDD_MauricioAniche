using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3
{
    public class ConversorDeNumeroRomano
    {
        private static Dictionary<string, int> tabela = new Dictionary<string, int>() { 
        { "I", 1},
        { "V", 5},
        { "X", 10 },
        { "L", 50},
        { "C", 100},
        { "D", 500},
        { "M", 1000}};

        public int Converte(string numeroEmRomano)
        {
            var acumulador = 0;
            var ultimoVizinhoDaDireita = 0;
            for(int i= numeroEmRomano.Length - 1; i>=0 ; i--)
            {
                int atual = tabela[numeroEmRomano[i].ToString()];

                var multiplicativo = 1;
                if (atual < ultimoVizinhoDaDireita) multiplicativo = -1;

                acumulador += atual * multiplicativo;

                ultimoVizinhoDaDireita = atual;
            }

            return acumulador;
        }
    }
}
