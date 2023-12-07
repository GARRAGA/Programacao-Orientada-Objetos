using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_19
    {
        public void ExecutarExercicio_19()
        {
            //Ler uma temperatura em graus Fahrenheit e apresentá-la convertida em graus Celsius.
            //A fórmula de conversão de temperatura a ser utilizada é C = (F - 32) * 5/9, em que
            //a variável F é a temperatura em graus Fahrenheit e a variável C é a temperatura
            //em graus Celsius. 


            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            double F = Convert.ToDouble(Console.ReadLine());

            // Calcula a temperatura em graus Celsius
            double C = (F - 32) * 5 / 9;

            // Apresenta o resultado
            Console.WriteLine("\nA temperatura em graus Celsius é: " + C);
            Console.ReadKey();
        }
    }
    
}
