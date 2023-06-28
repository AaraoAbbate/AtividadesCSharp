using System;
using System.Linq;





namespace testevalidcpf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] peso1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] peso2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };



            Console.WriteLine(@"

 


                ██╗░░░██╗░█████╗░██╗░░░░░██╗██████╗░░█████╗░██████╗░░█████╗░██████╗░  ░█████╗░██████╗░███████╗
                ██║░░░██║██╔══██╗██║░░░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗██╔════╝
                ╚██╗░██╔╝███████║██║░░░░░██║██║░░██║███████║██║░░██║██║░░██║██████╔╝  ██║░░╚═╝██████╔╝█████╗░░
                ░╚████╔╝░██╔══██║██║░░░░░██║██║░░██║██╔══██║██║░░██║██║░░██║██╔══██╗  ██║░░██╗██╔═══╝░██╔══╝░░
                ░░╚██╔╝░░██║░░██║███████╗██║██████╔╝██║░░██║██████╔╝╚█████╔╝██║░░██║  ╚█████╔╝██║░░░░░██║░░░░░
                ░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝  ░╚════╝░╚═╝░░░░░╚═╝░░░░░

 

                                                                                                                ");



            while (true)
            {
                Console.Write("Digite o CPF (apenas números) ou digite 'sair' para encerrar: ");
                string input = Console.ReadLine();





                if (input.ToLower() == "sair") // verifica se o usuario digitou "sair", tambem podendo escrever com Maiusculas
                {
                    break;
                }





                bool isNumeric = input.All(char.IsDigit); //int.Tryparse garante que o programa use apenas numeros / int pq a entrada sera numeros inteiros
                if (!isNumeric)
                {
                    Console.WriteLine("Entrada inválida. Digite apenas números.");
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    string cpf = input;





                    int[] numerosInteiro = new int[11];
                    for (int i = 0; i < cpf.Length; i++)
                    {
                        numerosInteiro[i] = Convert.ToInt32(cpf[i].ToString());
                    }





                    int soma1 = 0;
                    for (int i = 0; i < 9; i++)
                    {
                        soma1 += numerosInteiro[i] * peso1[i];
                    }
                    int resto1 = (soma1 * 10) % 11;





                    if (resto1 == 10)
                    {
                        resto1 = 0;
                    }



                    int soma2 = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        soma2 += numerosInteiro[i] * peso2[i];
                    }
                    int resto2 = (soma2 * 10) % 11;





                    if (resto2 == 10)
                    {
                        resto2 = 0;
                    }
                    string cpfFormatado = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";





                    if (resto1 == numerosInteiro[9] && resto2 == numerosInteiro[10])
                    {
                        Console.WriteLine("CPF válido: " + cpfFormatado);
                    }
                    else
                    {
                        Console.WriteLine("CPF inválido: " + cpfFormatado);
                    }



                }
            }
        }
    }
}
