using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrietacaoObjeto
{
    internal class Biblioteca
    {
        public string Nome;
        public List<Livro> catalogo;

        public Biblioteca()
        {
            catalogo = new List<Livro>();
        }

        public void CadastrarLivro(Livro livro)
        {
            catalogo.Add(livro);
        }

        public void MostrarCatalogo()

        {
            Console.WriteLine("Catalogo de livros da Biblioteca: {0}", Nome);
            Console.WriteLine("===========================================");
            foreach (var livro in catalogo)
            {
                Console.Write("Identificação: {0} | {1} | preço: {2:c}", livro.IdLivro, livro.Titulo, livro.Preco);
            }
            Console.WriteLine("===========================================");
            Console.WriteLine("Total de livros: {0}", catalogo.Count());
        }
    }
}
