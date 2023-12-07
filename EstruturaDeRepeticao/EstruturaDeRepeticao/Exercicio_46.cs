using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public  class Exercicio_46
    {
        public void ExecutarExercicio_46()
        {
            //Escreva um programa que leia um conjunto de números positivos e exiba o menor e o
            //maior. Suporemos que o número de elementos deste conjunto não é conhecido, e que um
            //número negativo será utilizado para sinalizar o fim dos dados. 

            int num;
            int menor = int.MaxValue;
            int maior = int.MinValue;

            Console.WriteLine("Digite números positivos (um número negativo encerra o programa):");

            do
            {
                num = Convert.ToInt32(Console.ReadLine());

                if (num >= 0)
                {
                    if (num < menor)
                    {
                        menor = num;
                    }

                    if (num > maior)
                    {
                        maior = num;
                    }
                }
            } while (num >= 0);

            Console.WriteLine($"O menor número é {menor}.");
            Console.WriteLine($"O maior número é {maior}.");
            Console.ReadKey();

        }
    }
}
