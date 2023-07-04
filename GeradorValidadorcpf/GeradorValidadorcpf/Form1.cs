using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GeradorValidadorcpf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EntradaNumero_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void GerarNumero_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] cpfInt = new int[11];
            int[] peso1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, };
            int[] peso2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma1 = 0;

            for (int i = 0; i < cpfInt.Length; i++)
            {
                int randomNumber = random.Next(10); //Gera números aleatoriamente de 0 a 9
                cpfInt[i] = randomNumber;
            }
             
            for (int i = 0; i < 9; i++)
            {
                soma1 += cpfInt[i] * peso1[i];
            }
            int resto1 = (soma1 * 10) % 11;

            if (resto1 == 10 || resto1 == 11)
            {
                resto1 = 0;
            }
            cpfInt[9] = resto1;

            int soma2 = 0;
            for (int i = 0; i < 10; i++)
            {
                soma2 += cpfInt[i] * peso2[i];
            }
            int resto2 = (soma2 * 10) % 11;

            if (resto2 == 10 || resto2 == 10)
            {
                resto2 = 0;
            }
            cpfInt[10] = resto2;

            string cpf = string.Concat(cpfInt);
            Entradanumero.Text = cpf;
        }

        private void validarcpf_Click(object sender, EventArgs e)
        {
            string cpf = entradanumero2.Text;
            int[] cpfInt = cpf.Select(numero => Convert.ToInt32(numero.ToString())).ToArray();
            int[] peso1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, };
            int[] peso2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma1 = 0;

            for (int i = 0; i < 9; i++)
            {
                soma1 += cpfInt[i] * peso1[i];
            }
            int resto1 = (soma1 * 10) % 11;

            if (resto1 == 10 || resto1 == 11)
            {
                resto1 = 0;
            }

            int soma2 = 0;
            for (int i = 0; i < 10; i++)
            {
                soma2 += cpfInt[i] * peso2[i];
            }
            int resto2 = (soma2 * 10) % 11;

            if (resto2 == 10 || resto2 == 10)
            {
                resto2 = 0;
            }
            string cpfFormatado = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";

            if (resto1 == cpfInt[9] && resto2 == cpfInt[10])
            {
                MessageBox.Show($"Cpf válido : {cpfFormatado}" , "Sucesso!" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show($"Cpf inválido : {cpfFormatado}" , "Erro" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        } 
    }
}
