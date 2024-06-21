using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem
            compradas pelo menos 12. Escreva um programa que leia o número de maçãs compradas, calcule e
            escreva o custo total da compra.*/

            Console.Write("Quantas maças foram compradas: ");
            int maca_compradas = int.Parse(Console.ReadLine());
            double preco_total;

            if (maca_compradas <= 12)
            {
                preco_total = maca_compradas * 1.30;
                Console.WriteLine($"O preço total por {maca_compradas} é R${preco_total}");
            }
            else
            {
                Console.WriteLine($"O preço total por {maca_compradas} é R${maca_compradas}");
            }
            Console.ReadKey();
        }
    }
}
