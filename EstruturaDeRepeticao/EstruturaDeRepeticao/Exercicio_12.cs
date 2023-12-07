using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_12
    {
        public void ExecutarExercicio_12()
        {
            //vEscreva um algoritmo que leia o número de identificação, as 3 notas obtidas
            // por um aluno nas 3 verificações e a média dos exercícios que fazem parte da
            //avaliação, e calcule a média de aproveitamento, usando a fórmula:
            //MA = (nota1 + nota 2 * 2 + nota 3 * 3 + ME)/ 7
            //A atribuição dos conceitos obedece a tabela abaixo. O algoritmo deve escrever
            //o número do aluno, suas notas, a média dos exercícios, a média de
            //aproveitamento, o conceito correspondente e a mensagem 'Aprovado' se o
            //conceito for A, B ou C, e 'Reprovado' se o conceito for D ou E.
            //Média de aproveitamento Conceito
            //>= 90 A
            //>= 75 e < 90 B
            //>= 60 e < 75 C
            //>= 40 e < 60 D
            //>=40 E

            Console.Write("Digite o número de identificação do aluno: ");
            string id = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a média dos exercícios: ");
            double ME = Convert.ToDouble(Console.ReadLine());

            double MA = (nota1 + nota2 * 2 + nota3 * 3 + ME) / 7;
            string conceito;
            string mensagem;

            if (MA >= 90)
            {
                conceito = "A";
                mensagem = "Aprovado";
            }
            else if (MA >= 75)
            {
                conceito = "B";
                mensagem = "Aprovado";
            }
            else if (MA >= 60)
            {
                conceito = "C";
                mensagem = "Aprovado";
            }
            else if (MA >= 40)
            {
                conceito = "D";
                mensagem = "Reprovado";
            }
            else
            {
                conceito = "E";
                mensagem = "Reprovado";
            }

            Console.WriteLine($"Número do aluno: {id}");
            Console.WriteLine($"Notas: {nota1}, {nota2}, {nota3}");
            Console.WriteLine($"Média dos exercícios: {ME}");
            Console.WriteLine($"Média de aproveitamento: {MA}");
            Console.WriteLine($"Conceito: {conceito}");
            Console.WriteLine($"Resultado: {mensagem}");
        }
    }
    
}