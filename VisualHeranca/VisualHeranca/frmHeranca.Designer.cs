namespace VisualHeranca
{
    partial class frmHeranca
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtFone = new System.Windows.Forms.MaskedTextBox();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.MaskedTextBox();
            this.btnProcessa = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSaiir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(41, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome";
            // 
            // lblEndereco
            // 
            this.lblEndereco.Location = new System.Drawing.Point(14, 51);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(89, 18);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereco";
            // 
            // lblCidade
            // 
            this.lblCidade.Location = new System.Drawing.Point(34, 82);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(69, 18);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade";
            // 
            // lblFone
            // 
            this.lblFone.Location = new System.Drawing.Point(48, 111);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(54, 18);
            this.lblFone.TabIndex = 3;
            this.lblFone.Text = "Fone";
            // 
            // lblFuncao
            // 
            this.lblFuncao.Location = new System.Drawing.Point(29, 141);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(70, 18);
            this.lblFuncao.TabIndex = 4;
            this.lblFuncao.Text = "Função";
            // 
            // lblSalario
            // 
            this.lblSalario.Location = new System.Drawing.Point(31, 173);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(70, 18);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Salario";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(111, 10);
            this.txtNome.MaxLength = 45;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(445, 24);
            this.txtNome.TabIndex = 6;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(111, 42);
            this.txtEndereco.MaxLength = 45;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(445, 24);
            this.txtEndereco.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(111, 79);
            this.txtCidade.MaxLength = 35;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(445, 24);
            this.txtCidade.TabIndex = 8;
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(111, 105);
            this.txtFone.Mask = "(99) 00000-0000";
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(112, 24);
            this.txtFone.TabIndex = 9;
            // 
            // txtFuncao
            // 
            this.txtFuncao.Location = new System.Drawing.Point(111, 138);
            this.txtFuncao.MaxLength = 30;
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(238, 24);
            this.txtFuncao.TabIndex = 10;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(111, 170);
            this.txtSalario.Mask = "999999.99";
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(132, 24);
            this.txtSalario.TabIndex = 11;
            // 
            // btnProcessa
            // 
            this.btnProcessa.Location = new System.Drawing.Point(51, 219);
            this.btnProcessa.Name = "btnProcessa";
            this.btnProcessa.Size = new System.Drawing.Size(75, 23);
            this.btnProcessa.TabIndex = 12;
            this.btnProcessa.Text = "&Processa";
            this.btnProcessa.UseVisualStyleBackColor = true;
            this.btnProcessa.Click += new System.EventHandler(this.btnProcessa_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(446, 219);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(0, 0);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(257, 219);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSaiir
            // 
            this.btnSaiir.Location = new System.Drawing.Point(446, 219);
            this.btnSaiir.Name = "btnSaiir";
            this.btnSaiir.Size = new System.Drawing.Size(75, 23);
            this.btnSaiir.TabIndex = 15;
            this.btnSaiir.Text = "&Sair";
            this.btnSaiir.UseVisualStyleBackColor = true;
            this.btnSaiir.Click += new System.EventHandler(this.btnSaiir_Click);
            // 
            // frmHeranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 254);
            this.Controls.Add(this.btnSaiir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnProcessa);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHeranca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Herança em C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox txtFone;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.MaskedTextBox txtSalario;
        private System.Windows.Forms.Button btnProcessa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSaiir;
    }
}

