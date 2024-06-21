using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Escreva um algoritmo para ler o salário mensal atual de um funcionário e o percentual de reajuste.
Calcular e escrever o valor do novo salário*/


            Console.Write("Qual o salário do funcionario: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Qual a porcentagem de reajuste: ");
            double reajuste = double.Parse(Console.ReadLine());

            double novo_salario = salario + (reajuste / 100 * salario);

            Console.WriteLine($"O novo valor do salário com reajuste R${novo_salario}");

            Console.ReadKey();
        }
    }
}
