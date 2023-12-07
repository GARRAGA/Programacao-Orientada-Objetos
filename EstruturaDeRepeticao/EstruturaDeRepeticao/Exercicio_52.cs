using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_52
    {
        public void ExecutarExercicio_52()
        {
            // A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03 grupos de
            // indústrias que são altamente poluentes do meio ambiente. O índice de poluição
            // aceitável varia de 0,05 até 0,25. Se o índice sobe para 0,3 as indústrias do 1o
            // grupo são intimadas a suspenderem suas atividades, se o índice crescer para 0,4 as
            // industrias do 1o e 2o grupo são intimadas a suspenderem suas atividades, se o
            // índice atingir 0,5 todos os grupos devem ser notificados a paralisarem suas
            // atividades. Faça um programa que leia o índice de poluição medido e emita a
            // notificação adequada aos diferentes grupos de empresas. O algoritmo só deve parar
            // de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o
            // programa?". 

            string opcao;
            do
            {
                Console.Write("Digite o índice de poluição: ");
                double indice = double.Parse(Console.ReadLine());

                if (indice >= 0.05 && indice <= 0.25)
                {
                    Console.WriteLine("Índice de poluição aceitável.");
                }
                else if (indice >= 0.3 && indice < 0.4)
                {
                    Console.WriteLine("As indústrias do 1o grupo devem suspender suas atividades.");
                }
                else if (indice >= 0.4 && indice < 0.5)
                {
                    Console.WriteLine("As indústrias do 1o e 2o grupo devem suspender suas atividades.");
                }
                else if (indice >= 0.5)
                {
                    Console.WriteLine("Todos os grupos devem paralisar suas atividades.");
                }
                else
                {
                    Console.WriteLine("Índice de poluição abaixo do aceitável.");
                }

                Console.Write("Deseja encerrar o programa (S/N)? ");
                opcao = Console.ReadLine();
            }
            while (opcao.ToUpper() != "S");

        }
    }
}
