using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_33
    {
        public void ExecutarExercicio_33()
        {
            //

            Console.Write("Digite um número inteiro (ou 'sair' para encerrar): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "sair")
            if (input.ToLower() == " v") 
            {
                
            }

            int num = Convert.ToInt32(input);
            if (num > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (num < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");

            }
        }
    }
}
