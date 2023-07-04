using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrietacaoObjeto
{
    internal class AppBiblioteca
    {
        static void Main()
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Nome = "Senac Marilia";

            Livro livro = new Livro();

            livro.IdLivro = 1;
            livro.Titulo = "Assasin´s Creed Black Flag";
            livro.Autor = "Joseph Seed";
            livro.Preco = 19.90;
            livro.NumeroPaginas = 300;

            biblioteca.CadastrarLivro(livro);
            

            Livro livro2 = new Livro();

            livro2.IdLivro = 2;
            livro2.Titulo = "Orientação a Objetos C#";
            livro2.Autor = "Microsoft";
            livro2.Preco = 50;
            livro2.NumeroPaginas = 80;

           biblioteca.CadastrarLivro(livro2);
            biblioteca.MostrarCatalogo();
        }
    }
}
