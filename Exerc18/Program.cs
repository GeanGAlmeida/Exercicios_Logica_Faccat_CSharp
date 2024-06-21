using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela
            poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).*/

            Console.Write("Qual o ano de seu nascimento: ");
            int ano_nascimento = int.Parse(Console.ReadLine());

            Console.Write("Qual é o ano atual: ");
            int ano_atual = int.Parse(Console.ReadLine());
            
            int idade = ano_atual - ano_nascimento;

            if (idade <= 16)
            {
                Console.WriteLine($"Você ainda tem {idade} anos, não pode votar");
            }
            else if (idade <= 17)
            {
                Console.WriteLine($"Você tem {idade} anos, seu voto é opcional");
            }
            else
            {
                Console.WriteLine($"Você já tem {idade} anos, seu voto é obrigatorio");
            }
            Console.ReadKey();
        }
    }
}
