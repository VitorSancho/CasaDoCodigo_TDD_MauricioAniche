using Moq;

namespace Cap8
{
    public class GeradorDeNotaFiscalTest
    {
        //[Test]
        //public void DeveGerarNFComValorDeImpostoDescontado()
        //{
        //    var dao = new Mock<NFDao>();

        //    GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object);
        //    Pedido pedido = new Pedido("Mauricio", 1000, 1);

        //    NotaFiscal nf = gerador.Gera(pedido);

        //    Assert.AreEqual(1000*0.94, nf.ValorTotal, 0.0001);
        //}

        //[Test]
        //public void DevePersistirNFGerada()
        //{
        //    var dao = new Mock<NFDao>();  

        //    GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object);
        //    Pedido pedido = new Pedido("Mauricio", 1000, 1);

        //    NotaFiscal nf = gerador.Gera(pedido);

        //    dao.Verify(t => t.Persiste(nf));
        //}

        //[Test]
        //public void DeveEnviarNFGerada()
        //{
        //    var dao = new Mock<NFDao>();
        //    var sap = new Mock<SAP>();

        //    GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object, sap.Object);
        //    Pedido pedido = new Pedido("Mauricio", 1000, 1);

        //    NotaFiscal nf = gerador.Gera(pedido);

        //    dao.Verify(t => t.Persiste(nf));
        //}

        [Test]
        public void DeveInvocarAcoesPosteriores()
        {
            var acao1 = new Mock<IAcaoAposGerarNota>();
            var acao2 = new Mock<IAcaoAposGerarNota>();

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(new List<IAcaoAposGerarNota>() { acao1.Object,acao2.Object });
            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            acao1.Verify(t => t.Executa(nf));
            acao2.Verify(t => t.Executa(nf));
        }
    }
}