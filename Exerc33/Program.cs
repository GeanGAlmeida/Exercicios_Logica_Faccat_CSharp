using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler dois valores e imprimir uma das três mensagens a seguir:
            ‘Números iguais’, caso os números sejam iguais
            ‘Primeiro é maior’, caso o primeiro seja maior que o segundo;
            ‘Segundo maior’, caso o segundo seja maior que o primeiro.*/

            Console.Write("Digite um numero qualquer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro numero qualquer: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Os numeros são iguais");
            }
            else if(num1 > num2)
            {
                Console.Write("O primeiro numero é o maior");
            }
            else
            {
                Console.Write("O segundo numero é o maior");
            }
            Console.ReadKey();
        }
    }
}
