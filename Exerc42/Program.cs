using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o codigo do funcionario: ");
            int cod_funcionario = int.Parse(Console.ReadLine());

            Console.Write("Informe o ano de nascimento do funcionario: ");
            int ano_nascimento = int.Parse(Console.ReadLine());

            Console.Write("Informe o ano de ingresso do funcionario: ");
            int ano_ingresso = int.Parse(Console.ReadLine());

            int ano_atual = 2024;

            int idade = ano_atual - ano_nascimento;
            int tempo_trabalho = ano_atual - ano_ingresso;

            if (idade >= 65 || tempo_trabalho >= 30 || idade >= 60 && tempo_trabalho >= 30)
            {
                Console.WriteLine($"O funcionario {cod_funcionario} tem {idade} anos de idade e {tempo_trabalho} de tempo de trabalho");
                Console.WriteLine("Ele esta apto a se aposentar");
            }
            else
            {
                Console.WriteLine($"O funcionario {cod_funcionario} tem {idade} anos de idade e {tempo_trabalho} de tempo de trabalho");
                Console.WriteLine("Ele não esta apto a se aposentar");
            }
            Console.ReadKey();
        }
    }
}
