using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_39
    {
       public void ExecutarExercicio_39()
        {
            //Escreva um programa que leia: a quantidade de números que deve processa:  
            //os números que deverá processar,e calcule e exiba, para cada número a ser 
            //processado o seu fatorial. Lembrete: O fatorial de um número N é dado pela
            // fórmula: N != 1 * 2 * 3 * 4 * 5 * ... *N


            Console.Write("Digite a quantidade de números que deseja processar: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                long fatorial = Fatorial(numero);

                Console.WriteLine("O fatorial de " + numero + " é " + fatorial);
            }
        }

        static long Fatorial(int numero)
        {
            long fatorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }
            return fatorial;
            
        }
    }
}
