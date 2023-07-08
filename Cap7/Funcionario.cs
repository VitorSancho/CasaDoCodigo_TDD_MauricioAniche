using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7
{
    public class Funcionario
    {
        public string nome;
        public double salario;
        public Cargo cargo;

        public Funcionario(string nome, double salario, Cargo cargo)
        {
            this.nome = nome;
            this.salario = salario;
            this.cargo = cargo;
        }
    }
}
