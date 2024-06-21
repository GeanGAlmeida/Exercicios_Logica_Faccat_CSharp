using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler um valor e escrever se é positivo ou negativo (considere o valor zero como positivo).

            Console.Write("Digite um valor positivo ou negativo qualquer: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine($"O numero {num} é positivo");
            }
            else
            {
                Console.WriteLine($"O numero {num} é negativo");
            }
            Console.ReadKey();
        }
    }
}
