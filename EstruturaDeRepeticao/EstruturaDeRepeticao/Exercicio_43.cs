using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public  class Exercicio_43
    {
        public void ExecutarExercicio_43()
        {
            //

            int num;
            int somaPares = 0;
            int somaImpares = 0;

            Console.WriteLine("Digite números positivos (um número negativo encerra o programa):");

            do
            {
                num = Convert.ToInt32(Console.ReadLine());

                if (num >= 0)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine($"O número {num} é par.");
                        somaPares += num;
                    }
                    else
                    {
                        Console.WriteLine($"O número {num} é ímpar.");
                        somaImpares += num;
                    }
                }
            } while (num >= 0);

            Console.WriteLine($"A soma dos números pares é {somaPares}.");
            Console.WriteLine($"A soma dos números ímpares é {somaImpares}.");
            Console.ReadKey();

        }
    }
}
