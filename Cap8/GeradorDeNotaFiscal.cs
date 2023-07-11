using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap8
{
    public class GeradorDeNotaFiscal
    {
        private IList<IAcaoAposGerarNota> acoes;
        private IRelogio relogio;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes, IRelogio relogio)
        {
            this.acoes = acoes;
            this.relogio = relogio;
        }

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes)
                : this (acoes, new RelogioDoSistema())
        {
        }

        public NotaFiscal Gera(Pedido pedido)
        {
            var nf = new NotaFiscal(pedido.Cliente
                                , pedido.ValorTotal * 0.94
                                , relogio.Hoje());
        
            foreach(var acao in acoes) 
            {
                acao.Executa(nf);
            }

            return nf;
        }
    }
}
