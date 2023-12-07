using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_40
    {
        public void ExecutarExercicio_40()
        {
            //

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                }
            }
        }
    }
}
