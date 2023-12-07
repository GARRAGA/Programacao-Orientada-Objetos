using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_29
    {
        public void ExecutarExercicio_29()
        {
            // Escreva um programa que leia um número inteiro. Verificar por meio de condição
            // se o valor fornecido está na faixa entre 0 (zero) e 9 (nove). Caso o valor
            // fornecido esteja dentro da faixa, apresentar a mensagem "valor válido".
            // Caso contrário, apresentar a mensagem "valor inválido". 


            Console.Write("Digite um número inteiro: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0 && num <= 9)
            {
                Console.WriteLine("Valor válido");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }
    }
}