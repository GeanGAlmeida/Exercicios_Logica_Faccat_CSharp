using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo que leia as idades de 2 homens e de 2 mulheres (considere que as idades
            dos homens serão sempre diferentes entre si, bem como as das mulheres). Calcule e escreva a soma
            das idades do homem mais velho com a mulher mais nova, e o produto das idades do homem mais
            novo com a mulher mais velha.*/

            Console.Write("Qual idade do primeiro rapaz: ");
            int idade_rapaz_1 = int.Parse(Console.ReadLine());

            Console.Write("Qual idade do segundo rapaz: ");
            int idade_rapaz_2 = int.Parse(Console.ReadLine());

            Console.Write("Qual idade do primeira moça: ");
            int idade_moca_1 = int.Parse(Console.ReadLine());

            Console.Write("Qual idade do segundo moça: ");
            int idade_moca_2 = int.Parse(Console.ReadLine());

            int soma = Math.Max(idade_rapaz_1, idade_rapaz_2) + Math.Min(idade_moca_1, idade_moca_2);
            int mult = Math.Min(idade_rapaz_1, idade_rapaz_2) * Math.Max(idade_moca_1, idade_moca_2);

            Console.WriteLine($"{soma} {mult}");

            Console.ReadKey();
        }
    }
}
