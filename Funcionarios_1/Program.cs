using System;
using Funcionarios;


namespace Funcionarios
{
    class Program
    {
        public enum OpcoesMenu
        {
            Sair = 0,
            Funcionario = 1,
            Terceiro = 2,
        }
        static void Main(string[] args)
        {
            OpcoesMenu escolha = OpcoesMenu.Funcionario;
            while ((escolha = GetEscolha()) != OpcoesMenu.Sair)
            {
                Forma forma = null;
                switch (escolha)
                {
                    case OpcoesMenu.Funcionario:
                        forma = Funcionario();
                        break;
                    case OpcoesMenu.Terceiro:
                        forma = Tercerizado();
                        break;
                    default:
                        break;
                }

                if (forma.Empresa == "")
                {
                    Console.WriteLine($"o salario do {escolha} {forma.Func} é {forma.CalculaHoras}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"o salario do {escolha} {forma.Func} da {forma.Empresa} é {forma.CalculaHoras}");
                    Console.WriteLine();
                }
            }
            Environment.Exit(0);
        }
        public static OpcoesMenu GetEscolha()
        {
            Console.WriteLine("Escolha de quem voce quer calcular o Salario :");
            Console.WriteLine("\t{0} -Funcionario", (int)OpcoesMenu.Funcionario);
            Console.WriteLine("\t{0} - Terceiro", (int)OpcoesMenu.Terceiro);
            Console.Write("Escolha : ");
            string valor = Console.ReadLine();
            OpcoesMenu escolha;
            if (!Enum.TryParse(valor, out escolha) || !Enum.IsDefined(typeof(OpcoesMenu), escolha))
            {
                Console.WriteLine("opção inválida, Escolha uma opção válida.");
                return GetEscolha();
            }
            return escolha;
        }
        private static double GetDouble(string prompt)
        {
            bool isValido = false;
            double valor = 100;
            while (!isValido)
            {
                Console.Write(prompt);
                isValido = double.TryParse(Console.ReadLine(), out valor);
            }
            return valor;
        }
        private static Funcionarios Funcionario()
        {
            double horas = GetDouble("Digite a Qtde Horas : ");
            Funcionarios funcionarios = new Funcionarios("Roberto", 123, 1000, horas, "");
            return funcionarios;
        }
        private static Funcionarios Tercerizado()
        {
            double horas = GetDouble("Qtde Horas : ");
            Funcionarios Tercerizado = new Tercerizado("Jose", 345, 1000, horas, 1.015, "ABC Terceirizacao");
            return Tercerizado;
        }
    }
}


//O cálculo do salário é feito simplesmente multiplicando o valor da hora pela carga horária. Porém, além desse valor, funcionários terceirizados tem o direito
//a um valor adicional (porcentagem) definido pela taxa de serviço. Construa essas classes usando herança. No programa principal, peça para o usuário digitar
//se é terceirizado ou não. Caso não seja terceirizado, imprima seu nome e seu salário. Caso seja terceirizado, imprima seu nome, sua empresa de origem e
//seu salário. Para imprimir esses dados, crie o método “ImprimeDados” na superclasse e o sobrescreva na subclasse com as alterações necessárias
//(dica: lembrar do comando “base”).

//Regras:

//• criar no mínimo 2 funcionários, sendo 1 comum e um terceirizado;

//• os objetos instanciados no programa principal devem ser do tipo “Funcionário” mesmo no caso em que o funcionário é terceirizado (polimorfismo).

// Dica: vide slides 96 e 97 da aula de Programação Orientada a Objetos
//• usar construtores com e sem argumentos em ambas as classes (sobrecarga);

//• usar Auto Properties e Properties (os dois tipos devem ser usados).