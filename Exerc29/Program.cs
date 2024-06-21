using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler 3 valores (considere que não serão informados valores iguais) e escrever a soma dos 2
            maiores.*/

            Console.Write("Informe o primeiro valor: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor: ");
            int num3 = int.Parse(Console.ReadLine());

            int maiorValor = Math.Max(num1, Math.Max(num2, num3));
            int segundo_maior_valor;

            if (maiorValor == num1)
            {
                segundo_maior_valor = Math.Max(num2, num3);
            }
            else if(maiorValor == num2)
            {
                segundo_maior_valor = Math.Max(num1, num3);
            }
            else
            {
                segundo_maior_valor = Math.Max(num2, num1);
            }
            int soma = maiorValor + segundo_maior_valor;
            Console.WriteLine($"A soma do primeiro maior valor = {maiorValor} com o segundo maior valor = {segundo_maior_valor} é {soma}");

            Console.ReadKey();

            
        }
    }
}
