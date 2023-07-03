using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap4
{
    public class Funcionario
    {
        public string nome;
        public double salario;
        public ECargo cargo;

        public Funcionario(string nome, double salario, ECargo cargo)
        {
            this.nome = nome;
            this.salario = salario;
            this.cargo = cargo;
        }
    }
}
