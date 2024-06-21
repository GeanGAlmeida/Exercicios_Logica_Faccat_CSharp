using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Exerc24
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*Ler o salário fixo e o valor das vendas efetuadas pelo vendedor de uma empresa. Sabendo-se que
ele recebe uma comissão de 3% sobre o total das vendas até R$ 1.500,00 mais 5% sobre o que
ultrapassar este valor, calcular e escrever o seu salário total.*/

            Console.Write("Qual é o salario fixo do funcionario: ");
            double salario_fixo = double.Parse(Console.ReadLine());

            Console.Write("Qual o valor das vendas totais do vendedor da empresa: ");
            double vendas_empresa = double.Parse(Console.ReadLine());

            if (vendas_empresa > 1500)
            {
                double salario_total = salario_fixo + (5d / 100d * salario_fixo);
                Console.WriteLine($"O salario total do funcionario é R${salario_total}");
            }
            else
            {
                double salario_total = salario_fixo + (3d / 100d * salario_fixo);
                Console.WriteLine($"O salario total do funcionario é R${salario_total}");
            }
            Console.ReadKey();
        }
    }
}
