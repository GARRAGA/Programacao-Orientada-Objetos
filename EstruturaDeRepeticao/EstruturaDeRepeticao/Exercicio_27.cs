using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_27
    {
        public void ExecutarExercicio_27()
        {
            //Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma
            //mensagem que o aluno foi aprovado se o valor da média escolar for maior ou igual a 7.
            //Se o valor da média for menor que 7, solicitar a nota do recuperação, somar com o
            //valor da média e obter a nova média. Se a nova média for maior ou igual a 7,
            //apresentar uma mensagem informando que o aluno foi aprovado na recuperação.
            //Se o aluno não foi aprovado, apresentar uma mensagem informando esta condição.
            //Apresentar junto com as mensagens o valor da média do aluno. 


            double soma = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Digite a nota " + i + ": ");
                soma += Convert.ToDouble(Console.ReadLine());
            }

            double media = soma / 4;

            if (media >= 7)
            {
                Console.WriteLine("\nO aluno foi aprovado com média: " + media);
            }
            else
            {
                Console.Write("Digite a nota da recuperação: ");
                double notaRecuperacao = Convert.ToDouble(Console.ReadLine());

                double novaMedia = (media + notaRecuperacao) / 2;

                if (novaMedia >= 7)
                {
                    Console.WriteLine("\nO aluno foi aprovado na recuperação com média: " + novaMedia);
                }
                else
                {
                    Console.WriteLine("\nO aluno não foi aprovado. Média final: " + novaMedia);
                    Console.ReadKey();
                }

            }
        }
    }
}