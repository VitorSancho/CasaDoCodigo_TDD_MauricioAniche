using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap9
{
    public class FaturaTest
    {
        [Test]
        public void DeveMarcarFaturaComoPagaCasoBoletoUnicoPagueTudo()
        {
            ProcessadorDeBoletos processadorDeBoletos = new ProcessadorDeBoletos();
            Fatura fatura = new Fatura("Cliente1", 150.0);
            Boleto b1 = new Boleto(150.0);

            IList<Boleto> boletos = new List<Boleto>() { b1 };

            processadorDeBoletos.Processa(boletos, fatura);

            Assert.IsTrue(fatura.Pago);
        }
    }
}
