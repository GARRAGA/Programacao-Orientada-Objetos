using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_48
    {
        public void ExecutarExercicio_48()
        {
            // Faça um programa que leia 10 valores inteiros e positivos e: 

            //Encontre o maior valor

            //Encontre o menor valor

            //Calcule a média dos números lidos  

            int[] numeros = new int[10];
            int soma = 0, maior = int.MinValue, menor = int.MaxValue;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número inteiro e positivo: ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }

                soma += numeros[i];
            }

            double media = soma / 10.0;

            Console.WriteLine($"O maior número é {maior}");
            Console.WriteLine($"O menor número é {menor}");
            Console.WriteLine($"A média dos números é {media}");

        }
    }
}
