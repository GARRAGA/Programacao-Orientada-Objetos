using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_54
    {
        public void ExecutarExercicio_54()
        {
            //Faça um programa que determine o maior e o menor entre N números lidos. A condição
            //de parada é a entrada de 
            //um valor 0, ou seja, o programa deve ficar executando até que a entrada seja igual
            //a 0(ZERO).


            int number;
            int max = int.MinValue;
            int min = int.MaxValue;

            Console.WriteLine("Insira um número (0 para parar):");

            do
            {
                number = Convert.ToInt32(Console.ReadLine());

                if (number != 0)
                {
                    if (number > max)
                    {
                        max = number;
                    }

                    if (number < min)
                    {
                        min = number;
                    }
                }
            }
            while (number != 0);

            Console.WriteLine("O maior número inserido foi: " + max);
            Console.WriteLine("O menor número inserido foi: " + min);
            Console.ReadKey();
        }
    }
}
