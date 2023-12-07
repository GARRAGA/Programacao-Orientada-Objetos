using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_32
    {
        public void ExecutarExercicio_32()
        {
            // Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um
            // valor maior que zero para cada variável (se o valor digitado não é válido, mostrar
            // mensagem e ler novamente). Exibe o menor valor lido multiplicado pelo maior e o
            // maior valor dividido pelo menor. 


            int a = GetInput("a");
            int b = GetInput("b");
            int c = GetInput("c");

            int min = Math.Min(a, Math.Min(b, c));
            int max = Math.Max(a, Math.Max(b, c));

            Console.WriteLine("O menor valor multiplicado pelo maior é: " + min * max);
            Console.WriteLine("O maior valor dividido pelo menor é: " + (double)max / min);
        }

        static int GetInput(string varName)
        {
            int num;
            do
            {
                Console.Write("Digite um valor maior que zero para " + varName + ": ");
                num = int.Parse(Console.ReadLine());
            } while (num <= 0);
            return num;
            
        }
    }
}
