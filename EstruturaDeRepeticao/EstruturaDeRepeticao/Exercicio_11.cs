using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_11
    {
        public void ExecutarExercicio_11()
        {
            //Elabore um algoritmo que calcule o que deve ser pago por um produto,
            //considerando o preço normal de etiqueta e a escolha da condição de pagamento.
            //Utilize os códigos da tabela a seguir para ler qual a condição de pagamento
            //escolhida e efetuar o cálculo adequado.
            //Código Condição de pagamento
            //1 À vista em dinheiro ou cheque, recebe 10 % de desconto
            //2 À vista no cartão de crédito, recebe 15 % de desconto
            //3 Em duas vezes, preço normal de etiqueta sem juros
            //4 Em duas vezes, preço normal de etiqueta mais juros de 10 %

            Console.Write("Digite o preço normal do produto: ");
            double precoNormal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escolha a condição de pagamento (1, 2, 3, ou 4): ");
            int condicaoPagamento = Convert.ToInt32(Console.ReadLine());

            double precoFinal;

            switch (condicaoPagamento)
            {
                case 1:
                    precoFinal = precoNormal * 0.9;  // 10% de desconto
                    break;
                case 2:
                    precoFinal = precoNormal * 0.85;  // 15% de desconto
                    break;
                case 3:
                    precoFinal = precoNormal;  // sem juros
                    break;
                case 4:
                    precoFinal = precoNormal * 1.1;  // 10% de juros
                    break;
                default:
                    Console.WriteLine("Condição de pagamento inválida.");
                    return;
            }

            Console.WriteLine("O preço final do produto é: " + precoFinal);
            Console.ReadKey();
        }
    }
}
    

