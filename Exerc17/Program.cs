using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler as notas da 1a. e 2a. avaliações de um aluno. Calcular a média aritmética simples e escrever
            uma mensagem que diga se o aluno foi ou não aprovado (considerar que nota igual ou maior que 6 o
            aluno é aprovado). Escrever também a média calculada.*/

            Console.Write("Informe a 1º nota do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a 2º nota do aluno: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media_aritmetica = (nota1 + nota2) / 2d;

            if (media_aritmetica >= 6)
            {
                Console.WriteLine($"O aluno foi aprovado com nota {media_aritmetica}");
            }
            else
            {
                Console.WriteLine($"O aluno foi reprovado com nota {media_aritmetica}");
            }
            Console.ReadKey();
        }
    }
}
