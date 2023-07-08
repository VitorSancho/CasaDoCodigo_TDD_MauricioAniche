namespace Cap6
{
    public class MaiorPrecoTest
    {
        private CarrinhoDeCompras carrinho;

        [SetUp]
        public void Inicializa()
        {
            this.carrinho= new CarrinhoDeCompras();
        }

        [Test]
        public void DeveRetornarZeroSeCArrinhoVazio()
        {
            Assert.AreEqual(0.0, carrinho.MaiorValor(), 0.0001);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            carrinho.ListaDeProdutos.Add(new Item("Geladeira",1,900.0));

            Assert.AreEqual(900.0, carrinho.MaiorValor(), 0.0001);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoComMuitosElementos()
        {
            carrinho.ListaDeProdutos.Add(new Item("Geladeira", 1, 900.0));
            carrinho.ListaDeProdutos.Add(new Item("Fogão", 1, 1500));
            carrinho.ListaDeProdutos.Add(new Item("Máquina de Lavar", 1, 750));

            Assert.AreEqual(1500.0, carrinho.MaiorValor(), 0.0001);
        }
    }
}