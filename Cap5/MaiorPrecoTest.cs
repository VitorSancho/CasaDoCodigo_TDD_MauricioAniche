namespace Cap5
{
    public class MaiorPrecoTest
    {

        [Test]
        public void DeveRetornarZeroSeCArrinhoVazio()
        {
            var carrinho = new CarrinhoDeCompras();

            Assert.AreEqual(0.0, carrinho.MaiorValor(), 0.0001);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.ListaDeProdutos.Add(new Item("Geladeira",1,900.0));

            Assert.AreEqual(900.0, carrinho.MaiorValor(), 0.0001);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoComMuitosElementos()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.ListaDeProdutos.Add(new Item("Geladeira", 1, 900.0));
            carrinho.ListaDeProdutos.Add(new Item("Fogão", 1, 1500));
            carrinho.ListaDeProdutos.Add(new Item("Máquina de Lavar", 1, 750));

            Assert.AreEqual(1500.0, carrinho.MaiorValor(), 0.0001);
        }
    }
}