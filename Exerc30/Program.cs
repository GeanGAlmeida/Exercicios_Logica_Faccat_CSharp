using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler 3 valores (considere que não serão informados valores iguais) e escrevê-los em ordem
            crescente.*/

            Console.Write("Informe o primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor: ");
            int num3 = int.Parse(Console.ReadLine());

            int maior_valor = Math.Max(num1, Math.Max(num2,num3));
            int menor_valor = Math.Min(num1, Math.Min(num2,num3));
            int valor_medio;
            if(num1 != maior_valor && num1 != menor_valor)
            {
                valor_medio = num1;
            }
            else if (num2 != maior_valor && num2 != menor_valor)
            {
                valor_medio = num2;
            }
            else
            {
                valor_medio = num3;
            }
            Console.WriteLine($"Os valores em ordem crescente são: {menor_valor} {valor_medio} {maior_valor}");
            Console.ReadKey();
        }
    }
}
