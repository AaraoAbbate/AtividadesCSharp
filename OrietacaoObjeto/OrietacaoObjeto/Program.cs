using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OrietacaoObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Livro livro = new Livro();

            livro.IdLivro = 1;
            livro.Titulo = "Assasin´s Creed Black Flag";
            livro.Autor = "Joseph Seed";
            livro.Preco = 19.90;
            livro.NumeroPaginas = 300;

            livro.Imprimirdetalhes();

            Livro livro2 = new Livro();

            livro2.IdLivro = 2;
            livro2.Titulo = "Orientação a Objetos C#";
            livro2.Autor = "Microsoft";
            livro2.Preco = 50;
            livro2.NumeroPaginas = 80;

            Console.WriteLine("Detalhes do Livro 2 ");

            livro2.Imprimirdetalhes();

            Livro livro3 = new Livro(3, "Excel", "Jorge",100,50.90);

            Livro livro4 = new Livro(idLivro:4, numeroPaginas: 20, titulo: "C#", autor : "Celso", preco : 40.90);

            livro3.Imprimirdetalhes();
            livro4.Imprimirdetalhes();

            Livro livro5 = new Livro()
            {
                IdLivro = 5,
                Titulo = "Senac Livro",
                NumeroPaginas= 50,
                Preco = 50,
                Autor = "Microsoft",


            };
            livro5.Imprimirdetalhes();
        }
    }
}
