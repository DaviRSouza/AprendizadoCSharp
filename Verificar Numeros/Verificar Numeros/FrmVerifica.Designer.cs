namespace Verificar_Numeros
{
    partial class FrmVerifica
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gpbBotoes = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.gpbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.Location = new System.Drawing.Point(12, 38);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(136, 21);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Digite um Numero:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(185, 35);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(151, 22);
            this.txtNum.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(12, 83);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(332, 24);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbBotoes
            // 
            this.gpbBotoes.Controls.Add(this.btnSair);
            this.gpbBotoes.Controls.Add(this.btnLimpa);
            this.gpbBotoes.Controls.Add(this.btnVerifica);
            this.gpbBotoes.Location = new System.Drawing.Point(12, 113);
            this.gpbBotoes.Name = "gpbBotoes";
            this.gpbBotoes.Size = new System.Drawing.Size(333, 100);
            this.gpbBotoes.TabIndex = 3;
            this.gpbBotoes.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(234, 41);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 31);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(119, 41);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(90, 31);
            this.btnLimpa.TabIndex = 1;
            this.btnLimpa.Text = "&Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(7, 41);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(90, 31);
            this.btnVerifica.TabIndex = 0;
            this.btnVerifica.Text = "&Verifica";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // FrmVerifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 233);
            this.Controls.Add(this.gpbBotoes);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNumero);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVerifica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificação de Numeros";
            this.gpbBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox gpbBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnVerifica;
    }
}

