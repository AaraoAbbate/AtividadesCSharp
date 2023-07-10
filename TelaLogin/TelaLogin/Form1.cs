using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLogin
{
    public partial class Form1 : Form
    {
        private List<string> listaEmails = new List<string>();
        private List<string> listaSenhas = new List<string>();
        public Form1()
        {
            InitializeComponent();

            listaEmails.Add("aaraoabbate@gmail.com");
            

            listaSenhas.Add("170401");
            
        }

        static List<string> ListaEmails = new List<string>();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        private bool ValidarEmail(string email)
        {
            return listaEmails.Contains(email);

        }

        private void login_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string senhas = textBox2.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("E-mail inválido!");
            }
            else if (ValidarCredenciais(email, senhas))
            {
                MessageBox.Show("Bem-vindo!");
            }
            else
            {
                MessageBox.Show("Email ou senha inválida!");
            }



        }

        private bool ValidarCredenciais(string email, string senha)
        {
            if (listaEmails.Contains(email))
            {
                int index = listaEmails.IndexOf(email);
                return listaSenhas[index] == senha;
            }

            return false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


