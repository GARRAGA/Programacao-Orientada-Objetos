using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_25
    {
        public void ExecutarExercicio_25()
        {
            // Escreva um programa que leia 3 números inteiros e imprima na tela os valores em
            // ordem decrescente. 


            Console.Write("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Cria um array com os números
            int[] numeros = new int[] { num1, num2, num3 };

            // Ordena o array em ordem decrescente
            Array.Sort(numeros);
            Array.Reverse(numeros);

            // Imprime os números em ordem decrescente
            Console.WriteLine("\nNúmeros em ordem decrescente:");
            foreach (int num in numeros)
            Console.WriteLine(num);
            Console.ReadKey();  
        }
    }
}
