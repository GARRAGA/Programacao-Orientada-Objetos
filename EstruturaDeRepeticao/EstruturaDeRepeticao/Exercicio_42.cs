using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_42
    {
        public void ExecutarExercicio_42()
        {
            //

            Console.Write("Digite um número para ver sua tabuada: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
                Console.ReadKey();
            }
        }
    }
}