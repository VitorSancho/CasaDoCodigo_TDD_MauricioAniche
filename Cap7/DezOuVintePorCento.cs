using Cap7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7
{
    public class DezOuVintePorCento : IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if(funcionario.salario > 3000)
            {
                return funcionario.salario * 0.8;
            }
            return funcionario.salario * 0.9;
        }
    }
}
