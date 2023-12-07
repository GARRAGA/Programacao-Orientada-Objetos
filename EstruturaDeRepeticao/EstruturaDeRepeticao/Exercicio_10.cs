using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_10
    {
        public void ExecutarExercicio_10()
        {
            //O IMC – Índice de Massa Corporal é um critério da Organização Mundial de
            // Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta.
            //A fórmula é: IMC = peso / (altura)2
            //Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua
            //condição de acordo com a tabela abaixo.
            //IMC em adultos Condição
            //Abaixo de 18,5 Abaixo do peso
            //Entre 18,5 e 25 Peso normal
            //Entre 25 e 30 Acima do peso
            //Acima de 30 obeso

            Console.Write("Digite seu peso em kg: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura em metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / Math.Pow(altura, 2);

            Console.WriteLine("Seu IMC é: " + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Condição: Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Condição: Acima do peso");
            }
            else
            {
                Console.WriteLine("Condição: Obeso");
            }
        }

    }
}
