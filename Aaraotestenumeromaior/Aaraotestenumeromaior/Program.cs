using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aaraoteste
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo númeo: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            int maior = numero1;

            if (numero2 > maior)
            {
                maior = numero2;
            }
            if (numero3 > maior)
            {
                maior = numero3;
            }
            Console.WriteLine("O maior número é: " + maior);












        }

    }
}
