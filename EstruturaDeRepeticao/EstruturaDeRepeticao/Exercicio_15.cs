using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    public class Exercicio_15
    {
        public void ExecutarExercicio_15()
        {
            // Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua 
            //comissão será de 5 % do total da venda e que você tem os seguintes dados:
            //Identificação do vendedo, Código da peço,Preço unitário da peça Quantidade vendida


            Console.Write("Digite a identificação do vendedor: ");
            string idVendedor = Console.ReadLine();

            Console.Write("Digite o código da peça: ");
            string codigoPeca = Console.ReadLine();

            Console.Write("Digite o preço unitário da peça: ");
            double precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade vendida: ");
            int quantidadeVendida = Convert.ToInt32(Console.ReadLine());

            double totalVenda = precoUnitario * quantidadeVendida;
            double comissao = totalVenda * 0.05;

            Console.WriteLine($"Identificação do vendedor: {idVendedor}");
            Console.WriteLine($"Código da peça: {codigoPeca}");
            Console.WriteLine($"Preço unitário da peça: {precoUnitario}");
            Console.WriteLine($"Quantidade vendida: {quantidadeVendida}");
            Console.WriteLine($"Total da venda: {totalVenda}");
            Console.WriteLine($"Comissão do vendedor: {comissao}");
            Console.ReadKey();
        }
    }
}

