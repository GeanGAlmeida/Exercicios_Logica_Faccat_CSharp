using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade
dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias*/

            Console.Write("Informe quantos anos voce tem: ");
            int ano_nascimento = int.Parse(Console.ReadLine());

            Console.Write("Digite quantos meses passaram desde do seu ultimo aniverdario: ");
            int mes_aniverdario = int.Parse(Console.ReadLine());

            Console.Write("Digite quantos dias passou desde do seu ultimo mêsversario: ");
            int dias = int.Parse(Console.ReadLine());

            int totais_dias = ano_nascimento * 365 + mes_aniverdario * 30 + dias;

            Console.WriteLine($"Voce tem {totais_dias} dias de vida.");
            Console.ReadKey();
        }
    }
}
