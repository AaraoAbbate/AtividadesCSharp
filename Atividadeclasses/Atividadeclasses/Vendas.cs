using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividadeclasses
{
    internal class Vendas
    {
        public Cliente Cliente;
        public Produto Produto;
        public double ValorTotal { get { return Cliente.Quantidade * Produto.preco; } }

        public Vendas(Cliente cliente, Produto produto)
        {
            Cliente = cliente;
            Produto = produto;
        }
    }
}
