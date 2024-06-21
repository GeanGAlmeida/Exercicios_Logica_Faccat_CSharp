using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais
            de 40 horas receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50%.
            Escreva um algoritmo que leia o número de horas trabalhadas em um mês, o salário por hora e escreva
            o salário total do funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas
            (considere que o mês possua 4 semanas exatas).*/

            Console.Write("Quantas horas foram trabalhadas no mês: ");
            int horas_trabalhadas = int.Parse(Console.ReadLine());

            Console.Write("Qual o valor pela hora trabalhada: ");
            double valor_hora = double.Parse(Console.ReadLine());

            int hora_minima = 40 * 4;

            if (horas_trabalhadas > hora_minima)
            {
                double hora_extra = horas_trabalhadas - hora_minima;
                double salario_final = valor_hora * horas_trabalhadas + (hora_extra * (valor_hora * 0.5));
                Console.WriteLine($"O salario é de R${salario_final}");
            }
            else
            {
                double salario_final =  horas_trabalhadas * valor_hora;
                Console.WriteLine($"O salario é de R${salario_final}");
            }
            Console.ReadKey();
        }
    }
}
