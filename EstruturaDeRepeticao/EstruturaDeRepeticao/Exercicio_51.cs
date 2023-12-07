using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_51
    {
        public void ExecutarExercicio_51()
        {
            //Faça um programa que leia um número inteiro e mostre uma mensagem indicando se este
            //número é par ou ímpar, e se é positivo ou negativo. O programa só deve parar de
            //rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o
            //programa?". 


            string opcao;
            do
            {
                Console.Write("Digite um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par.");
                }
                else
                {
                    Console.WriteLine("O número é ímpar.");
                }

                if (numero >= 0)
                {
                    Console.WriteLine("O número é positivo.");
                }
                else
                {
                    Console.WriteLine("O número é negativo.");
                }

                Console.Write("Deseja encerrar o programa (S/N)? ");
                opcao = Console.ReadLine();
            }
            while (opcao.ToUpper() != "S");
        }
    }
}
