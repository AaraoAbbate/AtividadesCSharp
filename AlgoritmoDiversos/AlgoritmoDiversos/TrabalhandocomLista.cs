using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDiversos
{
    internal class TrabalhandocomLista
    {
        static void Imprimelista(List<int> lista, string titulo = "============") 
        {
            Console.WriteLine("========="+titulo+"=============");
            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }
        }

        static void Main()
        {
            //Add: Adiciona elemento na lista
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(90);
            lista.Add(50);
            lista.Add(10);
            lista.Add(40);
            lista.Add(70);

            Imprimelista(lista, "adicionando Elemento na lista");

           
            
            lista.Remove(10);

            Imprimelista(lista, "remove: remove a primeira ocorrencia de um elemento da lista");
             
           

            lista.RemoveAt(0);

            Imprimelista(lista, "remove o elemento de um indice");

            Imprimelista(lista);

            //Sort: Ordenar os elementos em ordem crescente
            lista.Sort();
            Imprimelista(lista, "Ordena lista");

            //Reverse: Ordenar os elementos em ordem decrescente
            lista.Reverse();
            Imprimelista(lista, "Ordem Decrescente");

            //Count: Retorna a quantidade de elementos na lista
            int numeroItem = lista.Count();
            Console.WriteLine("Existe uma {0} itens na lista", numeroItem);

            //Contains: Verifica se a lista contem um determinado elemento

            if (lista.Contains(40))
            {
                Console.WriteLine("foi encontrado o item na lista");
            }
            else
            {
                Console.WriteLine("Não foi encontrado nenhum item na lista");
            }

            //Insert: Insere um elemento em um determinado indice na lista

            lista.Insert(2, 45);

            Imprimelista(lista, "Ordem Decrescente");

            // Clear: limapr os itens da lista
            lista.Clear();

        }





    }
}
