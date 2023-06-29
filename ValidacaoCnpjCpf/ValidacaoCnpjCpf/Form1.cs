using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ValidacaoCnpjCpf
{
    public partial class Form1 : Form
    {
        private int[] peso1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        private int[] peso2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonCPF_Click(object sender, EventArgs e)
        {
                   
        }

        private void optionCPF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (optionCPF.Checked) // Verifica se o RadioButton para CPF está selecionado
            {
                string cpf = textbox.Text;

                if (string.IsNullOrEmpty(cpf))
                {
                    MessageBox.Show("Por favor, preencha o campo de CPF.");
                    return;
                }

                // Resto do código de validação do CPF
                // ...

                // Exemplo de exibição de mensage
            }

            if (optionCPF.Checked)
            {
                string cpf = textbox.Text;

                bool isNumeric = cpf.All(char.IsDigit);
                if (!isNumeric)
                {
                    MessageBox.Show("Entrada inválida. Digite apenas números.");
                    return;
                }

                int[] numerosInteiro = cpf.Select(digito => Convert.ToInt32(digito.ToString())).ToArray();

                int soma1 = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma1 += numerosInteiro[i] * peso1[i];
                }
                int resto1 = (soma1 * 10) % 11;

                if (resto1 == 10 || resto1 == 11)
                {
                    resto1 = 0;
                }

                int soma2 = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma2 += numerosInteiro[i] * peso2[i];
                }
                int resto2 = (soma2 * 10) % 11;

                if (resto2 == 10 || resto2 == 10)
                {
                    resto2 = 0;
                }

                string cpfFormatado = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";

                if (resto1 == numerosInteiro[9] && resto2 == numerosInteiro[10])
                {
                    MessageBox.Show("CPF válido: " + cpfFormatado);
                }
                else
                {
                    MessageBox.Show("CPF inválido: " + cpfFormatado);
                }
            }
            else if (optionCNPJ.Checked) //-----------------------------------------------
            {
                int[] peso1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };     
                int[] peso2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                string cnpj = textbox.Text;

                int[] numerosInteiro = new int[14];
                for (int i = 0; i < cnpj.Length; i++)
                {
                    numerosInteiro[i] = Convert.ToInt32(cnpj[i].ToString());
                }
                string cpf = textbox.Text;

                bool isNumeric = cpf.All(char.IsDigit);
                if (!isNumeric)
                {
                    MessageBox.Show("Entrada inválida. Digite apenas números.");
                    return;
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

                if (string.IsNullOrEmpty(cnpj))
                {
                    MessageBox.Show("Por favor, preencha o campo de CPF.");
                    return;
                }

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

        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void optionCNPJ_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

