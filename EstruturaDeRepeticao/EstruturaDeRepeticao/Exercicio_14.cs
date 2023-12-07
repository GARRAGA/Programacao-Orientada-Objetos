using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_14
    {
        public void ExecutarExercicio_14()
        {
            // Faça um programa que:  -Leia a cotação do dólar Leia um valor em dólares
            //Converta esse valor para Real
            //Mostre o resultado

            Console.Write("Digite a cotação do dólar: ");
            double cotacaoDolar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um valor em dólares: ");
            double valorDolar = Convert.ToDouble(Console.ReadLine());

            double valorReal = valorDolar * cotacaoDolar;

            Console.WriteLine($"O valor convertido para real é: {valorReal}");
            Console.ReadKey();
        }

    }
    
}
