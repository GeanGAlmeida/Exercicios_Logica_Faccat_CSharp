using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo para ler uma temperatura em graus Fahrenheit, calcular e escrever o valor
            correspondente em graus Celsius*/

            Console.Write("Quantos Graus esta fazendo em Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) / 1.8;

            Console.WriteLine($"a conversão de {fahrenheit}ºF para graus celsius é {celsius}Cº");
            Console.ReadKey();
        }
    }
}
