using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_04
    {
        public void ExecutarExercicio_04()
        {
            //Faça um algoritmo que leia dois valores inteiros A e B se os valores forem iguais devera
            // se somar os dois, caso contrario multiplique A por B.Ao final de qualquer um dos calculos
            // deve-se atribuir o resultado para uma variavel C e mostrar seu conteúdo  na tela.

            int a = 0;
            int b = 0;
            int c = 0;

            Console.WriteLine("informe o primeiro valor: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                c = a + b;
                Console.WriteLine("o valor da soma de A + B é: " + c);
            } else
            {
                c = a * b;
                Console.WriteLine("o valor da multiplicação de A * B é: " + c);
            }
            
            Console.ReadKey();
        }

    }

}
