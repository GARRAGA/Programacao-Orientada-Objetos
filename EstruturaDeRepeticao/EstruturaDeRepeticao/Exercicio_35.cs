using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_35
    {
        public void ExecutarExercicio_35()
        {
            // Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas: 
            //1 - Adição
            //2 - Subtração 3 - Multiplicação
            //4 - Divisão


            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Resultado: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Resultado: " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Resultado: " + (num1 * num2));
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine("Resultado: " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
                    
            }
        }

    }
    
}
