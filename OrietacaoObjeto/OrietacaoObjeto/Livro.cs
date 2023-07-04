using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrietacaoObjeto
{
    internal class Livro
    {
        public int IdLivro;
        public string Titulo;
        public string Autor;
        public int NumeroPaginas;
        public double Preco;

        public Livro(int idLivro = 0, string titulo = "", string autor = "", int numeroPaginas = 0, double preco = 0) 
        {                           
            IdLivro = idLivro;
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
            Preco = preco;
        }
        // colocar a primeia letra minuscula para não precisar criar novas variaveis com nomes diferentes
        // coloca = 0 

        public void Imprimirdetalhes()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Identificação: {0}", IdLivro);
            Console.WriteLine("Titulo: {0}", Titulo);
            Console.WriteLine("Autor: {0}", Autor);
            Console.WriteLine("Numero de Paginas: {0}", NumeroPaginas);
            Console.WriteLine("Preço: {0:c}", Preco);
            Console.WriteLine("========================");
        }

    }
}
