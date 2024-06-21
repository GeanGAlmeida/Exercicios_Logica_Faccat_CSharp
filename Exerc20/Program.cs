using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler dois valores (considere que não serão lidos valores iguais) e escrevê-los em ordem crescente.*/

            Console.Write("Digite o primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num2} {num1}");
            }else
            {
                Console.WriteLine($"{num1} {num2}");
            }
            Console.ReadKey();
        }
    }
}
