using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_50
    {
        public void ExecutarExercicio_50()
        {
            //Faça um programa que leia as variáveis C e N, respectivamente código e número de
            //horas trabalhadas de um operário. E calcule o salário sabendo-se que ele
            //ganha R$ 10,00 por hora. Quando o número de horas exceder a 50, calcule o excesso
            //de pagamento armazenando-o na variável E, caso contrário zerar tal variável.
            //A hora excedente de trabalho vale R$ 20,00. No final do processamento imprimir o
            //salário total e o salário excedente. O programa só deve parar de rodar quando o
            //usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?". 

            string opcao;
            do
            {
                Console.Write("Digite o código do operário: ");
                string codigo = Console.ReadLine();

                Console.Write("Digite o número de horas trabalhadas: ");
                int horasTrabalhadas = int.Parse(Console.ReadLine());

                double salario = horasTrabalhadas * 10.0;
                double salarioExcedente = 0.0;

                if (horasTrabalhadas > 50)
                {
                    int horasExcedentes = horasTrabalhadas - 50;
                    salarioExcedente = horasExcedentes * 20.0;
                }

                Console.WriteLine($"O salário total do operário {codigo} é R$ {salario + salarioExcedente}");
                Console.WriteLine($"O salário excedente do operário {codigo} é R$ {salarioExcedente}");

                Console.Write("Deseja encerrar o programa (S/N)? ");
                opcao = Console.ReadLine();
            }
            while (opcao.ToUpper() != "S");

        }
    }
}
