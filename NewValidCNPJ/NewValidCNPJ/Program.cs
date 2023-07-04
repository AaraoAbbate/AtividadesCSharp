using System;
using System.Linq;





namespace testevalidcnpj
{
    internal class Program
    {
        static void Main(string[] args)
        {   /* o CNPJ é composto por 14 dígitos. Portanto, foi adicionada                                            
                 uma nova verificação para garantir
                 que a entrada tenha exatamente 14 dígitos 
                 usando a condição input.Length != 14 */



            int[] peso1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };     
            int[] peso2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };




            Console.WriteLine(@"

 

            ██╗░░░██╗░█████╗░██╗░░░░░██╗██████╗░░█████╗░██████╗░░█████╗░██████╗░  ░█████╗░███╗░░██╗██████╗░░░░░░██╗
            ██║░░░██║██╔══██╗██║░░░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗████╗░██║██╔══██╗░░░░░██║
            ╚██╗░██╔╝███████║██║░░░░░██║██║░░██║███████║██║░░██║██║░░██║██████╔╝  ██║░░╚═╝██╔██╗██║██████╔╝░░░░░██║
            ░╚████╔╝░██╔══██║██║░░░░░██║██║░░██║██╔══██║██║░░██║██║░░██║██╔══██╗  ██║░░██╗██║╚████║██╔═══╝░██╗░░██║
            ░░╚██╔╝░░██║░░██║███████╗██║██████╔╝██║░░██║██████╔╝╚█████╔╝██║░░██║  ╚█████╔╝██║░╚███║██║░░░░░╚█████╔╝
            ░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝  ░╚════╝░╚═╝░░╚══╝╚═╝░░░░░░╚════╝░
                                                                                                                     ");




            while (true)
            {
                Console.Write("Digite o CNPJ (apenas números) ou digite 'sair' para encerrar: ");
                string input = Console.ReadLine();





                if (input.ToLower() == "sair") // verifica se o usuário digitou "sair", também podendo escrever com maiúsculas
                {
                    break;               // O programa ficara em loop enquanto o usuario digitar sair
                }



                bool isNumeric = input.All(char.IsDigit);



                //verifica se a entrada do usuário contém apenas dígitos numéricos e possui um comprimento de 14 caracteres.



                if (!isNumeric || input.Length != 14)



                {
                    Console.WriteLine("Entrada inválida. Digite apenas 14 números.");
                    Console.WriteLine();
                    continue;
                }             // caso o usuario digite qualquer coisa alem de 14 caracteres numericos, a mensagem sera exibida
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
                    /*
                     A (?) é chamada de operador condicional ternário
                     Essa linha verifica se a variável resto1 é menor que 2. 
                     Se for verdadeiro, o valor atribuído a resto1 é 0. 
                     Caso contrário, o valor atribuído é o complemento de 11 
                     pelo valor de resto1 (ou seja, 11 - resto1).
                     */



                    int soma2 = 0;
                    for (int i = 0; i < 13; i++)
                    {
                        soma2 += numerosInteiro[i] * peso2[i];
                    }
                    int resto2 = (soma2 % 11);
                    resto2 = resto2 < 2 ? 0 : 11 - resto2;





                    string cnpjFormatado = $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12, 2)}";
                    // Essa linha formata o CNPJ inserindo pontos e traços nos locais apropriados, e armazena o valor formatado na variável cnpjFormatado.




                    if (resto1 == numerosInteiro[12] && resto2 == numerosInteiro[13])



                    /*
                     Aqui, verifica se os digitos verificadores 
                     calculados correspondem aos digitos digitados pelo usuario
                     se sim (mensagem: CNPJ válido), caso contrario (CNPJ inválido)
                     */
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