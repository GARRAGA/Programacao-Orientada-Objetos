using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_08
    {
        public void ExecutarExercicio_08()
        {
            //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os
            //em ordem decrescente.

            Console.Write("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int[] numeros = { num1, num2, num3 };
            Array.Sort(numeros);
            Array.Reverse(numeros);

            Console.WriteLine("Os números em ordem decrescente são: " + numeros[0] + ", " + numeros[1] + ", " + numeros[2]);
        }

    }

    
}
