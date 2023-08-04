namespace SistemaBiblioteca
{
    partial class FrmCadastroLivro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.entradatitulo = new System.Windows.Forms.TextBox();
            this.entradaautor = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.entradapreco = new System.Windows.Forms.TextBox();
            this.entradacodigo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.botaoadd = new System.Windows.Forms.Button();
            this.botaoatt = new System.Windows.Forms.Button();
            this.botaoexcluir = new System.Windows.Forms.Button();
            this.entradacodlivro = new System.Windows.Forms.Label();
            this.botaopesquisa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // entradatitulo
            // 
            this.entradatitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradatitulo.Location = new System.Drawing.Point(58, 24);
            this.entradatitulo.Name = "entradatitulo";
            this.entradatitulo.Size = new System.Drawing.Size(220, 26);
            this.entradatitulo.TabIndex = 0;
            // 
            // entradaautor
            // 
            this.entradaautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaautor.Location = new System.Drawing.Point(58, 80);
            this.entradaautor.Name = "entradaautor";
            this.entradaautor.Size = new System.Drawing.Size(220, 26);
            this.entradaautor.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(40, 16);
            this.title.TabIndex = 2;
            this.title.Text = "Título";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(9, 80);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(38, 16);
            this.author.TabIndex = 3;
            this.author.Text = "Autor";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(9, 131);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(43, 16);
            this.price.TabIndex = 4;
            this.price.Text = "Preço";
            // 
            // entradapreco
            // 
            this.entradapreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradapreco.Location = new System.Drawing.Point(71, 131);
            this.entradapreco.Name = "entradapreco";
            this.entradapreco.Size = new System.Drawing.Size(131, 26);
            this.entradapreco.TabIndex = 5;
            // 
            // entradacodigo
            // 
            this.entradacodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradacodigo.Location = new System.Drawing.Point(328, 131);
            this.entradacodigo.Name = "entradacodigo";
            this.entradacodigo.Size = new System.Drawing.Size(194, 26);
            this.entradacodigo.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(781, 195);
            this.dataGridView1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Código ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "N de Paginas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ano de Publicação";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(626, 90);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(162, 26);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(590, 24);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(198, 26);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(580, 187);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(77, 26);
            this.textBox7.TabIndex = 13;
            // 
            // botaoadd
            // 
            this.botaoadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoadd.Location = new System.Drawing.Point(15, 190);
            this.botaoadd.Name = "botaoadd";
            this.botaoadd.Size = new System.Drawing.Size(75, 23);
            this.botaoadd.TabIndex = 14;
            this.botaoadd.Text = "Adicionar";
            this.botaoadd.UseVisualStyleBackColor = true;
            // 
            // botaoatt
            // 
            this.botaoatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoatt.Location = new System.Drawing.Point(116, 190);
            this.botaoatt.Name = "botaoatt";
            this.botaoatt.Size = new System.Drawing.Size(75, 23);
            this.botaoatt.TabIndex = 15;
            this.botaoatt.Text = "Atualizar";
            this.botaoatt.UseVisualStyleBackColor = true;
            // 
            // botaoexcluir
            // 
            this.botaoexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoexcluir.Location = new System.Drawing.Point(216, 190);
            this.botaoexcluir.Name = "botaoexcluir";
            this.botaoexcluir.Size = new System.Drawing.Size(75, 23);
            this.botaoexcluir.TabIndex = 16;
            this.botaoexcluir.Text = "Excluir";
            this.botaoexcluir.UseVisualStyleBackColor = true;
            // 
            // entradacodlivro
            // 
            this.entradacodlivro.AutoSize = true;
            this.entradacodlivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradacodlivro.Location = new System.Drawing.Point(483, 187);
            this.entradacodlivro.Name = "entradacodlivro";
            this.entradacodlivro.Size = new System.Drawing.Size(67, 16);
            this.entradacodlivro.TabIndex = 17;
            this.entradacodlivro.Text = "Cod .Livro";
            // 
            // botaopesquisa
            // 
            this.botaopesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaopesquisa.Location = new System.Drawing.Point(685, 190);
            this.botaopesquisa.Name = "botaopesquisa";
            this.botaopesquisa.Size = new System.Drawing.Size(75, 23);
            this.botaopesquisa.TabIndex = 18;
            this.botaopesquisa.Text = "Pesquisar";
            this.botaopesquisa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaopesquisa);
            this.Controls.Add(this.entradacodlivro);
            this.Controls.Add(this.botaoexcluir);
            this.Controls.Add(this.botaoatt);
            this.Controls.Add(this.botaoadd);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.entradacodigo);
            this.Controls.Add(this.entradapreco);
            this.Controls.Add(this.price);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Controls.Add(this.entradaautor);
            this.Controls.Add(this.entradatitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entradatitulo;
        private System.Windows.Forms.TextBox entradaautor;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox entradapreco;
        private System.Windows.Forms.TextBox entradacodigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button botaoadd;
        private System.Windows.Forms.Button botaoatt;
        private System.Windows.Forms.Button botaoexcluir;
        private System.Windows.Forms.Label entradacodlivro;
        private System.Windows.Forms.Button botaopesquisa;
    }
}

