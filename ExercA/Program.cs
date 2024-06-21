using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela) o seu antecessor.

            Console.Write("Digite um numero qualquer: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write($"O antecessor de {num} é ");
            Console.WriteLine(num - 1);
            Console.ReadKey();
        }
    }
}
