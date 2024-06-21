using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o preço
            unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o desconto e o total
            a pagar (total a pagar = total - desconto), sabendo-se que:
            - Se quantidade <= 5 o desconto será de 2%
            - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
            - Se quantidade > 10 o desconto será de 5%*/

            Console.Write("Qual o nome do produto: ");
            string nome_produto = Console.ReadLine();

            Console.Write("Quanto foi a quantidade adquirida: ");
            int quantidade_adquirida = int.Parse(Console.ReadLine());

            Console.Write("Qual é o preço unitário dos produtos: ");
            double preco_unitario = double.Parse(Console.ReadLine());

            double total = quantidade_adquirida * preco_unitario;

            double total_pagar;

            if (quantidade_adquirida <= 5)
            {
                total_pagar = total - (2d / 100 * total);
            }
            else if (quantidade_adquirida > 5 && quantidade_adquirida <= 10)
            {
                total_pagar = total - (3d / 100 * total);
            }
            else
            {
                total_pagar = total - (5d / 100 * total);
            }
            Console.WriteLine($"O total a pagar com já com o desconto incluso é: {total_pagar}");
            Console.ReadKey(); 
        }
    }
}
