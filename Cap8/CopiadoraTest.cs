using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap8
{
    public class CopiadoraTest
    {
        [Test]
        public void DeveLerEEnviarOConteudoLido()
        {
            var escritor = new Mock<IEscritor>();
            var leitor = new Mock<ILeitor>();

            leitor.Setup(l => l.TemCaracteres())
                    .Returns(new Queue<bool>(new[] { true, false }).Dequeue);
            leitor.Setup(l => l.LeCaracteres()).Returns("mauricio");

            var copiadora = new Copiadora(leitor.Object, escritor.Object);

            copiadora.Copiar();

            escritor.Verify(t => t.Escreve("mauricio"));
        }
    }
}
