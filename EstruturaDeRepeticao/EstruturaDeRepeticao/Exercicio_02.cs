using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_02   
    {
         public void ExecutarExercicio_02()
        {
            //Faça um algoritmo que leia o nome,o sexo e o estado civilde uma pessoa.
            //Caso sexo seja "F" e estado civil "CASADA",solicitar o tempo de casada(anos).

            string nome;
            string sexo;
            string estadoCivil;
            int tempoDeCasado;

            Console.WriteLine("Informe o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o sexo: M OU F");
            sexo = Console.ReadLine().ToUpper();

            Console.WriteLine("Informe o estado civil: ");
            estadoCivil = Console.ReadLine().ToUpper();

            if(sexo == "F" && estadoCivil == "CASADA")
            {
                Console.WriteLine("Informe o tempo de casada: ");
                tempoDeCasado = int.Parse(Console.ReadLine());

                Console.WriteLine("O seu nome é " + nome + " e o seu tempo de casada é: " + tempoDeCasado + " anos." );
            } else
            {
                Console.WriteLine("O seu nome é " + nome + " o sexo é: " +  sexo);
            }






        }
    }
}
