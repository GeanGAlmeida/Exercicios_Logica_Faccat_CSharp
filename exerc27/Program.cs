using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler um valor e escrever se é positivo, negativo ou zero.

            Console.Write("Digite qualquer valor numerico: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("O numero digitado é igual a zero");
            }
            else if( num > 0 )
            {
                Console.WriteLine($"{num} é positivo");
            }
            else
            {
                Console.WriteLine($"{num} é negativo");
            }
            Console.ReadKey();
        }
    }
}
