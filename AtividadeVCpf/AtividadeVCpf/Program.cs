using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o CPF (somente números):");
        string cpf = Console.ReadLine();

        if (ValidarCPF(cpf))
        {
            Console.WriteLine("CPF válido.");
        }
        else
        {
            Console.WriteLine("CPF inválido.");
        }

        Console.ReadLine();
    }

    static bool ValidarCPF(string cpf)
    {
        // Verifica se o CPF possui 11 dígitos
        if (cpf.Length != 11)
        {
            return false;
        }

        // Verifica se todos os dígitos são iguais
        if (TodosDigitosIguais(cpf))
        {
            return false;
        }

        // Calcula o primeiro dígito verificador
        int soma = 0;
        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (10 - i);
        }
        int digito1 = 11 - (soma % 11);
        if (digito1 > 9)
        {
            digito1 = 0;
        }

        // Verifica se o primeiro dígito verificador é igual ao dígito na posição 9
        if (digito1 != int.Parse(cpf[9].ToString()))
        {
            return false;
        }

        // Calcula o segundo dígito verificador
        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (11 - i);
        }
        int digito2 = 11 - (soma % 11);
        if (digito2 > 9)
        {
            digito2 = 0;
        }

        // Verifica se o segundo dígito verificador é igual ao dígito na posição 10
        if (digito2 != int.Parse(cpf[10].ToString()))
        {
            return false;
        }

        return true;
    }

    static bool TodosDigitosIguais(string cpf)
    {
        for (int i = 1; i < cpf.Length; i++)
        {
            if (cpf[i] != cpf[0])
            {
                return false;
            }
        }
        return true;
    }
}

