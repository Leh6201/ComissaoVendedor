using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComissaoVendedor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Comissão de Vendedores");

            // Solicitar informações
            Console.Write("Digite a identificação do vendedor: ");
            string identificacaoVendedor = Console.ReadLine();

            Console.Write("Digite o código da peça: ");
            string codigoPeca = Console.ReadLine();

            Console.Write("Digite o preço unitário da peça: ");
            double precoUnitario = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade vendida: ");
            int quantidadeVendida = int.Parse(Console.ReadLine());

            // Calcular comissão
            double totalVenda = precoUnitario * quantidadeVendida;
            double comissao = totalVenda * 0.05;

            // Exibir resultados
            Console.WriteLine("\nDetalhes da Venda:");
            Console.WriteLine($"Identificação do vendedor: {identificacaoVendedor}");
            Console.WriteLine($"Código da peça: {codigoPeca}");
            Console.WriteLine($"Preço unitário da peça: R${precoUnitario:F2}");
            Console.WriteLine($"Quantidade vendida: {quantidadeVendida}");
            Console.WriteLine($"Total da venda: R${totalVenda:F2}");
            Console.WriteLine($"Comissão do vendedor (5%): R${comissao:F2}");
        }
    }
}

