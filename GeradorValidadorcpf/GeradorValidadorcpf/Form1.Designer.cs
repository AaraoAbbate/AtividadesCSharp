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
            this.gerarCPF = new System.Windows.Forms.Label();
            this.GerarNumero = new System.Windows.Forms.Button();
            this.Entradanumero = new System.Windows.Forms.TextBox();
            this.validarcpf = new System.Windows.Forms.Button();
            this.entradanumero2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gerarCPF
            // 
            this.gerarCPF.AutoSize = true;
            this.gerarCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarCPF.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gerarCPF.Location = new System.Drawing.Point(172, 9);
            this.gerarCPF.Name = "gerarCPF";
            this.gerarCPF.Size = new System.Drawing.Size(266, 37);
            this.gerarCPF.TabIndex = 4;
            this.gerarCPF.Text = "Gerador de CPF";
            // 
            // GerarNumero
            // 
            this.GerarNumero.Location = new System.Drawing.Point(260, 132);
            this.GerarNumero.Name = "GerarNumero";
            this.GerarNumero.Size = new System.Drawing.Size(80, 50);
            this.GerarNumero.TabIndex = 5;
            this.GerarNumero.Text = "Gerar CPF";
            this.GerarNumero.UseVisualStyleBackColor = true;
            this.GerarNumero.Click += new System.EventHandler(this.GerarNumero_Click);
            // 
            // Entradanumero
            // 
            this.Entradanumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entradanumero.Location = new System.Drawing.Point(196, 64);
            this.Entradanumero.Name = "Entradanumero";
            this.Entradanumero.Size = new System.Drawing.Size(215, 38);
            this.Entradanumero.TabIndex = 6;
            // 
            // validarcpf
            // 
            this.validarcpf.Location = new System.Drawing.Point(260, 330);
            this.validarcpf.Name = "validarcpf";
            this.validarcpf.Size = new System.Drawing.Size(80, 50);
            this.validarcpf.TabIndex = 7;
            this.validarcpf.Text = "Validar";
            this.validarcpf.UseVisualStyleBackColor = true;
            this.validarcpf.Click += new System.EventHandler(this.validarcpf_Click);
            // 
            // entradanumero2
            // 
            this.entradanumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradanumero2.Location = new System.Drawing.Point(196, 239);
            this.entradanumero2.Name = "entradanumero2";
            this.entradanumero2.Size = new System.Drawing.Size(215, 38);
            this.entradanumero2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.entradanumero2);
            this.Controls.Add(this.validarcpf);
            this.Controls.Add(this.Entradanumero);
            this.Controls.Add(this.GerarNumero);
            this.Controls.Add(this.gerarCPF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label gerarCPF;
        private System.Windows.Forms.Button GerarNumero;
        private System.Windows.Forms.TextBox Entradanumero;
        private System.Windows.Forms.Button validarcpf;
        private System.Windows.Forms.TextBox entradanumero2;
    }
}

