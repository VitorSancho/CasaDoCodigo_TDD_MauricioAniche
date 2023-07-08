using Cap7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7
{
    public class QuizeOuVintePorCento : IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if(funcionario.salario > 2000)
            {
                return funcionario.salario * 0.88;
            }
            return funcionario.salario * 0.75;
        }
    }
}
