using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_45
    {
        public void ExecutarExercicio_45()
        {
            //Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma
            //em uma prova. O número de alunos é desconecido.Os dados de um Aluno são:
            //número de matrícula e a sua nota na prova em questão.

            int matricula;
            double nota;
            double somaNotas = 0;
            int contador = 0;

            Console.WriteLine("Digite os dados dos alunos (um número de matrícula negativo encerra o programa):");

            do
            {
                Console.Write("Número de matrícula: ");
                matricula = Convert.ToInt32(Console.ReadLine());

                if (matricula >= 0)
                {
                    Console.Write("Nota da prova: ");
                    nota = Convert.ToDouble(Console.ReadLine());

                    somaNotas += nota;
                    contador++;
                }
            } while (matricula >= 0);

            double media = somaNotas / contador;

            Console.WriteLine($"A média das notas dos alunos é {media}.");
            Console.ReadKey();
        }
    }
}
