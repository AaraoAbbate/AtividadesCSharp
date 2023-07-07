﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Atividadeclasses
{
    internal class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
   
        public int CPF { get; set; }
        public int Quantidade { get; set; } 

        public Cliente(int idCliente = 0, string nome ="", int cpf = 0, int quantidade = 0)
        {
            IdCliente = idCliente;
            Nome = nome;
            CPF = cpf;
            Quantidade = quantidade;
        }
        public void ImprimirDados()
        {
            Console.WriteLine("Dados do Cliente");
            Console.WriteLine($"Id: {IdCliente}");
            Console.WriteLine($"Nome {Nome}");
            Console.WriteLine($"Cpf: {CPF}");
        }
    }   
    
}
