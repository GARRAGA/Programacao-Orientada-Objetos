using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_26
    {
        public void ExecutarExercicio_26()
        {
            //Escreva um programa que leia dois números e apresente a diferença do maior
            //para o menor. 


            Console.Write("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Calcula e apresenta a diferença do maior para o menor
            if (num1 > num2)
            {
                Console.WriteLine("\nA diferença do maior para o menor é: " + (num1 - num2));
            }
            else
            {
                Console.WriteLine("\nA diferença do maior para o menor é: " + (num2 - num1));
                Console.ReadKey();
            }
        }
    }
}
