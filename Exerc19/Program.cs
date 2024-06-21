using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler dois valores (considere que não serão lidos valores iguais) e escrever o maior deles.*/

            Console.Write("Digite o primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"O numero {num1} é maior que o {num2}");
            }
            else
            {
                Console.WriteLine($"O numero {num2} é maior que o {num1}");
            }
            Console.ReadKey();
        }
    }
}
