using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{        
    public class Exercicio_06
    {
        public void ExecutarExercicio_06()
        {
            // Escreva um algortimo que lê dois volores boleanos (lógitos)e então determina se ambos são;
            // VERDADEIROS OU FALSOS.

            bool valor1, valor2;

            Console.WriteLine("Digite o primeiro valor booleano (true/false):");
            valor1 = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor booleano (true/false):");
            valor2 = Convert.ToBoolean(Console.ReadLine());

            if (valor1 && valor2)
            {
                Console.WriteLine("Ambos os valores são verdadeiros.");
            }
            else if (!valor1 && !valor2)
            {
                Console.WriteLine("Ambos os valores são falsos.");
            }
            else
            {
                Console.WriteLine("Os valores são diferentes.");

            }
            Console.ReadKey();
        }
    }
}


        

    

