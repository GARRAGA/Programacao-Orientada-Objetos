using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_36
    {
        public void ExecutarExercicio_36()
        {
            //

            Console.WriteLine("Digite o primeiro número inteiro:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Verificar se um dos números é múltiplo do outro");
            Console.WriteLine("2 - Verificar se os dois números são pares");
            Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
            Console.WriteLine("4 - Sair");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    if (num1 % num2 == 0 || num2 % num1 == 0)
                    {
                        Console.WriteLine("Um dos números é múltiplo do outro.");
                    }
                    else
                    {
                        Console.WriteLine("Nenhum dos números é múltiplo do outro.");
                    }
                    break;
                case 2:
                    if (num1 % 2 == 0 && num2 % 2 == 0)
                    {
                        Console.WriteLine("Ambos os números são pares.");
                    }
                    else
                    {
                        Console.WriteLine("Ambos os números não são pares.");
                    }
                    break;
                case 3:
                    if ((num1 + num2) / 2.0 >= 7)
                    {
                        Console.WriteLine("A média dos dois números é maior ou igual a 7.");
                    }
                    else
                    {
                        Console.WriteLine("A média dos dois números é menor que 7.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;

            }
        }
    }
}

