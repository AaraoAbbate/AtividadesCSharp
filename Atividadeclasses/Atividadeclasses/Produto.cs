using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividadeclasses
{
    internal class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string quantidade { get; set; }
        public double preco { get ; set; }

        public Produto(int idProduto = 0, string nome = "", string quantidade = "", double preco = 0)
        {
            IdProduto = idProduto;
            Nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }
        public void ImprimirDados()
        {
            Console.WriteLine("Dados do Produto");
            Console.WriteLine($"Id: {IdProduto} ");
            Console.WriteLine($"Nome {Nome}");
            Console.WriteLine($"Quantidade {quantidade}");
            Console.WriteLine($"Preço {preco}");
        }
    }
}
