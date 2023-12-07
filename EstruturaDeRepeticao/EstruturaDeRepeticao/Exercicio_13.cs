using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_13
    {
        public void ExecutarExercicio_13()
        {
            //Faça um programa para calcular o estoque médio de uma peça, sendo que: 
            //ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE MÁXIMA) / 2.


                        Console.Write("Digite a quantidade mínima em estoque: ");
        double quantidadeMinima = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quantidade máxima em estoque: ");
        double quantidadeMaxima = Convert.ToDouble(Console.ReadLine());

        double estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2;

        Console.WriteLine($"O estoque médio é: {estoqueMedio}");
        Console.ReadKey();
        }
    }
}
