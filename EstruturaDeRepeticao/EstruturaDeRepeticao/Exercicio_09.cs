using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_09
    {
        public void ExecutarExercicio_09()
        {
            //Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um
            //algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
            //● para homens: (72.7 * h) – 58;
            //● para mulheres: (62.1 * h) – 44.7.


            Console.Write("Digite sua altura em metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seu sexo (M para masculino, F para feminino): ");
            char sexo = Convert.ToChar(Console.ReadLine().ToUpper());

            double pesoIdeal;

            if (sexo == 'M')
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else if (sexo == 'F')
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }
            else
            {
                Console.WriteLine("Sexo inválido.");
                return;
            }

            Console.WriteLine("Seu peso ideal é: " + pesoIdeal + " kg");
        }


    }

}