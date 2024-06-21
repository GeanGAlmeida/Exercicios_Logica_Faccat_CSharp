using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**Faça um algoritmo para ler: quantidade atual em estoque, quantidade máxima em estoque e
quantidade mínima em estoque de um produto. Calcular e escrever a quantidade média ((quantidade
média = quantidade máxima + quantidade mínima)/2). Se a quantidade em estoque for maior ou igual
a quantidade média escrever a mensagem 'Não efetuar compra', senão escrever a mensagem 'Efetuar
compra'. */

            Console.Write("Qual a quantidade do estoque atual: ");
            int estoque_atual = int.Parse(Console.ReadLine());

            Console.Write("Qual a quantidade maxima: ");
            int quantidade_maxima = int.Parse(Console.ReadLine());

            Console.Write("Qual a quantidade mínima: ");
            int quantidade_minima = int.Parse(Console.ReadLine());

            double quantidade_media = (quantidade_maxima + quantidade_minima) / 2;

            if (estoque_atual >= quantidade_media)
            {
                Console.WriteLine("Não é necessario efetuar compras de novos produtos");
            }
            else
            {
                Console.WriteLine("É necessario efetuar compras de novos produtos");
            }
            Console.ReadKey();
        }
    }
}
