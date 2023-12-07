using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_16
    {
        public void ExecutarExercicio_16()
        {
            //Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e
            //multiplicação entre os valores lidos, baseando-se na utilização do conceito de proprie
            //dade distributiva. Dica: se forem lidas as variáveis A, B, C e D, devem ser somados e mul
            //tiplicados os valores de A com B, A com C e A com D; depois B com C, B com D e por último
            //C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo
            //devem ser realizadas doze operações de processamento, sendo seis para as adições e seis
            //para as multiplicações. 


            Console.Write("Digite o primeiro número: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int C = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o quarto número: ");
            int D = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nResultados das adições:");
            Console.WriteLine("A + B = " + (A + B));
            Console.WriteLine("A + C = " + (A + C));
            Console.WriteLine("A + D = " + (A + D));
            Console.WriteLine("B + C = " + (B + C));
            Console.WriteLine("B + D = " + (B + D));
            Console.WriteLine("C + D = " + (C + D));

            Console.WriteLine("\nResultados das multiplicações:");
            Console.WriteLine("A * B = " + (A * B));
            Console.WriteLine("A * C = " + (A * C));
            Console.WriteLine("A * D = " + (A * D));
            Console.WriteLine("B * C = " + (B * C));
            Console.WriteLine("B * D = " + (B * D));
            Console.WriteLine("C * D = " + (C * D));
            Console.ReadKey();  
        }
    }

    
}
