namespace Classe1
{
    partial class frmClasse1
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
            this.labelPI = new System.Windows.Forms.Label();
            this.txtPI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPI
            // 
            this.labelPI.AutoSize = true;
            this.labelPI.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPI.Location = new System.Drawing.Point(17, 28);
            this.labelPI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPI.Name = "labelPI";
            this.labelPI.Size = new System.Drawing.Size(109, 16);
            this.labelPI.TabIndex = 0;
            this.labelPI.Text = "O Valor De Pi: ";
            // 
            // txtPI
            // 
            this.txtPI.Location = new System.Drawing.Point(202, 25);
            this.txtPI.Name = "txtPI";
            this.txtPI.Size = new System.Drawing.Size(102, 23);
            this.txtPI.TabIndex = 1;
            this.txtPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmClasse1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 67);
            this.Controls.Add(this.txtPI);
            this.Controls.Add(this.labelPI);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClasse1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classe do PI";
            this.Load += new System.EventHandler(this.frmClasse1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPI;
        private System.Windows.Forms.TextBox txtPI;
    }
}

