using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace AppBiblioteca
{
    internal class Livro
    {
        public int id { get; set; }
        public string titulo;
        private int ano;
        private int numeroPaginas;

        public int Ano 
        {
            get { return ano; }
            set 
            {
                if (value > 0)
                {
                    ano = value;
                }
                else
                {
                    Console.WriteLine("Ano de publicação Inválido");
                }
            }
        }
        public int NumeroPaginas 
        {
            get { return numeroPaginas; }
            set
            {
                if (value > 0)
                {
                    numeroPaginas = value;
                }
                else
                {
                    Console.WriteLine("Numero de paginas Invalido");
                }
            }
        }

        public virtual void MostrarDetalhes()
        {
            Console.WriteLine("Id: {0}" , id);
            Console.WriteLine("Titulo: {0}" , titulo);
            Console.WriteLine("Ano: {0}" , ano);
            Console.WriteLine("Numero de Paginas: {0}" , numeroPaginas);
        }

    }
}
