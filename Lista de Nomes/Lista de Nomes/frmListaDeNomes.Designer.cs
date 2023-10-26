namespace Lista_de_Nomes
{
    partial class frmListaDeNomes
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
            this.lblNomeLista = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lstNome = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRm = new System.Windows.Forms.Button();
            this.btnRmT = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeLista
            // 
            this.lblNomeLista.AutoSize = true;
            this.lblNomeLista.Location = new System.Drawing.Point(11, 28);
            this.lblNomeLista.Name = "lblNomeLista";
            this.lblNomeLista.Size = new System.Drawing.Size(127, 16);
            this.lblNomeLista.TabIndex = 0;
            this.lblNomeLista.Text = "Item para a lista";
            this.lblNomeLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(146, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(226, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstNome
            // 
            this.lstNome.FormattingEnabled = true;
            this.lstNome.ItemHeight = 16;
            this.lstNome.Location = new System.Drawing.Point(28, 73);
            this.lstNome.Name = "lstNome";
            this.lstNome.Size = new System.Drawing.Size(213, 276);
            this.lstNome.Sorted = true;
            this.lstNome.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(251, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Adicionar Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRm
            // 
            this.btnRm.Location = new System.Drawing.Point(251, 132);
            this.btnRm.Name = "btnRm";
            this.btnRm.Size = new System.Drawing.Size(126, 32);
            this.btnRm.TabIndex = 4;
            this.btnRm.Text = "Remover Item";
            this.btnRm.UseVisualStyleBackColor = true;
            this.btnRm.Click += new System.EventHandler(this.btnRm_Click);
            // 
            // btnRmT
            // 
            this.btnRmT.Location = new System.Drawing.Point(251, 191);
            this.btnRmT.Name = "btnRmT";
            this.btnRmT.Size = new System.Drawing.Size(126, 32);
            this.btnRmT.TabIndex = 5;
            this.btnRmT.Text = "Remover &Tudo";
            this.btnRmT.UseVisualStyleBackColor = true;
            this.btnRmT.Click += new System.EventHandler(this.btnRmT_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(251, 250);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(126, 32);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(251, 309);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(126, 32);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmListaDeNomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRmT);
            this.Controls.Add(this.btnRm);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomeLista);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaDeNomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Nomes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeLista;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox lstNome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRm;
        private System.Windows.Forms.Button btnRmT;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

