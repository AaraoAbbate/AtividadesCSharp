using System;
using System.Linq;

namespace testevalidcnpj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] peso1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] peso2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            /*
                foi preciso ajustar os arrays de peso cpf(11) digitos e cnpj(14) digitos.

                
             */

            while (true)
            {
                Console.Write("Digite o CNPJ (apenas números) ou digite 'sair' para encerrar: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "sair") // verifica se o usuário digitou "sair", também podendo escrever com maiúsculas
                {
                    break;
                }

                bool isNumeric = input.All(char.IsDigit);
                if (!isNumeric || input.Length != 14)
                /* o CNPJ é composto por 14 dígitos. Portanto, foi adicionada                                            
                 uma nova verificação para garantir
                 que a entrada tenha exatamente 14 dígitos 
                 usando a condição input.Length != 14 */

                {
                    Console.WriteLine("Entrada inválida. Digite apenas 14 números.");
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    string cnpj = input;

                    int[] numerosInteiro = new int[14];
                    for (int i = 0; i < cnpj.Length; i++)
                    {
                        numerosInteiro[i] = Convert.ToInt32(cnpj[i].ToString());
                    }

                    int soma1 = 0;
                    for (int i = 0; i < 12; i++)
                    {
                        soma1 += numerosInteiro[i] * peso1[i];
                    }
                    int resto1 = (soma1 % 11);
                    resto1 = resto1 < 2 ? 0 : 11 - resto1;

                    int soma2 = 0;
                    for (int i = 0; i < 13; i++)
                    {
                        soma2 += numerosInteiro[i] * peso2[i];
                    }
                    int resto2 = (soma2 % 11);
                    resto2 = resto2 < 2 ? 0 : 11 - resto2;

                    string cnpjFormatado = $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12, 2)}";

                    if (resto1 == numerosInteiro[12] && resto2 == numerosInteiro[13])
                    {
                        Console.WriteLine("CNPJ válido: " + cnpjFormatado);
                    }
                    else
                    {
                        Console.WriteLine("CNPJ inválido: " + cnpjFormatado);
                    }
                    
                }
            }
        }
    }
}


