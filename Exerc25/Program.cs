using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo para ler: número da conta do cliente, saldo, débito e crédito. Após, calcular e
            escrever o saldo atual (saldo atual = saldo - débito + crédito). Também testar se saldo atual for maior
            ou igual a zero escrever a mensagem 'Saldo Positivo', senão escrever a mensagem 'Saldo Negativo'.*/

            Console.Write("Qual o numero da conta do cliente: ");
            int numero_conta = int.Parse(Console.ReadLine());

            Console.Write("Qual o saldo da conta: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Qual o débito da conta: ");
            double debito = double.Parse(Console.ReadLine());

            Console.Write("Qual o crédito da conta: ");
            double credito = double.Parse(Console.ReadLine());

            double saldo_atual = saldo - debito + credito;

            if (saldo_atual >= 0)
            {
                Console.WriteLine($"O cliente {numero_conta} esta com saldo positivo com R${saldo_atual}");
            }
            else
            {
                Console.WriteLine($"O cliente {numero_conta} esta com saldo negativo com R${saldo_atual}");
            }
            Console.ReadKey();
        }
    }
}
