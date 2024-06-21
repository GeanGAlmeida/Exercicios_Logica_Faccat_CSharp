using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os
            minutos) e calcule a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é
            de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte.*/

            Console.Write("Qual foi o horario do inicio da partida: ");
            double hora_inicio = double.Parse(Console.ReadLine());

            Console.Write("Qual a hora do fim da partida: ");
            double hora_fim = double.Parse(Console.ReadLine());

            double hora_jogo;

            if (hora_fim > hora_inicio)
            {
                hora_jogo = hora_fim - hora_inicio;
                Console.WriteLine($"O jogo durou no total {hora_jogo} horas");
            }
            else
            {
                hora_jogo = hora_fim - hora_inicio + 24;
                Console.WriteLine($"O jogo durou no total {hora_jogo} horas");
            }
            Console.ReadKey();
        }
    }
}
