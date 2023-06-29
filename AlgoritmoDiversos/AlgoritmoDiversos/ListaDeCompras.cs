using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDiversos
{
    internal class ListaDeCompras
    {
        static void Main()
        {
            List<string> listaDeCompras = new List<string>();

            Console.WriteLine("::::::::  Programa de lista de compras  ::::::::");

            while (true)
            {
                Console.Write("Digite um item para adicionar (ou 'parar'para sair ): ");

                string item = Console.ReadLine().Trim();

                if (item.ToLower() == "parar")
                {
                    break;
                }
                listaDeCompras.Add(item);
                Console.WriteLine("Item adicionado com sucesso!");

            }
            Console.WriteLine("-----Sua lista de Compras-----");
            //Imprimir a lista, porem caso esteja vazia, retornar o texto "A lista esta Vazia"
            //caso contrario imprimir todos os itens na tela

            if (listaDeCompras.Count == 0)
            {
                Console.WriteLine("A lista esta vazia");
            }
            else
            {
                foreach(string item in listaDeCompras)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
