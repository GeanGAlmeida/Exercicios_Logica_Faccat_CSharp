using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*O custo de um carro novo ao consumidor é a soma do custo de fábrica com a porcentagem do
            distribuidor e dos impostos (aplicados ao custo de fábrica). Supondo que o percentual do distribuidor
            seja de 28% e os impostos de 45%, escrever um algoritmo para ler o custo de fábrica de um carro,
            calcular e escrever o custo final ao consumidor.*/

            Console.Write("Digite o valor de fabrica do carro: ");
            double preco_fabrica = double.Parse(Console.ReadLine());

            double preco_final = preco_fabrica + ((28d / 100d + 45d / 100d) * preco_fabrica);

            Console.Write(preco_final);
            Console.ReadKey();
        }
    }
}
