namespace Cap3
{
    public class ConversorDeNumeroRomanoTest
    {
        [Test]
        public void DeveEntenderOSimboloI()
        {
            var romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("I");

            Assert.AreEqual(1, numero);
        }

        [Test]
        public void DeveEntenderOSimboloV()
        {
            var romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("V");

            Assert.AreEqual(5, numero);
        }

        [Test]
        public void DeveEntenderDoisSimbolosComoII()
        {
            var romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("II");

            Assert.AreEqual(2, numero);
        }

        [Test]
        public void DeveEntenderDoisSimbolosDoisADoisComoXXII()
        {
            var romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XXII");

            Assert.AreEqual(22, numero);
        }

        [Test]
        public void DeveEntenderDoisNumerosComoIX()
        {
            var romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("IX");

            Assert.AreEqual(9, numero);
        }

        [Test]
        public void DeveEntenderNumeroComplexoComoXXIV()
        {
            var romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XXIV");

            Assert.AreEqual(24, numero);
        }
    }
}