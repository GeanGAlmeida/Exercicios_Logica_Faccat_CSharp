using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo para ler um número que é um código de usuário. Caso este código seja
            diferente de um código armazenado internamente no algoritmo (igual a 1234) deve ser apresentada a
            mensagem ‘Usuário inválido!’. Caso o Código seja correto, deve ser lido outro valor que é a senha. Se
            esta senha estiver incorreta (a certa é 9999) deve ser mostrada a mensagem ‘senha incorreta’. Caso a
            senha esteja correta, deve ser mostrada a mensagem ‘Acesso permitido’.*/

            Console.Write("Digite o codigo do usuário: ");
            int cod_usuario = int.Parse(Console.ReadLine());

            int senha;

            if (cod_usuario != 1234)
            {
                Console.WriteLine("Usuário inválido");
            }
            else
            {
                Console.Write("Digite sua senha: ");
                senha = int.Parse(Console.ReadLine());
                if (senha == 9999)
                {
                    Console.WriteLine("Acesso permitido");
                }
                else
                {
                    Console.WriteLine("Senha incorreta");
                }
            }
            Console.ReadKey();
        }
    }
}
