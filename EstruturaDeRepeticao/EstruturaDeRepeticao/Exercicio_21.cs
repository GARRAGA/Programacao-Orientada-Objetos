using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_21
    {
        public void ExecutarExercicio_21()
        {
            //Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e
            //escreva a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias
            //e mês com 30 dias. 

            Console.Write("Digite a idade em anos: ");
            int anos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade em meses: ");
            int meses = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade em dias: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            // Calcula a idade total em dias
            int idadeEmDias = anos * 365 + meses * 30 + dias;

            // Apresenta o resultado
            Console.WriteLine("\nA idade expressa em dias é: " + idadeEmDias);
            Console.ReadKey();

        }

    }
}
