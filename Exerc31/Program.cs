using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler 3 valores (A, B e C) representando as medidas dos lados de um triângulo e escrever se formam
            ou não um triângulo. OBS: para formar um triângulo, o valor de cada lado deve ser menor que a soma
            dos outros 2 lados.*/

            Console.Write("Informe o primeiro valor: ");
            int ladoA = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            int ladoB = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor: ");
            int ladoC = int.Parse(Console.ReadLine());

            if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
            {
                Console.WriteLine("Os valores formam um triângulo");
            }
            else
            {
                Console.WriteLine("Os valores não formam um triângulo");
            }
            Console.ReadKey();
        }
    }
}
