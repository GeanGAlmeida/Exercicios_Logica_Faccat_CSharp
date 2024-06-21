using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler 3 valores (considere que não serão informados valores iguais) e escrever o maior deles.
            Console.Write("Informe o primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor: ");
            int num3 = int.Parse(Console.ReadLine());

            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"Numero {num1} é o maior numero");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"Numero {num2} é o maior numero");
            }
            else
            {
                Console.WriteLine($"Numero {num3} é o maior numero");
            }
            Console.ReadKey();

            //int valorMinimo = Math.Max(num1, Math.Max(num2, num3));
        }
    }
}
