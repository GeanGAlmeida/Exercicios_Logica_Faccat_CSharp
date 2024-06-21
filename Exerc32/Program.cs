using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc32
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Ler o nome de 2 times e o número de gols marcados na partida (para cada time). Escrever o nome
do vencedor. Caso não haja vencedor deverá ser impressa a palavra EMPATE.*/

            Console.Write("Qual o nome do primeiro time: ");
            string nome_time1 = Console.ReadLine();

            Console.Write("Qual o nome do segundo time: ");
            string nome_time2 = Console.ReadLine();

            Console.Write($"Quantos gols o {nome_time1} fez: ");
            int gols_time1 = int.Parse(Console.ReadLine());

            Console.Write($"Quantos gols o {nome_time2} fez: ");
            int gols_time2 = int.Parse(Console.ReadLine());
            Console.Clear();

            if (gols_time1 == gols_time2)
            {
                Console.WriteLine($"O placar foi de {gols_time1} X {gols_time2}, deu empate");
            }
            else if (gols_time1 > gols_time2)
            {
                Console.WriteLine($"O {nome_time1} ganho de {gols_time1} X {gols_time2} do {nome_time2}");
            }
            else
            {
                Console.WriteLine($"O {nome_time2} ganho de {gols_time2} X {gols_time1} do {nome_time1}");
            }
            Console.ReadKey();
        }
    }
}
