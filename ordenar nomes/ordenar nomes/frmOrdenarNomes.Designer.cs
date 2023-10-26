namespace ordenar_nomes
{
    partial class frmOrdenarNomes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome6 = new System.Windows.Forms.TextBox();
            this.txtNome4 = new System.Windows.Forms.TextBox();
            this.txtNome5 = new System.Windows.Forms.TextBox();
            this.txtNome3 = new System.Windows.Forms.TextBox();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.lblN6 = new System.Windows.Forms.Label();
            this.lblN5 = new System.Windows.Forms.Label();
            this.lblN4 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnClassificar = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblOrdenada = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(71, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(442, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Lista de Nomes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome6);
            this.groupBox1.Controls.Add(this.txtNome4);
            this.groupBox1.Controls.Add(this.txtNome5);
            this.groupBox1.Controls.Add(this.txtNome3);
            this.groupBox1.Controls.Add(this.txtNome2);
            this.groupBox1.Controls.Add(this.txtNome1);
            this.groupBox1.Controls.Add(this.lblN6);
            this.groupBox1.Controls.Add(this.lblN5);
            this.groupBox1.Controls.Add(this.lblN4);
            this.groupBox1.Controls.Add(this.lblN3);
            this.groupBox1.Controls.Add(this.lblN2);
            this.groupBox1.Controls.Add(this.lblN1);
            this.groupBox1.Location = new System.Drawing.Point(14, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtNome6
            // 
            this.txtNome6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome6.Location = new System.Drawing.Point(93, 167);
            this.txtNome6.Name = "txtNome6";
            this.txtNome6.Size = new System.Drawing.Size(225, 23);
            this.txtNome6.TabIndex = 12;
            this.txtNome6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome6_KeyDown);
            // 
            // txtNome4
            // 
            this.txtNome4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome4.Location = new System.Drawing.Point(93, 110);
            this.txtNome4.Name = "txtNome4";
            this.txtNome4.Size = new System.Drawing.Size(225, 23);
            this.txtNome4.TabIndex = 9;
            this.txtNome4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome4_KeyDown);
            // 
            // txtNome5
            // 
            this.txtNome5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome5.Location = new System.Drawing.Point(93, 140);
            this.txtNome5.Name = "txtNome5";
            this.txtNome5.Size = new System.Drawing.Size(225, 23);
            this.txtNome5.TabIndex = 11;
            this.txtNome5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome5_KeyDown);
            // 
            // txtNome3
            // 
            this.txtNome3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome3.Location = new System.Drawing.Point(93, 80);
            this.txtNome3.Name = "txtNome3";
            this.txtNome3.Size = new System.Drawing.Size(225, 23);
            this.txtNome3.TabIndex = 8;
            this.txtNome3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome3_KeyDown);
            // 
            // txtNome2
            // 
            this.txtNome2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome2.Location = new System.Drawing.Point(93, 50);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(225, 23);
            this.txtNome2.TabIndex = 7;
            this.txtNome2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome2_KeyDown);
            // 
            // txtNome1
            // 
            this.txtNome1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome1.Location = new System.Drawing.Point(93, 15);
            this.txtNome1.Name = "txtNome1";
            this.txtNome1.Size = new System.Drawing.Size(225, 23);
            this.txtNome1.TabIndex = 6;
            this.txtNome1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome1_KeyDown);
            // 
            // lblN6
            // 
            this.lblN6.AutoSize = true;
            this.lblN6.Location = new System.Drawing.Point(5, 170);
            this.lblN6.Name = "lblN6";
            this.lblN6.Size = new System.Drawing.Size(69, 16);
            this.lblN6.TabIndex = 5;
            this.lblN6.Text = "6° Nome";
            // 
            // lblN5
            // 
            this.lblN5.AutoSize = true;
            this.lblN5.Location = new System.Drawing.Point(5, 140);
            this.lblN5.Name = "lblN5";
            this.lblN5.Size = new System.Drawing.Size(69, 16);
            this.lblN5.TabIndex = 4;
            this.lblN5.Text = "5° Nome";
            // 
            // lblN4
            // 
            this.lblN4.AutoSize = true;
            this.lblN4.Location = new System.Drawing.Point(5, 110);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(69, 16);
            this.lblN4.TabIndex = 3;
            this.lblN4.Text = "4° Nome";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Location = new System.Drawing.Point(6, 80);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(69, 16);
            this.lblN3.TabIndex = 2;
            this.lblN3.Text = "3° Nome";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(5, 50);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(69, 16);
            this.lblN2.TabIndex = 1;
            this.lblN2.Text = "2° Nome";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(5, 15);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(69, 16);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "1° Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOrdenada);
            this.groupBox2.Location = new System.Drawing.Point(365, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 215);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSair);
            this.groupBox3.Controls.Add(this.btnLimpar);
            this.groupBox3.Controls.Add(this.btnClassificar);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(12, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 72);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightCyan;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Location = new System.Drawing.Point(419, 22);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(127, 35);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightCyan;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Location = new System.Drawing.Point(218, 22);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(127, 35);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnClassificar
            // 
            this.btnClassificar.BackColor = System.Drawing.Color.LightCyan;
            this.btnClassificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClassificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClassificar.Location = new System.Drawing.Point(11, 23);
            this.btnClassificar.Name = "btnClassificar";
            this.btnClassificar.Size = new System.Drawing.Size(127, 35);
            this.btnClassificar.TabIndex = 11;
            this.btnClassificar.Text = "&Classificar";
            this.btnClassificar.UseVisualStyleBackColor = false;
            this.btnClassificar.Click += new System.EventHandler(this.btnClassificar_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(110, -23);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(225, 23);
            this.textBox5.TabIndex = 10;
            // 
            // lblOrdenada
            // 
            this.lblOrdenada.Location = new System.Drawing.Point(17, 25);
            this.lblOrdenada.Name = "lblOrdenada";
            this.lblOrdenada.Size = new System.Drawing.Size(178, 170);
            this.lblOrdenada.TabIndex = 0;
            // 
            // frmOrdenarNomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(580, 371);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrdenarNomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classificar Nomes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome6;
        private System.Windows.Forms.TextBox txtNome4;
        private System.Windows.Forms.TextBox txtNome5;
        private System.Windows.Forms.TextBox txtNome3;
        private System.Windows.Forms.TextBox txtNome2;
        private System.Windows.Forms.TextBox txtNome1;
        private System.Windows.Forms.Label lblN6;
        private System.Windows.Forms.Label lblN5;
        private System.Windows.Forms.Label lblN4;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnClassificar;
        private System.Windows.Forms.Label lblOrdenada;
    }
}

