namespace WindowsFormsApp
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
            this.label = new System.Windows.Forms.Label();
            this.textRenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textEnergia = new System.Windows.Forms.TextBox();
            this.textAgua = new System.Windows.Forms.TextBox();
            this.textTV = new System.Windows.Forms.TextBox();
            this.textAlimentacao = new System.Windows.Forms.TextBox();
            this.textMais = new System.Windows.Forms.TextBox();
            this.bntcal = new System.Windows.Forms.Button();
            this.bntexcluir = new System.Windows.Forms.Button();
            this.btnfe = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Enabled = false;
            this.label.Location = new System.Drawing.Point(12, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(91, 19);
            this.label.TabIndex = 0;
            this.label.Text = "Renda familiar";
            // 
            // textRenda
            // 
            this.textRenda.Location = new System.Drawing.Point(159, 37);
            this.textRenda.Name = "textRenda";
            this.textRenda.Size = new System.Drawing.Size(100, 20);
            this.textRenda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gastos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Energia Eletrica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Agua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "TV/Fone/Internt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Alimentação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Outro gastos";
            // 
            // textEnergia
            // 
            this.textEnergia.Location = new System.Drawing.Point(159, 141);
            this.textEnergia.Name = "textEnergia";
            this.textEnergia.Size = new System.Drawing.Size(100, 20);
            this.textEnergia.TabIndex = 8;
            // 
            // textAgua
            // 
            this.textAgua.Location = new System.Drawing.Point(159, 181);
            this.textAgua.Name = "textAgua";
            this.textAgua.Size = new System.Drawing.Size(100, 20);
            this.textAgua.TabIndex = 9;
            // 
            // textTV
            // 
            this.textTV.Location = new System.Drawing.Point(159, 222);
            this.textTV.Name = "textTV";
            this.textTV.Size = new System.Drawing.Size(100, 20);
            this.textTV.TabIndex = 10;
            // 
            // textAlimentacao
            // 
            this.textAlimentacao.Location = new System.Drawing.Point(159, 257);
            this.textAlimentacao.Name = "textAlimentacao";
            this.textAlimentacao.Size = new System.Drawing.Size(100, 20);
            this.textAlimentacao.TabIndex = 11;
            // 
            // textMais
            // 
            this.textMais.Location = new System.Drawing.Point(159, 312);
            this.textMais.Name = "textMais";
            this.textMais.Size = new System.Drawing.Size(100, 20);
            this.textMais.TabIndex = 12;
            // 
            // bntcal
            // 
            this.bntcal.Location = new System.Drawing.Point(18, 367);
            this.bntcal.Name = "bntcal";
            this.bntcal.Size = new System.Drawing.Size(75, 23);
            this.bntcal.TabIndex = 13;
            this.bntcal.Text = "Calculo";
            this.bntcal.UseVisualStyleBackColor = true;
            this.bntcal.Click += new System.EventHandler(this.bntcal_Click);
            // 
            // bntexcluir
            // 
            this.bntexcluir.Location = new System.Drawing.Point(143, 367);
            this.bntexcluir.Name = "bntexcluir";
            this.bntexcluir.Size = new System.Drawing.Size(75, 23);
            this.bntexcluir.TabIndex = 14;
            this.bntexcluir.Text = "Excluir";
            this.bntexcluir.UseVisualStyleBackColor = true;
            this.bntexcluir.Click += new System.EventHandler(this.bntexcluir_Click);
            // 
            // btnfe
            // 
            this.btnfe.Location = new System.Drawing.Point(265, 367);
            this.btnfe.Name = "btnfe";
            this.btnfe.Size = new System.Drawing.Size(75, 23);
            this.btnfe.TabIndex = 15;
            this.btnfe.Text = "Fechar";
            this.btnfe.UseVisualStyleBackColor = true;
            this.btnfe.Click += new System.EventHandler(this.btnfe_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Saldo";
            // 
            // lbltotal
            // 
            this.lbltotal.Location = new System.Drawing.Point(143, 418);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(100, 23);
            this.lbltotal.TabIndex = 18;
            // 
            // lblsaldo
            // 
            this.lblsaldo.Location = new System.Drawing.Point(140, 467);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(100, 23);
            this.lblsaldo.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 617);
            this.Controls.Add(this.lblsaldo);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnfe);
            this.Controls.Add(this.bntexcluir);
            this.Controls.Add(this.bntcal);
            this.Controls.Add(this.textMais);
            this.Controls.Add(this.textAlimentacao);
            this.Controls.Add(this.textTV);
            this.Controls.Add(this.textAgua);
            this.Controls.Add(this.textEnergia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRenda);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textRenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textEnergia;
        private System.Windows.Forms.TextBox textAgua;
        private System.Windows.Forms.TextBox textTV;
        private System.Windows.Forms.TextBox textAlimentacao;
        private System.Windows.Forms.TextBox textMais;
        private System.Windows.Forms.Button bntcal;
        private System.Windows.Forms.Button bntexcluir;
        private System.Windows.Forms.Button btnfe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblsaldo;
    }
}

