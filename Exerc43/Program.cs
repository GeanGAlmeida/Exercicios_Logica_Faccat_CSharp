using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero: ");
            int valorA = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            int valorB = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro numero: ");
            int valorC = int.Parse(Console.ReadLine());

            string mens;

            if (valorA < valorB + valorC && valorB < valorA + valorC && valorC < valorA + valorB)
            {
                if (valorA == valorB && valorB == valorC)
                {
                    mens = "Triângulo Equilátero";
                }
                else if (valorA == valorB || valorB == valorC || valorA == valorC)
                {
                    mens = "Triângulo Isósceles";
                }
                else
                {
                    mens = "Triângulo Escaleno";
                }
            }
            else
            {
                mens = "Não e possível formar um triângulo";
            }
            Console.WriteLine(mens);

            Console.ReadKey();
        }
    }
}
