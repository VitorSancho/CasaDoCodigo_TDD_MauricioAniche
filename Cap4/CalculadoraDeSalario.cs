using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Cap4
{
    public class CalculadoraDeSalario
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            if (funcionario.cargo.Equals(ECargo.DESENVOLVEDOR))
            {
                if (funcionario.salario > 3000) return funcionario.salario * 0.8;
                return funcionario.salario*0.9;
            }
            if (funcionario.salario > 2500) return funcionario.salario * 0.75;

            return funcionario.salario * 0.85;
        }
    }
}
