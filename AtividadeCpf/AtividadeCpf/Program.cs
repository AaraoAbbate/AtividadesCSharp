using System;
using System.Linq;

namespace ValidadorCpf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] peso1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Console.Write("Digite o CPF (Apenas números): ");
            string cpf = Console.ReadLine();

            int[] numerosInteiros = cpf.Select(numero => Convert.ToInt32(numero.ToString())).ToArray();

            int soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += numerosInteiros[i] * peso1[i];
            }

            int resto = soma % 11;

            int primeiroDigitoVerificador = 0;
            if (resto < 2)
            {
                primeiroDigitoVerificador = 0;
            }
            else
            {
                primeiroDigitoVerificador = 11 - resto;
            }

            int[] peso2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma2 = 0;

            for (int i = 0; i < 10; i++)
            {
                soma2 += numerosInteiros[i] * peso2[i];
            }

            resto = soma2 % 11;
            int segundoDigitoVerificador = resto < 2 ? 0 : 11 - resto;

            Console.WriteLine("CPF válido!");

            Console.ReadLine();
        }
    }
}

