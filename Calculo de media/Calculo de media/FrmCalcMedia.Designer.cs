namespace Calculo_de_media
{
    partial class FrmCalcMedia
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
            this.lblCabecalho = new System.Windows.Forms.Label();
            this.gpbNotas = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.txtn4 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.gpbNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCabecalho
            // 
            this.lblCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCabecalho.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecalho.Location = new System.Drawing.Point(146, 27);
            this.lblCabecalho.Name = "lblCabecalho";
            this.lblCabecalho.Size = new System.Drawing.Size(253, 46);
            this.lblCabecalho.TabIndex = 0;
            this.lblCabecalho.Text = "CALCULO DA MEDIA";
            this.lblCabecalho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbNotas
            // 
            this.gpbNotas.Controls.Add(this.btnSair);
            this.gpbNotas.Controls.Add(this.btnLimpar);
            this.gpbNotas.Controls.Add(this.btnCalcular);
            this.gpbNotas.Controls.Add(this.lblMedia);
            this.gpbNotas.Controls.Add(this.txtn4);
            this.gpbNotas.Controls.Add(this.txtn3);
            this.gpbNotas.Controls.Add(this.txtn2);
            this.gpbNotas.Controls.Add(this.txtn1);
            this.gpbNotas.Controls.Add(this.lblNota4);
            this.gpbNotas.Controls.Add(this.lblNota3);
            this.gpbNotas.Controls.Add(this.lblNota2);
            this.gpbNotas.Controls.Add(this.lblNota1);
            this.gpbNotas.Location = new System.Drawing.Point(38, 101);
            this.gpbNotas.Name = "gpbNotas";
            this.gpbNotas.Size = new System.Drawing.Size(461, 202);
            this.gpbNotas.TabIndex = 1;
            this.gpbNotas.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(322, 150);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(176, 150);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(30, 150);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.Location = new System.Drawing.Point(48, 107);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(370, 26);
            this.lblMedia.TabIndex = 8;
            this.lblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtn4
            // 
            this.txtn4.Location = new System.Drawing.Point(318, 65);
            this.txtn4.Name = "txtn4";
            this.txtn4.Size = new System.Drawing.Size(100, 23);
            this.txtn4.TabIndex = 7;
            this.txtn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtn4_KeyDown);
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(318, 21);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(100, 23);
            this.txtn3.TabIndex = 6;
            this.txtn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtn3_KeyDown);
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(91, 62);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 23);
            this.txtn2.TabIndex = 5;
            this.txtn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtn2_KeyDown);
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(91, 21);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 23);
            this.txtn1.TabIndex = 4;
            this.txtn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtn1_KeyDown);
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(234, 65);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(62, 16);
            this.lblNota4.TabIndex = 3;
            this.lblNota4.Text = "4ª Nota";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(234, 25);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(62, 16);
            this.lblNota3.TabIndex = 2;
            this.lblNota3.Text = "3ª Nota";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(15, 65);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(62, 16);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "2ª Nota";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(15, 25);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(62, 16);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "1ª Nota";
            // 
            // FrmCalcMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(527, 320);
            this.Controls.Add(this.gpbNotas);
            this.Controls.Add(this.lblCabecalho);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo da media em C#";
            this.gpbNotas.ResumeLayout(false);
            this.gpbNotas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCabecalho;
        private System.Windows.Forms.GroupBox gpbNotas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.TextBox txtn4;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota1;
    }
}

