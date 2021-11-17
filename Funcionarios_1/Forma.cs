using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionarios
{

    public abstract class Forma
    {
        public abstract double CalculaHoras { get; }
        public abstract string Func { get; }

        public abstract string Empresa { get; }

    }

}
