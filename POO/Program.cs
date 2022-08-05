using System;
using System.Globalization;

namespace POO 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();


            Console.WriteLine("Entre os dados do produto: ");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Dados do produto: {p} ");

            //ADCIONAR PRODUTOS

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); 

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p );

            //REMOVER PRODUTOS

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido  do estoque: ");
             qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}