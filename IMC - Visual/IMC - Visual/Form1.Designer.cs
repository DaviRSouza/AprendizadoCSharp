namespace IMC___Visual
{
    partial class DescubraIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DescubraIMC));
            this.Peso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.IMC = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.Situação = new System.Windows.Forms.Label();
            this.Sair = new System.Windows.Forms.Button();
            this.Calcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Peso
            // 
            this.Peso.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Peso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Peso.Location = new System.Drawing.Point(105, 63);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(75, 32);
            this.Peso.TabIndex = 0;
            this.Peso.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(215, 75);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(157, 29);
            this.txtPeso.TabIndex = 1;
            // 
            // Altura
            // 
            this.Altura.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Altura.Location = new System.Drawing.Point(97, 112);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(83, 30);
            this.Altura.TabIndex = 2;
            this.Altura.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(215, 121);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(157, 29);
            this.txtAltura.TabIndex = 3;
            // 
            // txtIMC
            // 
            this.txtIMC.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMC.Location = new System.Drawing.Point(215, 247);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(157, 29);
            this.txtIMC.TabIndex = 5;
            // 
            // IMC
            // 
            this.IMC.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMC.Location = new System.Drawing.Point(97, 235);
            this.IMC.Name = "IMC";
            this.IMC.Size = new System.Drawing.Size(83, 30);
            this.IMC.TabIndex = 4;
            this.IMC.Text = "IMC";
            // 
            // txtSituacao
            // 
            this.txtSituacao.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.Location = new System.Drawing.Point(215, 305);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(157, 29);
            this.txtSituacao.TabIndex = 7;
            // 
            // Situação
            // 
            this.Situação.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Situação.Location = new System.Drawing.Point(73, 293);
            this.Situação.Name = "Situação";
            this.Situação.Size = new System.Drawing.Size(126, 32);
            this.Situação.TabIndex = 6;
            this.Situação.Text = "Situação";
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(449, 383);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(113, 32);
            this.Sair.TabIndex = 8;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calcular.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Location = new System.Drawing.Point(38, 383);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(113, 32);
            this.Calcular.TabIndex = 9;
            this.Calcular.Text = "&Calcular";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 281);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "I M C - INDICE DE MASSA CORPORAL";
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpar.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(259, 383);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(113, 32);
            this.Limpar.TabIndex = 12;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = false;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // DescubraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(781, 427);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.Situação);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.IMC);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.Peso);
            this.Name = "DescubraIMC";
            this.Text = "IMC";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Peso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label Altura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label IMC;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label Situação;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Limpar;
    }
}

