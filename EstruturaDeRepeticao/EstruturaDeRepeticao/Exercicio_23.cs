using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_23
    {
        public void ExecutarExercicio_23()

        {
            //Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos valores de
            //modo que a variável A passe a 
            //possuir o valor da variável B, e a variável B passe a possuir o valor da variável A.
            //Apresentar os valores trocados. 


            Console.Write("Digite o valor para a variável A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor para a variável B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            // Realiza a troca de valores
            int temp = A;
            A = B;
            B = temp;

            // Apresenta os valores trocados
            Console.WriteLine("\nValores trocados:");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.ReadKey();
        }

    }
}
