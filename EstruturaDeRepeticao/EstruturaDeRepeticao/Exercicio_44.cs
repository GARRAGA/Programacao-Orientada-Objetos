using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_44
    {
        public void ExecutarExercicio_44()
        {
            //Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos 
            //ímpares a partir do número informado pelo usuário menor que 10 e maior que zero. 

            Console.Write("Digite um número inteiro positivo menor que 10 e maior que zero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0 || num >= 10)
            {
                Console.WriteLine("Número inválido. O número deve ser menor que 10 e maior que zero.");
                return;
            }

            int count = 0;
            int soma = 0;

            while (count < 20)
            {
                if (num % 2 != 0)
                {
                    soma += num * num;
                    count++;
                }
                num++;
            }

            Console.WriteLine($"A soma dos quadrados dos 20 primeiros números ímpares a partir do número informado é {soma}.");
            Console.ReadKey();
        }
    }
}
