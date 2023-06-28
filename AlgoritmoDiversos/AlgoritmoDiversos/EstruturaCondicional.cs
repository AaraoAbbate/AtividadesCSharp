using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDiversos
{
    internal class EstruturaCondicional
    {

        static void Main()
        {

            Console.WriteLine("======= Estrutura condicional =======");

            int nota = 8;
            // Estrutura simples 
            if (nota >= 7)
            {
                Console.WriteLine("Aluno Aprovado");
            }

            Console.WriteLine("=====================================");

            // Estrutura Composta  
            if (nota >= 7)
            {
                Console.WriteLine("Aluno Aprovado");
            } else

            {
                Console.WriteLine("Aluno Reprovado");
            }
            Console.WriteLine("======================================");

            if (nota >= 9)
            {
                Console.WriteLine("Aluno nota A");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("Aluno nota B");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("Aluno nota C");
            }
            else if (nota >= 2)
            {
                Console.WriteLine("Aluno nota D");
            }
            else 
            {
                Console.WriteLine("Aluno nota E");
            }
            Console.WriteLine("===========================================");

            string cor = "Vermelho";

            switch (cor.ToLower())
            {
                case "verde":
                    Console.WriteLine("A cor é Verde");
                    break;

                case "azul":
                    Console.WriteLine("A cor é Azul");
                    break;
                case "vermelho":
                    Console.WriteLine("A cor é vermelho");
                    break;

                default:
                    Console.WriteLine("A cor não foi reconhecida");
                    break;
            }
        }      
            



    }
}
