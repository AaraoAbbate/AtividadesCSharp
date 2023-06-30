namespace ValidacaoCnpjCpf
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
            this.textbox = new System.Windows.Forms.TextBox();
            this.optionCNPJ = new System.Windows.Forms.RadioButton();
            this.optionCPF = new System.Windows.Forms.RadioButton();
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.titlegeneration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox.Location = new System.Drawing.Point(128, 159);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(318, 40);
            this.textbox.TabIndex = 0;
            // 
            // optionCNPJ
            // 
            this.optionCNPJ.AutoSize = true;
            this.optionCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionCNPJ.Location = new System.Drawing.Point(365, 224);
            this.optionCNPJ.Name = "optionCNPJ";
            this.optionCNPJ.Size = new System.Drawing.Size(60, 20);
            this.optionCNPJ.TabIndex = 2;
            this.optionCNPJ.TabStop = true;
            this.optionCNPJ.Text = "CNPJ";
            this.optionCNPJ.UseVisualStyleBackColor = true;
            this.optionCNPJ.CheckedChanged += new System.EventHandler(this.optionCNPJ_CheckedChanged);
            // 
            // optionCPF
            // 
            this.optionCPF.AutoSize = true;
            this.optionCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionCPF.Location = new System.Drawing.Point(152, 224);
            this.optionCPF.Name = "optionCPF";
            this.optionCPF.Size = new System.Drawing.Size(51, 20);
            this.optionCPF.TabIndex = 3;
            this.optionCPF.TabStop = true;
            this.optionCPF.Text = "CPF";
            this.optionCPF.UseVisualStyleBackColor = true;
            this.optionCPF.CheckedChanged += new System.EventHandler(this.optionCPF_CheckedChanged);
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(245, 263);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(80, 40);
            this.confirm.TabIndex = 4;
            this.confirm.Text = "OK";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(245, 340);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 40);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // titlegeneration
            // 
            this.titlegeneration.AutoSize = true;
            this.titlegeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlegeneration.Location = new System.Drawing.Point(15, 25);
            this.titlegeneration.Name = "titlegeneration";
            this.titlegeneration.Size = new System.Drawing.Size(263, 29);
            this.titlegeneration.TabIndex = 6;
            this.titlegeneration.Text = "Gerador CPF e CNPJ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.titlegeneration);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.optionCPF);
            this.Controls.Add(this.optionCNPJ);
            this.Controls.Add(this.textbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Validação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.RadioButton optionCNPJ;
        private System.Windows.Forms.RadioButton optionCPF;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label titlegeneration;
    }
}

