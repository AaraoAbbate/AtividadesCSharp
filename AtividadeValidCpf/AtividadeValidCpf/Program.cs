using System;
using System.Linq;

namespace AtividadeValidCpf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] peso1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] soma1 = new int[9];
            string numero;

            Console.Write("Digite o CPF (Apenas números): ");
            string cpf = Console.ReadLine();

            int[] numerosInteiros = cpf.Select(d => Convert.ToInt32(d.ToString())).ToArray();

            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += numerosInteiros[i] * peso1[i];
            }

            int resto = soma % 11;
            int digito1 = 11 - resto;

            if (digito1 > 9)
            {
                digito1 = 0;
            }

            if (numerosInteiros[9] == digito1)
            {
                Console.WriteLine("Primeiro dígito verificado com sucesso!");
                // Continuar a validação do segundo dígito aqui...
            }
            else
            {
                Console.WriteLine("CPF inválido! Primeiro dígito verificado não corresponde.");
            }
        }
    }
}

