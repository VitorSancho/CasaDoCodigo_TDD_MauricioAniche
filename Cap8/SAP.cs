using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap8
{
    public class SAP : IAcaoAposGerarNota
    {
        public virtual void Executa(NotaFiscal nf)
        {
            // envia NF para o SAP
        }
    }
}
