using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Uma fruteira está vendendo frutas com a seguinte tabela de preços:
            Até 5 Kg Acima de 5 Kg
            Morango R$ 2,50 por Kg R$ 2,20 por Kg
            Maçã R$ 1,80 por Kg R$ 1,50 por Kg
            Se o cliente comprar mais de 8 Kg em frutas ou o valor total da compra ultrapassar R$ 25,00, receberá
            ainda um desconto de 10% sobre este total. Escreva um algoritmo para ler a quantidade (em Kg) de
            morangos e a quantidade (em Kg) de maças adquiridas e escreva o valor a ser pago pelo cliente.*/

            Console.Write("Quantos quilos de morango voce comprou: ");
            double morango_quilo = double.Parse(Console.ReadLine());

            Console.Write("Quantos quilos de maçã voce comprou: ");
            double maca_quilo = double.Parse(Console.ReadLine());

            double preco_quilo_morango, preco_quilo_maca;

            if (morango_quilo <= 5)
            {
                preco_quilo_morango = morango_quilo * 2.50;
            }
            else
            {
                preco_quilo_morango = morango_quilo * 2.20;
            }
            if (maca_quilo <= 5)
            {
                preco_quilo_maca = maca_quilo * 1.80;
            }
            else
            {
                preco_quilo_maca = maca_quilo * 1.50;
            }

            double quilos_totais = maca_quilo + morango_quilo;
            double total_compra = preco_quilo_maca + preco_quilo_morango;
            double preco_final;

            if(quilos_totais > 8 || total_compra > 25)
            {
                preco_final = total_compra - (10d / 100d *total_compra);
                Console.WriteLine($"O preço final com desconto foi de R${preco_final}");
            }
            Console.ReadKey();
        }
    }
}
