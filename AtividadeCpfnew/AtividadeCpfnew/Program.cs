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
        if (cpf.Length != 11)
            return false;

        int[] digitos = new int[11];
        for (int i = 0; i < 11; i++)
        {
            if (!int.TryParse(cpf[i].ToString(), out digitos[i]))
                return false;
        }

        if (TodosDigitosIguais(digitos))
            return false;

        int soma1 = 0;
        for (int i = 0; i < 9; i++)
        {
            soma1 += digitos[i] * (10 - i);
        }

        int resto1 = soma1 % 11;
        int digito1 = (resto1 < 2) ? 0 : 11 - resto1;

        if (digitos[9] != digito1)
            return false;

        int soma2 = 0;
        for (int i = 0; i < 10; i++)
        {
            soma2 += digitos[i] * (11 - i);
        }

        int resto2 = soma2 % 11;
        int digito2 = (resto2 < 2) ? 0 : 11 - resto2;

        if (digitos[10] != digito2)
            return false;

        return true;
    }

    static bool TodosDigitosIguais(int[] digitos)
    {
        for (int i = 1; i < digitos.Length; i++)
        {
            if (digitos[i] != digitos[0])
                return false;
        }
        return true;
    }
}

