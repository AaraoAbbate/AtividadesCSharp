using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeC_4numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, numero3, numero4, média, total;

            Console.WriteLine("============================");
            Console.WriteLine("::     Calcular Média     ::");
            Console.WriteLine("============================");

            Console.WriteLine("Digite número 1: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite número 2: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite número 3: ");
            numero3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite número 4: ");
            numero4 = Convert.ToDouble(Console.ReadLine());

            média = (numero1 + numero2 + numero3 + numero4) / 4;
            total = (numero1 + numero2 + numero3 + numero4);

            Console.WriteLine("a média é:" + média);

            Console.WriteLine("============================");







        }   
            


    }
}
