namespace VisualizadorDeImagens
{
    partial class FrmImagem
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
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagem
            // 
            this.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagem.Location = new System.Drawing.Point(12, 12);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(520, 391);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(382, 409);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 47);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "&Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(463, 409);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 47);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.Filter = "Arquivos de Imagens | (\".\")";
            this.dlgAbrir.InitialDirectory = "C:\\Users\\Davi.rsouza2\\Downloads\\Imagens de aulas";
            this.dlgAbrir.Title = "Abertura de Imagens";
            // 
            // FrmImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 517);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.picImagem);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "visualizador de imagem";
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
    }
}

