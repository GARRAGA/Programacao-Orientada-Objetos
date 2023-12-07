using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_22
    {
        public void ExecutarExercicio_22()
        {
            // Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos
            //de ordem existentes entre eles.Os relacionamentos possiveis são: igual,Não igual,
           // Maior, Menor,Maior ou igual,Menor ou igual.


            Console.Write("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Os números são iguais.");
            }
            else
            {
                Console.WriteLine("Os números não são iguais.");

                if (num1 > num2)
                {
                    Console.WriteLine("O primeiro número é maior que o segundo.");
                }
                else
                {
                    Console.WriteLine("O primeiro número é menor que o segundo.");
                }

                if (num1 >= num2)
                {
                    Console.WriteLine("O primeiro número é maior ou igual ao segundo.");
                }
                else
                {
                    Console.WriteLine("O primeiro número é menor ou igual ao segundo.");
                    Console.ReadKey();

                }

            }
        }
    }
}    

