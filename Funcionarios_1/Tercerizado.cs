using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionarios
{
    class Tercerizado : Funcionarios
    {

        public double Percentual { get; private set; }
        public double Salario_Atual { get; private set; }

        public override double CalculaHoras => this.Horas * this.SalarioHora * this.Percentual;

        public Tercerizado(String nome, int funcional, double salario, double horas, double percentual, string empresa)
                : base(nome, funcional, salario, horas, empresa)
        {
            Percentual = percentual;
            Salario_Atual = 0;
            _Empresa = empresa;

        }

    }
}



