using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_18
    {
        public void ExecutarExercicio_18()
        {
            //Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.
            //A fórmula de conversão de temperatura a ser utilizada é F = (9* C + 160) / 5, em que a
            //variável F representa é a temperatura em graus Fahrenheit e a variável C representa é a
            //temperatura em graus Celsius. 

            Console.Write("Digite a temperatura em graus Celsius: ");
            double C = Convert.ToDouble(Console.ReadLine());

            // Calcula a temperatura em graus Fahrenheit
            double F = (9 * C + 160) / 5;

            // Apresenta o resultado
            Console.WriteLine("\nA temperatura em graus Fahrenheit é: " + F);
            Console.ReadKey();
        }
    }
}
