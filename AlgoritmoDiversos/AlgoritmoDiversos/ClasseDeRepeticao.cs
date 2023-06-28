using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDiversos
{
    internal class ClasseDeRepeticao
    {
        static void Main()
        {
            Console.WriteLine("======= Laço de Repetição =======");

            int contador = 0;

            while (contador <= 5)
            {
                Console.WriteLine("O valor do contador é : "+ contador);
                contador++;
            }
            EscreveLinha();

             

            for (contador = 0; contador <= 5; contador++)
            {
                Console.WriteLine("O valor do contador é "+ contador);
            }
            for (int i = 0; i <= 5; i++);

            EscreveLinha();

            do
            {
                Console.WriteLine("\"O valor do contador é " + contador);
                contador++;
            } while (contador <= 5);

            string[] frutas = { "Maçã", "Banana", "Laranja", "Tomate" };

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine(frutas[i]);
            }

            EscreveLinha();

            foreach(string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            EscreveLinha();
           
        }
        static void EscreveLinha() 
        {
            Console.WriteLine("=======================================");
        }
        


    }  

}
