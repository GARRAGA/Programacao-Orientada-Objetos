using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_37
    {
        public void ExecutarExercicio_37()
        {
            //

            Console.WriteLine("Digite sua altura em metros:");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu sexo (M para masculino, F para feminino):");
            char sexo = Convert.ToChar(Console.ReadLine().ToUpper());

            double pesoIdeal;

            if (sexo == 'M')
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else if (sexo == 'F')
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }
            else
            {
                Console.WriteLine("Sexo inválido.");
                return;
            }

            Console.WriteLine("Seu peso ideal é: " + pesoIdeal + " kg");

        }
    }
}
