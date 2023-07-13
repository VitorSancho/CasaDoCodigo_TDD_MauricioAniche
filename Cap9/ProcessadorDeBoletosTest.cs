using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap9
{
    public class ProcessadorDeBoletosTest
    {
        [Test]
        public void DeveProcessarPagamentoViaBoletoUnico()
        {
            ProcessadorDeBoletos processadorDeBoletos = new ProcessadorDeBoletos();
            Fatura fatura = new Fatura("Cliente", 150.0);
            Boleto b1 = new Boleto(150.0);

            IList<Boleto> boletos = new List<Boleto>() { b1 };

            processadorDeBoletos.Processa(boletos, fatura);

            Assert.AreEqual(1, fatura.pagamentos.Count);
            Assert.AreEqual(150.0, fatura.pagamentos[0].valor, 0.00001);
        }

        [Test]
        public void DeveProcessarPagamentoViaMuitosBoletos()
        {
            ProcessadorDeBoletos processadorDeBoletos = new ProcessadorDeBoletos();
            Fatura fatura = new Fatura("Cliente1", 300.0);
            Boleto b1 = new Boleto(100.0);
            Boleto b2 = new Boleto(200.0);

            IList<Boleto> boletos = new List<Boleto>() { b1, b2 };

            processadorDeBoletos.Processa(boletos, fatura);

            Assert.AreEqual(2, fatura.pagamentos.Count);
            Assert.AreEqual(100.0, fatura.pagamentos[0].valor, 0.00001);
            Assert.AreEqual(200.0, fatura.pagamentos[1].valor, 0.00001);
        }
    }
}
