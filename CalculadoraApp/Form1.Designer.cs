namespace CalculadoraApp
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
            this.btPorcentagem = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btApagar = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btMultiplicacao = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btMenos = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btResultado = new System.Windows.Forms.Button();
            this.btMais = new System.Windows.Forms.Button();
            this.btVirgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPorcentagem
            // 
            this.btPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPorcentagem.Location = new System.Drawing.Point(50, 290);
            this.btPorcentagem.Name = "btPorcentagem";
            this.btPorcentagem.Size = new System.Drawing.Size(81, 54);
            this.btPorcentagem.TabIndex = 0;
            this.btPorcentagem.Text = "%";
            this.btPorcentagem.UseVisualStyleBackColor = true;
            this.btPorcentagem.Click += new System.EventHandler(this.btPorcentagem_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(50, 52);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(430, 200);
            this.txtDisplay.TabIndex = 9;
            // 
            // btApagar
            // 
            this.btApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApagar.Location = new System.Drawing.Point(399, 290);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(81, 54);
            this.btApagar.TabIndex = 10;
            this.btApagar.Text = "<";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btC
            // 
            this.btC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC.Location = new System.Drawing.Point(292, 290);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(81, 54);
            this.btC.TabIndex = 11;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btCE
            // 
            this.btCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCE.Location = new System.Drawing.Point(177, 290);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(81, 54);
            this.btCE.TabIndex = 12;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = true;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(177, 393);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(81, 54);
            this.bt8.TabIndex = 16;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.btNumero_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(292, 393);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(81, 54);
            this.bt9.TabIndex = 15;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.btNumero_Click);
            // 
            // btDivisao
            // 
            this.btDivisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivisao.Location = new System.Drawing.Point(399, 393);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(81, 54);
            this.btDivisao.TabIndex = 14;
            this.btDivisao.Text = "/";
            this.btDivisao.UseVisualStyleBackColor = false;
            this.btDivisao.Click += new System.EventHandler(this.btOperador_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(50, 393);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(81, 54);
            this.bt7.TabIndex = 13;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.btNumero_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(177, 473);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(81, 54);
            this.bt5.TabIndex = 20;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.btNumero_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(292, 473);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(81, 54);
            this.bt6.TabIndex = 19;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.btNumero_Click);
            // 
            // btMultiplicacao
            // 
            this.btMultiplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicacao.Location = new System.Drawing.Point(399, 473);
            this.btMultiplicacao.Name = "btMultiplicacao";
            this.btMultiplicacao.Size = new System.Drawing.Size(81, 54);
            this.btMultiplicacao.TabIndex = 18;
            this.btMultiplicacao.Text = "X";
            this.btMultiplicacao.UseVisualStyleBackColor = false;
            this.btMultiplicacao.Click += new System.EventHandler(this.btOperador_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(50, 473);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(81, 54);
            this.bt4.TabIndex = 17;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.btNumero_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(177, 555);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(81, 54);
            this.bt2.TabIndex = 24;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.btNumero_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(292, 555);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(81, 54);
            this.bt3.TabIndex = 23;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.btNumero_Click);
            // 
            // btMenos
            // 
            this.btMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenos.Location = new System.Drawing.Point(399, 555);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(81, 54);
            this.btMenos.TabIndex = 22;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = false;
            this.btMenos.Click += new System.EventHandler(this.btOperador_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(50, 555);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(81, 54);
            this.bt1.TabIndex = 21;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.btNumero_Click);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(177, 634);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(81, 54);
            this.bt0.TabIndex = 28;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.btNumero_Click);
            // 
            // btResultado
            // 
            this.btResultado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResultado.Location = new System.Drawing.Point(292, 639);
            this.btResultado.Name = "btResultado";
            this.btResultado.Size = new System.Drawing.Size(81, 54);
            this.btResultado.TabIndex = 27;
            this.btResultado.Text = "=";
            this.btResultado.UseVisualStyleBackColor = false;
            this.btResultado.Click += new System.EventHandler(this.btResultado_Click);
            // 
            // btMais
            // 
            this.btMais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMais.Location = new System.Drawing.Point(399, 634);
            this.btMais.Name = "btMais";
            this.btMais.Size = new System.Drawing.Size(81, 54);
            this.btMais.TabIndex = 26;
            this.btMais.Text = "+";
            this.btMais.UseVisualStyleBackColor = false;
            this.btMais.Click += new System.EventHandler(this.btOperador_Click);
            // 
            // btVirgula
            // 
            this.btVirgula.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVirgula.Location = new System.Drawing.Point(50, 634);
            this.btVirgula.Name = "btVirgula";
            this.btVirgula.Size = new System.Drawing.Size(81, 54);
            this.btVirgula.TabIndex = 25;
            this.btVirgula.Text = ",";
            this.btVirgula.UseVisualStyleBackColor = false;
            this.btVirgula.Click += new System.EventHandler(this.btVirgula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1046, 819);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btResultado);
            this.Controls.Add(this.btMais);
            this.Controls.Add(this.btVirgula);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.btMenos);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.btMultiplicacao);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.btDivisao);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btPorcentagem);
            this.Name = "Form1";
            this.Text = "V";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPorcentagem;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btDivisao;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button btMultiplicacao;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btResultado;
        private System.Windows.Forms.Button btMais;
        private System.Windows.Forms.Button btVirgula;
    }
}

