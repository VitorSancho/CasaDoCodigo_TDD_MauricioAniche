using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap2
{
    [TestFixture]
    public class TestaMaiorEMenor
    {

        [Test]
        public void OrdemDecrescente()
        {
            var CarrinhodeCompras = new CarrinhoDeCompras();
            var Geladeira = new Produto("Geladeira", 450.0m);
            var Liquidificador = new Produto("Liquidificador", 250.0M);
            var JogoDePratos = new Produto("Jogo de Pratos", 70.0M);

            CarrinhodeCompras.ListaDeProdutos.AddRange(new List<Produto>() { Geladeira, Liquidificador, JogoDePratos });

            var algoritmo = new MaiorEmenor();
            algoritmo.Encontra(CarrinhodeCompras);

            Assert.AreEqual(JogoDePratos, algoritmo.Menor);
            Assert.AreEqual(Geladeira, algoritmo.Maior);
        }

        [Test]
        public void OrdemCrescente()
        {
            var CarrinhodeCompras = new CarrinhoDeCompras();
            var Geladeira = new Produto("Geladeira", 450.0m);
            var Liquidificador = new Produto("Liquidificador", 250.0M);
            var JogoDePratos = new Produto("Jogo de Pratos", 70.0M);

            CarrinhodeCompras.ListaDeProdutos.AddRange(new List<Produto>() { JogoDePratos, Liquidificador, Geladeira });

            var algoritmo = new MaiorEmenor();
            algoritmo.Encontra(CarrinhodeCompras);

            Assert.AreEqual(JogoDePratos, algoritmo.Menor);
            Assert.AreEqual(Geladeira, algoritmo.Maior);
        }

        [Test]
        public void OrdemAleatoria()
        {
            var CarrinhodeCompras = new CarrinhoDeCompras();
            var Geladeira = new Produto("Geladeira", 450.0m);
            var Liquidificador = new Produto("Liquidificador", 250.0M);
            var JogoDePratos = new Produto("Jogo de Pratos", 70.0M);

            CarrinhodeCompras.ListaDeProdutos.AddRange(new List<Produto>() { Liquidificador, JogoDePratos, Geladeira });

            var algoritmo = new MaiorEmenor();
            algoritmo.Encontra(CarrinhodeCompras);

            Assert.AreEqual(JogoDePratos, algoritmo.Menor);
            Assert.AreEqual(Geladeira, algoritmo.Maior);
        }

        [Test]
        public void SomenteUmProduto()
        {
            var CarrinhodeCompras = new CarrinhoDeCompras();
            var Geladeira = new Produto("Geladeira", 450.0m);

            CarrinhodeCompras.ListaDeProdutos.AddRange(new List<Produto>() { Geladeira });

            var algoritmo = new MaiorEmenor();
            algoritmo.Encontra(CarrinhodeCompras);

            Assert.AreEqual(Geladeira, algoritmo.Menor);
            Assert.AreEqual(Geladeira, algoritmo.Maior);
        }
    }
}
