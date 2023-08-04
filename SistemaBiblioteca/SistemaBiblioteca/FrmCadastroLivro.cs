using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class FrmCadastroLivro : Form

    {
        public string conexaoString;
        private SqlConnection conexaoDB;
        DataGridViewRow linhaSelecionada;

        public FrmCadastroLivro()
        {
            InitializeComponent();
            //String de conexão

            conexaoString = "Data Source=MAR0625642w10-1;Initial Catalog=Biblioteca;Integrated Security=True";

            //Inicializando a conexão com o Banco de dados
            conexaoDB = new SqlConnection(conexaoString);
        }

        public void carregarDadosLivros(int id = 0)
        {
            try
            {
                
                conexaoDB.Open();

                    string sql;

                    if (id == 0)
                    {
                        sql = "SELECT * FROM Livros ";
                    }
                    else
                    {
                        sql = "SELECT * FROM Livros WHERE id=" + id;
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(sql , conexaoDB);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataTable.Columns["numero_pagina"].ColumnName = "N Página";
                dataTable.Columns["preco"].ColumnName = "Preço";
                dataTable.Columns["ano_publicacao"].ColumnName = "Ano Publicação";

                dgvLivro.DataSource = dataTable;

                conexaoDB.Close();

            }catch (SqlException ex) 
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex);
            }
        }

       

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO livros (titulo, autor, numero_pagina, preco, ano_publicacao, isbn) VALUES (@titulo, @autor, @numero_pagina, @preco, @ano_publicacao, @isbn)";

            try
            {
                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                sqlCmd.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                sqlCmd.Parameters.AddWithValue("@autor", txtAutor.Text);
                sqlCmd.Parameters.AddWithValue("@numero_pagina", Convert.ToInt32(txtNumeroPagina.Text));
                sqlCmd.Parameters.AddWithValue("@preco", Convert.ToDecimal(txtPreco.Text));
                sqlCmd.Parameters.AddWithValue("@ano_publicacao", Convert.ToInt32(txtAnoPublicacao.Text));
                sqlCmd.Parameters.AddWithValue("@isbn", txtISBN.Text);

                conexaoDB.Open();
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!");

                conexaoDB.Close();



            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar os dados: " + ex);
            }
        }

        private void FrmCadastroLivro_Load(object sender, EventArgs e)
        {
            carregarDadosLivros();
        }

        private void dgvLivro_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                linhaSelecionada = dgvLivro.Rows[e.RowIndex];

                txtISBN.Text = linhaSelecionada.Cells["isbn"].Value.ToString();
                txtTitulo.Text = linhaSelecionada.Cells["titulo"].Value.ToString();
                txtPreco.Text = linhaSelecionada.Cells["Preço"].Value.ToString();
                txtAnoPublicacao.Text = linhaSelecionada.Cells["Ano Publicação"].Value.ToString();
                txtNumeroPagina.Text = linhaSelecionada.Cells["N Página"].Value.ToString();
                txtAutor.Text = linhaSelecionada.Cells["Autor"].Value.ToString();

                
                
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(linhaSelecionada.Cells["id"].Value.ToString());

                string sql = "UPDATE Livros SET " +                   
                        "titulo=@titulo, " +
                        "autor=@autor, " +
                        "numero_pagina=@numero_pagina, " +
                        "preco=@preco, " +
                        "isbn=@isbn, " +
                        "ano_publicacao=@ano_publicacao " +
                        "WHERE id=@id";

                conexaoDB.Open();

                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                sqlCmd.Parameters.AddWithValue("@id", id);
                sqlCmd.Parameters.AddWithValue("titulo", txtTitulo.Text);
                sqlCmd.Parameters.AddWithValue("@autor", txtAutor.Text);
                sqlCmd.Parameters.AddWithValue("@numero_pagina", txtNumeroPagina.Text);
                sqlCmd.Parameters.AddWithValue("@preco", txtPreco.Text);
                sqlCmd.Parameters.AddWithValue("@isbn", txtISBN.Text);
                sqlCmd.Parameters.AddWithValue("@ano_publicacao", txtAnoPublicacao.Text);

           
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Atualização Realizada com Sucesso!!!");

                conexaoDB.Close();

                carregarDadosLivros();

            }
            catch (SqlException ex) 
            {
                MessageBox.Show("Erro ao Atualizar os Dados: " + ex);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (linhaSelecionada != null)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja exlcuir ", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(linhaSelecionada.Cells["id"].Value.ToString());

                        string sql = "DELETE FROM Livros " +
                                     "WHERE id=@id";

                        conexaoDB.Open();

                        SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                        sqlCmd.Parameters.AddWithValue("@id", id);
                        sqlCmd.ExecuteNonQuery();

                        MessageBox.Show("Livro excluido com sucesso!!!");

                        conexaoDB.Close();

                        carregarDadosLivros();
                    }catch (SqlException ex)
                    {
                        MessageBox.Show("erro ao excluir os dados: " + ex);
                    }
                }
            }
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtPesquisar.Text, out id))
            {
                carregarDadosLivros(id);
            }
            else
            {
                MessageBox.Show("Código do livro inválido");
            }
        }
    }
}
