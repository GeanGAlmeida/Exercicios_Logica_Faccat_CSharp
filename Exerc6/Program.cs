using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo para ler as dimensões de um retângulo (base e altura), calcular e escrever a
área do retângulo.*/

            Console.Write("Informe a base do retângulo: ");
            double base1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine());

            double area = base1 * altura;

            Console.WriteLine($"A area do retângulo é {area}");
            Console.ReadKey();

        }
    }
}
