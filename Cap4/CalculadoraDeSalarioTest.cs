namespace Cap4
{
    public class CalculadoraDeSalarioTest
    {

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            var calculadoraDeSalario = new CalculadoraDeSalario();
            var desenvolvedor = new Funcionario("Mauricio", 1500.0, ECargo.DESENVOLVEDOR);

            var salario = calculadoraDeSalario.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0*0.9, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            var calculadoraDeSalario = new CalculadoraDeSalario();
            var desenvolvedor = new Funcionario("Mauricio", 4000.0, ECargo.DESENVOLVEDOR);

            var salario = calculadoraDeSalario.CalculaSalario(desenvolvedor);

            Assert.AreEqual(4000.0 * 0.8, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDBAComSalarioAbaixoDoLimite()
        {
            var calculadoraDeSalario = new CalculadoraDeSalario();
            var desenvolvedor = new Funcionario("Mauricio", 500.0, ECargo.DBA);

            var salario = calculadoraDeSalario.CalculaSalario(desenvolvedor);

            Assert.AreEqual(500.0 * 0.85, salario, 0.00001);
        }
    }
}