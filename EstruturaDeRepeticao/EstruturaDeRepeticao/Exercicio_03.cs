using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EstruturaDeRepeticao
{
    public class Exercicio_03
    {
        public void ExecutarExercicio_03()
        {
            //Faça um algoritmo para receber um número qualquer e informe na tela se é par ou ímpar.


            Console.WriteLine("Informe um numero");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero é par!");
            }
            else
            {
                Console.WriteLine("O numero é impar!");
            }

           


        } 
    }
}
