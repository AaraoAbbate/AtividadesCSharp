using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();
            livro.id = 1;
            livro.titulo = "Harry Potter";
            livro.Ano = 2001;
            livro.NumeroPaginas = 20;

            livro.MostrarDetalhes();

            Console.WriteLine("========================================");

            LivroDigital livroDigital = new LivroDigital();

            livroDigital.id = 2;
            livroDigital.titulo = "Assassin's Creed Black Flag ";
            livroDigital.Ano = 2009;
            livroDigital.NumeroPaginas = 30;

            livroDigital.MostrarDetalhes();

        }
    }
}
