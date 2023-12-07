using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_01
    {
        public void ExecutarExercicio_01()
        {
            //Faça um algoritmo que leia os valores A,B,C e imprima na tela a soma de A + B é menor que C;

            Console.WriteLine("Digite o valor de A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            int C = int.Parse(Console.ReadLine());


            if ((A + B) < C)
            {
                Console.WriteLine("A soma de A + B é menor que C ");
            }
            else
            {
                Console.WriteLine("A soma de A + B é maior que C ");
            }
            Console.ReadKey();
        }
    }
}





