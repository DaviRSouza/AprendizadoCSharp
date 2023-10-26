namespace Maior_Menor_de_6
{
    partial class FrmMaiorDe6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.txtN5 = new System.Windows.Forms.TextBox();
            this.txtN6 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "1° numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "2° numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "3° numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "4° numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "5° numero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "6° numero";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(141, 30);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 23);
            this.txtN1.TabIndex = 6;
            this.txtN1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN1_KeyDown);
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(368, 30);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(100, 23);
            this.txtN4.TabIndex = 7;
            this.txtN4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN4_KeyDown);
            // 
            // txtN5
            // 
            this.txtN5.Location = new System.Drawing.Point(368, 80);
            this.txtN5.Name = "txtN5";
            this.txtN5.Size = new System.Drawing.Size(100, 23);
            this.txtN5.TabIndex = 8;
            this.txtN5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN5_KeyDown);
            // 
            // txtN6
            // 
            this.txtN6.Location = new System.Drawing.Point(368, 130);
            this.txtN6.Name = "txtN6";
            this.txtN6.Size = new System.Drawing.Size(100, 23);
            this.txtN6.TabIndex = 9;
            this.txtN6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN6_KeyDown);
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(141, 130);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(100, 23);
            this.txtN3.TabIndex = 10;
            this.txtN3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN3_KeyDown);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(141, 80);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 23);
            this.txtN2.TabIndex = 11;
            this.txtN2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN2_KeyDown);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(38, 187);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(430, 33);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnLimpa);
            this.groupBox1.Controls.Add(this.btnVerifica);
            this.groupBox1.Location = new System.Drawing.Point(18, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 75);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(330, 30);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpa.Location = new System.Drawing.Point(180, 30);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 1;
            this.btnLimpa.Text = "&Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnVerifica
            // 
            this.btnVerifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifica.Location = new System.Drawing.Point(30, 30);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(75, 23);
            this.btnVerifica.TabIndex = 0;
            this.btnVerifica.Text = "&Verifica";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // FrmMaiorDe6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(496, 319);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN6);
            this.Controls.Add(this.txtN5);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMaiorDe6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maior Numero de 6";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.TextBox txtN5;
        private System.Windows.Forms.TextBox txtN6;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnVerifica;
    }
}

