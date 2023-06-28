namespace GeradorValidadorcpf
{
    partial class Form1
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
            this.EntradaCpf = new System.Windows.Forms.Label();
            this.Gerar = new System.Windows.Forms.Button();
            this.EntradaNumero = new System.Windows.Forms.TextBox();
            this.gerarCPF = new System.Windows.Forms.Label();
            this.GerarNumero = new System.Windows.Forms.Button();
            this.Entradanumero2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EntradaCpf
            // 
            this.EntradaCpf.AutoSize = true;
            this.EntradaCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntradaCpf.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EntradaCpf.Location = new System.Drawing.Point(200, 19);
            this.EntradaCpf.Name = "EntradaCpf";
            this.EntradaCpf.Size = new System.Drawing.Size(210, 37);
            this.EntradaCpf.TabIndex = 0;
            this.EntradaCpf.Text = "Digite o CPF";
            // 
            // Gerar
            // 
            this.Gerar.Location = new System.Drawing.Point(247, 152);
            this.Gerar.Name = "Gerar";
            this.Gerar.Size = new System.Drawing.Size(110, 54);
            this.Gerar.TabIndex = 2;
            this.Gerar.Text = "Gerar CPF";
            this.Gerar.UseVisualStyleBackColor = true;
            // 
            // EntradaNumero
            // 
            this.EntradaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntradaNumero.Location = new System.Drawing.Point(207, 85);
            this.EntradaNumero.Name = "EntradaNumero";
            this.EntradaNumero.Size = new System.Drawing.Size(208, 38);
            this.EntradaNumero.TabIndex = 3;
            this.EntradaNumero.TextChanged += new System.EventHandler(this.EntradaNumero_TextChanged);
            // 
            // gerarCPF
            // 
            this.gerarCPF.AutoSize = true;
            this.gerarCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarCPF.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gerarCPF.Location = new System.Drawing.Point(167, 230);
            this.gerarCPF.Name = "gerarCPF";
            this.gerarCPF.Size = new System.Drawing.Size(266, 37);
            this.gerarCPF.TabIndex = 4;
            this.gerarCPF.Text = "Gerador de CPF";
            // 
            // GerarNumero
            // 
            this.GerarNumero.Location = new System.Drawing.Point(247, 345);
            this.GerarNumero.Name = "GerarNumero";
            this.GerarNumero.Size = new System.Drawing.Size(110, 55);
            this.GerarNumero.TabIndex = 5;
            this.GerarNumero.Text = "Gerar CPF";
            this.GerarNumero.UseVisualStyleBackColor = true;
            // 
            // Entradanumero2
            // 
            this.Entradanumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entradanumero2.Location = new System.Drawing.Point(200, 287);
            this.Entradanumero2.Name = "Entradanumero2";
            this.Entradanumero2.Size = new System.Drawing.Size(215, 38);
            this.Entradanumero2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.Entradanumero2);
            this.Controls.Add(this.GerarNumero);
            this.Controls.Add(this.gerarCPF);
            this.Controls.Add(this.EntradaNumero);
            this.Controls.Add(this.Gerar);
            this.Controls.Add(this.EntradaCpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EntradaCpf;
        private System.Windows.Forms.Button Gerar;
        private System.Windows.Forms.TextBox EntradaNumero;
        private System.Windows.Forms.Label gerarCPF;
        private System.Windows.Forms.Button GerarNumero;
        private System.Windows.Forms.TextBox Entradanumero2;
    }
}

