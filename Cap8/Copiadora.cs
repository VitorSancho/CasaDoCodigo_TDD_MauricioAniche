using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap8
{
    public class Copiadora
    {
        public ILeitor leitor;
        public IEscritor escritor;

        public Copiadora(ILeitor leitor, IEscritor escritor)
        {
            this.leitor = leitor;
            this.escritor = escritor;   
        }

        public void Copiar()
        {

            while(leitor.TemCaracteres())
            {
                escritor.Escreve(leitor.LeCaracteres());
            }
        }
    }
}
