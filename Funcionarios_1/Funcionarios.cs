using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionarios
{
    class Funcionarios : Forma
    {
        public double Horas { get; set; }
        public override double CalculaHoras => this.Horas * this.SalarioHora;
        public override string Func => this._nome;
        public override string Empresa => this._Empresa;

        private string _nome;

        public string _Empresa;
        public int Funcional { get; set; }
        public double SalarioHora { get; private set; }
        public Funcionarios() { }
        public Funcionarios(String nome, int funcional, double salario, double horas, String empresa)
        {
            _nome = nome;
            Funcional = funcional;
            Horas = horas;
            SalarioHora = salario;
            _Empresa = empresa;
        }

        public String Nome
        {
            get { return _nome; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Erro Nome");
                }
                else
                {
                    _nome = value;
                }
            }
        }
    }
}
