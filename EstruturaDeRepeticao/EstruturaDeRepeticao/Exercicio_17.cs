using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_17
    {
        public void ExecutarExercicio_17()
        {
            //Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando
            //um automóvel que faz 12 Km por litro. Para obter o cálculo, o usuário deve fornecer o
            //tempo gasto na viagem e a velocidade média. Desta forma, será possível obter a distância
            //percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE. Tendo o valor da distância,
            //basta calcular a quantidade de litros de combustível utilizada na viagem com a fórmula:
            //LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade
            //média, tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem.
            //Dica: trabalhe com valores reais. 

            Console.Write("Digite o tempo gasto na viagem (em horas): ");
            double tempo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a velocidade média durante a viagem (em km/h): ");
            double velocidade = Convert.ToDouble(Console.ReadLine());

            // Calcula a distância percorrida
            double distancia = tempo * velocidade;

            // Calcula a quantidade de litros de combustível utilizada na viagem
            double litros_usados = distancia / 12;

            // Apresenta os resultados
            Console.WriteLine("\nResultados:");
            Console.WriteLine("Velocidade média: " + velocidade + " km/h");
            Console.WriteLine("Tempo gasto: " + tempo + " horas");
            Console.WriteLine("Distância percorrida: " + distancia + " km");
            Console.WriteLine("Quantidade de litros utilizada na viagem: " + litros_usados + " litros");
            Console.ReadKey();
        }

    }
}
