using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7
{
    public class Cargo
    {
        public static Cargo DESENVOLVEDOR
        { get { return new Cargo(new DezOuVintePorCento()); }}

        public static Cargo DBA
        { get { return new Cargo(new QuizeOuVintePorCento()); } }

        public static Cargo TESTADOR
        { get { return new Cargo(new QuizeOuVintePorCento()); } }


        public IRegraDeCalculo regra { get; private set; }

        private Cargo(IRegraDeCalculo regra)
        {
            this.regra = regra;
        }
    }
}
