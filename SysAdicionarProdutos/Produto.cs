using System;
using System.Globalization;

namespace SysAdicionarProdutos
{
    internal class Produto
    {
        public string Nome {get; set;}
        public double Preco { get; set;}
        public int Quantidade { get; set;}

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double Total()
        {
            double total = Quantidade * Preco;

            return total;
        }

        public override string ToString()
        {
            string dados = "Nome: " + Nome + " | Preço: " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " | Quantidade: " + Quantidade + " | Valor total: " + Total().ToString("F2", CultureInfo.InvariantCulture);

            return dados;
        }
    }
}
