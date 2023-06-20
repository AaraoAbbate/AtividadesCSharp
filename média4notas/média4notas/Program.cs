using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace média4notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, numero3, numero4, media;

            Console.WriteLine("============================");
            Console.WriteLine("::     Calcular Média     ::");
            Console.WriteLine("============================");

            Console.WriteLine("Digite a primeira nota: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            numero3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            numero4 = Convert.ToDouble(Console.ReadLine());

            

            media = (numero1 + numero2 + numero3 + numero4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("O aluno foi aprovado: ");

            }
            else
            {
                Console.WriteLine("Aluno reprovado: ");
            }

            Console.WriteLine("A média é: " + media);

            



        }
    }
}
