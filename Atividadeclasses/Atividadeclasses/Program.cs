using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividadeclasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(quantidade: 10);
            Produto produto = new Produto(preco: 20);

            Vendas vendas = new Vendas(cliente, produto);
            Console.WriteLine(vendas.ValorTotal);
        }
    }
}
