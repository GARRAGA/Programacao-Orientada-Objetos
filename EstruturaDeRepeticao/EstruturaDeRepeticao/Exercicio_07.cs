using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_07
    {
        public void ExecutarExercicio_07() 
        {
            //Faça um algoritmo que leia uma variável e some 5, caso seja par ou some 8,
            //caso seja ímpar, imprimir o resultado desta operação.

            int numero;
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                numero += 5;
            }
            else
            {
                numero += 8;
            }

            Console.WriteLine("O resultado é: " + numero);
            Console.ReadKey();
        }

    }
    

}
