using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_31
    {
        public void ExecutarExercico_31()
        {
            //vEscreva um programa que leia três valores para os lados de um triângulo (variáveis A, B
            //e C). Verificar se cada lado é menor que a soma dos outros dois lados. Se sim, saber de
            //A==B e se B==C, sendo verdade o triângulo é eqüilátero; Se não, verificar de A==B ou se
            //A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso contrário, o triângulo se
            //rá escaleno. Caso os lados fornecidos não caracterizarem um triângulo,avisar a ocorrencia.


            Console.Write("Digite o valor do lado A: ");
            double A = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            double B = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");
            double C = double.Parse(Console.ReadLine());

            if (A < B + C && B < A + C && C < A + B)
            {
                if (A == B && B == C)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os valores fornecidos não formam um triângulo.");

            }
        }
    }
}