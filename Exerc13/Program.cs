using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia três notas de um aluno, calcule e escreva a média final deste aluno.
            Considerar que a média é ponderada e que o peso das notas é 2, 3 e 5*/

            Console.Write("Informe a primeira nota do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota do aluno: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Informe a terceira nota do aluno: ");
            double nota3 = double.Parse(Console.ReadLine());

            double nota_final = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10;

            Console.WriteLine($"A nota final do aluno é {nota_final}");
            Console.ReadKey();
        }
    }
}
