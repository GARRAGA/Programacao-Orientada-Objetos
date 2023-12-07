using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_24
    { 
        public void ExecutarExercicio_24()
        {
            // Escreva um programa que leia um número inteiro e exiba o seu módulo. 
            //O módulo de um número x é:x se x e maior ou igual a zero x * (-1) se x e menor que zero.


            Console.Write("Digite um número inteiro: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Calcula o módulo do número
            int modulo = num >= 0 ? num : num * -1;

            // Apresenta o resultado
            Console.WriteLine("\nO módulo do número é: " + modulo);
            Console.ReadKey();
        }
    }
}
