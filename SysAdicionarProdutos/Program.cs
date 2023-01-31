using System;
using System.Globalization;

namespace SysAdicionarProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.Write("Quantos produtos deseja adicionar?: ");
            int quantidadeAdd = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[quantidadeAdd];

            for (int i = 0; i < quantidadeAdd; i++)
            {
                int numero = i + 1;
                Console.WriteLine("Digite as informações do produto #" + numero);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                vect[i] = new Produto(nome, preco, quantidade);
            }

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Dados dos produtos: ");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            for (int i = 0; i < quantidadeAdd; i++)
            {
                int numero = i + 1;
                Console.WriteLine();
                Console.WriteLine("Produto #" + numero + ":");
                Console.WriteLine(vect[i]);
                Console.WriteLine();
            }
        }
    }
}
