using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**Faça um algoritmo para ler as 3 notas obtidas por um aluno nas 3 verificações e a média dos
            exercícios que fazem parte da avaliação. Calcular a média de aproveitamento, usando a fórmula abaixo
            e escrever o conceito do aluno de acordo com a tabela de conceitos mais abaixo:

                                                        N1 + N2 * 2 + N3 * 3 + Média_dos_Exercícios
                    Média_de_Aproveitamento =    ------------------------------------------------------
                                                                                7 */

            Console.Write("Qual é a nota maxima da primeira avaliação: ");
            double avaliacao1 = double.Parse(Console.ReadLine());
            Console.Write("Informe quanto o aluno tirou nessa avaliação: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Qual é a nota maxima da segunda avaliação: ");
            double avaliacao2 = double.Parse(Console.ReadLine());
            Console.Write("Informe quanto o aluno tirou nessa avaliação: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Qual é a nota maxima da terceira avaliação: ");
            double avaliacao3 = double.Parse(Console.ReadLine());
            Console.Write("Informe quanto o aluno tirou nessa avaliação: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media_exercicios = (nota1 + nota2 + nota3) / 3;

            double media_aproveitamento = (nota1 + nota2 * 2d + nota3 * 3 + media_exercicios) / 7;

            if (media_aproveitamento >= 9)
            {
                Console.WriteLine($"O aluno tirou A com uma media de {Math.Round(media_aproveitamento, 2)}");
            }
            else if (media_aproveitamento >= 7.5 && media_aproveitamento < 9)
            {
                Console.WriteLine($"O aluno tirou B com uma media de {Math.Round(media_aproveitamento, 2)}");
            }
            else if (media_aproveitamento >= 6.0 && media_aproveitamento < 7.5)
            {
                Console.WriteLine($"O aluno tirou C com uma media de {Math.Round(media_aproveitamento, 2)}");
            }
            else
            {
                Console.WriteLine($"O aluno tirou D com uma media de {Math.Round(media_aproveitamento, 2)}");
            }
            Console.ReadKey();
        }
    }
}
