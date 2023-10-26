namespace SIstemas_de_menus
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoDaMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificarNomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeNomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentarImagemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relogioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairDoProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçoesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçoesToolStripMenuItem
            // 
            this.opçoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculoDaMediaToolStripMenuItem,
            this.classificarNomesToolStripMenuItem,
            this.listaDeNomesToolStripMenuItem,
            this.movimentarImagemsToolStripMenuItem,
            this.visualizarImagemToolStripMenuItem,
            this.relogioToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairDoProgramaToolStripMenuItem});
            this.opçoesToolStripMenuItem.Name = "opçoesToolStripMenuItem";
            this.opçoesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçoesToolStripMenuItem.Text = "&Opções";
            // 
            // calculoDaMediaToolStripMenuItem
            // 
            this.calculoDaMediaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculoDaMediaToolStripMenuItem.Image")));
            this.calculoDaMediaToolStripMenuItem.Name = "calculoDaMediaToolStripMenuItem";
            this.calculoDaMediaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculoDaMediaToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.calculoDaMediaToolStripMenuItem.Text = "Calculo da media";
            this.calculoDaMediaToolStripMenuItem.Click += new System.EventHandler(this.calculoDaMediaToolStripMenuItem_Click);
            // 
            // classificarNomesToolStripMenuItem
            // 
            this.classificarNomesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("classificarNomesToolStripMenuItem.Image")));
            this.classificarNomesToolStripMenuItem.Name = "classificarNomesToolStripMenuItem";
            this.classificarNomesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.classificarNomesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.classificarNomesToolStripMenuItem.Text = "Classificar Nomes";
            this.classificarNomesToolStripMenuItem.Click += new System.EventHandler(this.classificarNomesToolStripMenuItem_Click);
            // 
            // listaDeNomesToolStripMenuItem
            // 
            this.listaDeNomesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaDeNomesToolStripMenuItem.Image")));
            this.listaDeNomesToolStripMenuItem.Name = "listaDeNomesToolStripMenuItem";
            this.listaDeNomesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listaDeNomesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.listaDeNomesToolStripMenuItem.Text = "Lista de Nomes";
            this.listaDeNomesToolStripMenuItem.Click += new System.EventHandler(this.listaDeNomesToolStripMenuItem_Click);
            // 
            // movimentarImagemsToolStripMenuItem
            // 
            this.movimentarImagemsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("movimentarImagemsToolStripMenuItem.Image")));
            this.movimentarImagemsToolStripMenuItem.Name = "movimentarImagemsToolStripMenuItem";
            this.movimentarImagemsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.movimentarImagemsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.movimentarImagemsToolStripMenuItem.Text = "Movimentar Imagem";
            this.movimentarImagemsToolStripMenuItem.Click += new System.EventHandler(this.movimentarImagemsToolStripMenuItem_Click);
            // 
            // visualizarImagemToolStripMenuItem
            // 
            this.visualizarImagemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visualizarImagemToolStripMenuItem.Image")));
            this.visualizarImagemToolStripMenuItem.Name = "visualizarImagemToolStripMenuItem";
            this.visualizarImagemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.visualizarImagemToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.visualizarImagemToolStripMenuItem.Text = "Visualizar Imagem";
            this.visualizarImagemToolStripMenuItem.Click += new System.EventHandler(this.visualizarImagemToolStripMenuItem_Click);
            // 
            // relogioToolStripMenuItem
            // 
            this.relogioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relogioToolStripMenuItem.Image")));
            this.relogioToolStripMenuItem.Name = "relogioToolStripMenuItem";
            this.relogioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.relogioToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.relogioToolStripMenuItem.Text = "Relogio";
            this.relogioToolStripMenuItem.Click += new System.EventHandler(this.relogioToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // sairDoProgramaToolStripMenuItem
            // 
            this.sairDoProgramaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairDoProgramaToolStripMenuItem.Image")));
            this.sairDoProgramaToolStripMenuItem.Name = "sairDoProgramaToolStripMenuItem";
            this.sairDoProgramaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairDoProgramaToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.sairDoProgramaToolStripMenuItem.Text = "Sair do Programa";
            this.sairDoProgramaToolStripMenuItem.Click += new System.EventHandler(this.sairDoProgramaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "Menu de Aplicativos em C#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoDaMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classificarNomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeNomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentarImagemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relogioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairDoProgramaToolStripMenuItem;
    }
}

