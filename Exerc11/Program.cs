using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por mês,
            mais uma comissão também fixa para cada carro vendido e mais 5% do valor das vendas por ele
            efetuadas. Escrever um algoritmo que leia o número de carros por ele vendidos, o valor total de suas
            vendas, o salário fixo e o valor que ele recebe por carro vendido. Calcule e escreva o salário final do
            vendedor.*/

            Console.Write("Quantos carros o funcionario vendeu: ");
            int carros_vendidos = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor total de suas vendas: ");
            double valor_total = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor da comissão fixa do funcionario: ");
            double valor_comissao = double.Parse(Console.ReadLine());

            Console.Write("Qual o salario fixo do funcionario: ");
            double salario_fixo = double.Parse(Console.ReadLine());

            double ganho_valor_total = valor_total * 5d / 100d;

            double salario_final = ganho_valor_total + salario_fixo + valor_comissao;

            Console.WriteLine($"O salario final do funcionario é R${salario_final}");
            Console.ReadKey();
        }
    }
}
