using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_20
    {
        public void ExecutarExercicio_20()
        {
            //Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula: 
            // V = 3.14159 * R * R * A
            //Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.


            Console.Write("Digite o raio da lata de óleo: ");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da lata de óleo: ");
            double A = Convert.ToDouble(Console.ReadLine());

            // Calcula o volume da lata de óleo
            double V = 3.14159 * R * R * A;

            // Apresenta o resultado
            Console.WriteLine("\nO volume da lata de óleo é: " + V);
            Console.ReadKey();
        }

    }
}
