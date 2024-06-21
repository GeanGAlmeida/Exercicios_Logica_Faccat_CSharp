using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc35
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual tipo de combustivel escolhido (G-Gasolina, A-Alcool): ");
            string combustivel = Console.ReadLine();
            combustivel = combustivel.ToUpper();

            Console.Write("Digite quantos litros deseja colocar: ");
            int litros_combustiveis = int.Parse(Console.ReadLine());

            if (combustivel == "G")
            {
                if (litros_combustiveis <= 20)
                {
                    double desconto = 3.30 - (3 / 100.0 * 3.30);
                    double litros_totais = litros_combustiveis * desconto;
                    Console.WriteLine($"O cliente colocou {litros_combustiveis} litros e pagou no total R${litros_totais}");
                }
                else
                {
                    double desconto = 3.30 - (5 / 100.0 * 3.30);
                    double litros_totais = litros_combustiveis * desconto;
                    Console.WriteLine($"O cliente colocou {litros_combustiveis} litros e pagou no total R${litros_totais}");
                }
            }
            else if (combustivel == "A")
            {
                if (litros_combustiveis <= 20)
                {
                    double desconto = 2.90 - (4 / 100.0 * 2.90);
                    double litros_totais = litros_combustiveis * desconto;
                    Console.WriteLine($"O cliente colocou {litros_combustiveis} litros e pagou no total R${litros_totais}");
                }
                else
                {
                    double desconto = 2.90 - (6 / 100.0 * 2.90);
                    double litros_totais = litros_combustiveis * desconto;
                    Console.WriteLine($"O cliente colocou {litros_combustiveis} litros e pagou no total R${litros_totais}");
                }
            }
            Console.ReadKey();
        }
    }
}
