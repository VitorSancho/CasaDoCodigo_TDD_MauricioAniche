using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap1
{
    [TestFixture]
    public class TestaMaiorEMenor
    {

        [Test]
        public void OrdemDecrescente()
        {
            var CarrinhodeCompras = new CarrinhoDeCompras();
            CarrinhodeCompras.ListaDeProdutos.Add(new Produto("Geladeira", 450.0m));
            CarrinhodeCompras.ListaDeProdutos.Add(new Produto("Liquidificador", 250.0M));
            CarrinhodeCompras.ListaDeProdutos.Add(new Produto("Jogo de Pratos", 70.0M));

            var algoritmo = new MaiorEmenor();
            algoritmo.Encontra(CarrinhodeCompras);

            Assert.AreEqual("Jogo de pratos", algoritmo.Menor.nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.nome);
        }
    }
}
