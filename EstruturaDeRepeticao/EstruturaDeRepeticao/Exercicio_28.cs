using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_28
    {
        public void ExecutarExercicio_28()
        {
            // Escreva um programa que leia dois números e exiba mensagem informando o valor
            // do maior número e o valor do 
            // menor número. Se os dois números forem iguais, o programa deve exibir
            // mensagem informando este fato.


            Console.Write("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("\nO maior número é: " + num1);
                Console.WriteLine("O menor número é: " + num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("\nO maior número é: " + num2);
                Console.WriteLine("O menor número é: " + num1);
            }
            else
            {
                Console.WriteLine("\nOs dois números são iguais.");
                Console.ReadKey();  
            }
        }
    }
}