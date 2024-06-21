using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler um valor e escrever a mensagem É MAIOR QUE 10! se o valor lido for maior que 10, caso
            contrário escrever NÃO É MAIOR QUE 10!*/

            Console.Write("Digite um valor qualquer: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 10)
            {
                Console.WriteLine("O valor é maior que 10");
            }
            else
            {
                Console.WriteLine("O valor e menor 10");
            }
            Console.ReadKey();
        }
    }
}
