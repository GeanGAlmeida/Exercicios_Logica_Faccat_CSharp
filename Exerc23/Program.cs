using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Qual sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Qual o seu sexo: ");
            string sexo = Console.ReadLine();
            sexo = sexo.ToUpper();
            if (sexo == "M")
            {
               double peso_ideial = 72.7 * altura - 58;
                Console.Write($"{nome} seu peso ideia é {peso_ideial}");
            }
            else
            {
               double peso_ideial = 62.1 * altura - 44.7;
                Console.Write($"{nome} seu peso ideia é {peso_ideial}");
            }
            Console.ReadKey();
        }
      }
   }
