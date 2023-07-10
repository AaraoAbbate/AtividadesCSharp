using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Atividadeclasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(idCliente: 1, nome: "rafa" , cpf: "03361406811");
            Produto produto = new Produto(idProduto: 1, nomeP: "camiseta",quantidade: "5", preco: 15);

            Vendas vendas = new Vendas(cliente, produto);
            Console.WriteLine("IdCliente: " + cliente.IdCliente);
            Console.WriteLine("Nome: " + cliente.Nome);
            Console.WriteLine("Cpf do cliente: " + cliente.CPF);
            Console.WriteLine("==============================");
            Console.WriteLine("Id do Produto: "+ produto.IdProduto);
            Console.WriteLine("Nome do produto: " + produto.Nomep);
            Console.WriteLine("Quantidade do produto: " + produto.quantidade);
            Console.WriteLine("Preço do Produto: " + produto.preco);

            Vendas venda = new Vendas(cliente, produto);
            double valorTotal = vendas.ValorTotal;
            Console.WriteLine("Valor Total: " + valorTotal);
        }
    }
}
