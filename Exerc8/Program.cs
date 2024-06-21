using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo para ler o número total de eleitores de um município, o número de votos
brancos, nulos e válidos. Calcular e escrever o percentual que cada um representa em relação ao total
de eleitores.*/

            Console.Write("Quantos foram os votos totais de municipio: ");
            int votos_municipio = int.Parse(Console.ReadLine());

            Console.Write("Quantos foram os votos em brancos: ");
            int votos_branco = int.Parse(Console.ReadLine());

            Console.Write("Quantos foram os votos nulos: ");
            int votos_nulos = int.Parse(Console.ReadLine());

            Console.Write("Quantos foram os votos válidos: ");
            int votos_validos = int.Parse(Console.ReadLine());

            //testando as conversões
            double percentual_branco = Convert.ToDouble(votos_branco) / votos_municipio * 100;
            double percentual_nulos = (double)votos_nulos / votos_municipio * 100d;
            double percentual_validos = (double)votos_validos / votos_municipio * 100d;

            Console.WriteLine($"O percentual de votos brancos é {Math.Round(percentual_branco, 2)}%");
            Console.WriteLine($"O percentual de votos nulos é {Math.Round(percentual_nulos, 2)}%");
            Console.WriteLine($"O percentual de votos validos é {Math.Round(percentual_validos, 2)}%");
            Console.ReadKey();
        }
    }
}
