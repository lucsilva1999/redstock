namespace RedStock
{
    partial class formPrincipalRedStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipalRedStock));
            this.menuRedStock = new System.Windows.Forms.MenuStrip();
            this.inícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarMinhaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarTransaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checarCEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotaçãoDeMoedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarCPNJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarTransferênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarMatériaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarAtualizaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRedStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuRedStock
            // 
            this.menuRedStock.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuRedStock.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuRedStock.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuRedStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inícioToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.utilitárioToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.verificarAtualizaçõesToolStripMenuItem});
            this.menuRedStock.Location = new System.Drawing.Point(0, 0);
            this.menuRedStock.Name = "menuRedStock";
            this.menuRedStock.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuRedStock.Size = new System.Drawing.Size(800, 33);
            this.menuRedStock.TabIndex = 0;
            this.menuRedStock.Text = "menuRedStock";
            this.menuRedStock.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuRedStock_ItemClicked);
            // 
            // inícioToolStripMenuItem
            // 
            this.inícioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarMinhaSenhaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            this.inícioToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.inícioToolStripMenuItem.Text = "Início";
            this.inícioToolStripMenuItem.Click += new System.EventHandler(this.inícioToolStripMenuItem_Click);
            // 
            // alterarMinhaSenhaToolStripMenuItem
            // 
            this.alterarMinhaSenhaToolStripMenuItem.Image = global::RedStock.Properties.Resources.fingerprint;
            this.alterarMinhaSenhaToolStripMenuItem.Name = "alterarMinhaSenhaToolStripMenuItem";
            this.alterarMinhaSenhaToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.alterarMinhaSenhaToolStripMenuItem.Text = "Alterar minha senha";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::RedStock.Properties.Resources.exit_1;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.gerenciarUsuáriosToolStripMenuItem,
            this.verificarTransaçõesToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.produtosToolStripMenuItem.Text = "Sistema";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Image = global::RedStock.Properties.Resources.users;
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            // 
            // gerenciarUsuáriosToolStripMenuItem
            // 
            this.gerenciarUsuáriosToolStripMenuItem.Image = global::RedStock.Properties.Resources.agenda;
            this.gerenciarUsuáriosToolStripMenuItem.Name = "gerenciarUsuáriosToolStripMenuItem";
            this.gerenciarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gerenciarUsuáriosToolStripMenuItem.Text = "Gerenciar Usuários";
            // 
            // verificarTransaçõesToolStripMenuItem
            // 
            this.verificarTransaçõesToolStripMenuItem.Image = global::RedStock.Properties.Resources.route;
            this.verificarTransaçõesToolStripMenuItem.Name = "verificarTransaçõesToolStripMenuItem";
            this.verificarTransaçõesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verificarTransaçõesToolStripMenuItem.Text = "Verificar transações";
            // 
            // utilitárioToolStripMenuItem
            // 
            this.utilitárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checarCEPToolStripMenuItem,
            this.cotaçãoDeMoedasToolStripMenuItem,
            this.pesquisarCPNJToolStripMenuItem});
            this.utilitárioToolStripMenuItem.Name = "utilitárioToolStripMenuItem";
            this.utilitárioToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.utilitárioToolStripMenuItem.Text = "Utilitário";
            // 
            // checarCEPToolStripMenuItem
            // 
            this.checarCEPToolStripMenuItem.Image = global::RedStock.Properties.Resources.search_1;
            this.checarCEPToolStripMenuItem.Name = "checarCEPToolStripMenuItem";
            this.checarCEPToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.checarCEPToolStripMenuItem.Text = "Pesquisar CEP";
            // 
            // cotaçãoDeMoedasToolStripMenuItem
            // 
            this.cotaçãoDeMoedasToolStripMenuItem.Image = global::RedStock.Properties.Resources.internet;
            this.cotaçãoDeMoedasToolStripMenuItem.Name = "cotaçãoDeMoedasToolStripMenuItem";
            this.cotaçãoDeMoedasToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.cotaçãoDeMoedasToolStripMenuItem.Text = "Cotação de Moedas";
            // 
            // pesquisarCPNJToolStripMenuItem
            // 
            this.pesquisarCPNJToolStripMenuItem.Image = global::RedStock.Properties.Resources.notepad;
            this.pesquisarCPNJToolStripMenuItem.Name = "pesquisarCPNJToolStripMenuItem";
            this.pesquisarCPNJToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.pesquisarCPNJToolStripMenuItem.Text = "Pesquisar CPNJ";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarProdutoToolStripMenuItem,
            this.pesquisarTransferênciasToolStripMenuItem,
            this.pesquisarMatériaPrimaToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // pesquisarProdutoToolStripMenuItem
            // 
            this.pesquisarProdutoToolStripMenuItem.Image = global::RedStock.Properties.Resources.list;
            this.pesquisarProdutoToolStripMenuItem.Name = "pesquisarProdutoToolStripMenuItem";
            this.pesquisarProdutoToolStripMenuItem.Size = new System.Drawing.Size(304, 34);
            this.pesquisarProdutoToolStripMenuItem.Text = "Pesquisar Produto";
            // 
            // pesquisarTransferênciasToolStripMenuItem
            // 
            this.pesquisarTransferênciasToolStripMenuItem.Name = "pesquisarTransferênciasToolStripMenuItem";
            this.pesquisarTransferênciasToolStripMenuItem.Size = new System.Drawing.Size(304, 34);
            this.pesquisarTransferênciasToolStripMenuItem.Text = "Pesquisar Transferências";
            // 
            // pesquisarMatériaPrimaToolStripMenuItem
            // 
            this.pesquisarMatériaPrimaToolStripMenuItem.Name = "pesquisarMatériaPrimaToolStripMenuItem";
            this.pesquisarMatériaPrimaToolStripMenuItem.Size = new System.Drawing.Size(304, 34);
            this.pesquisarMatériaPrimaToolStripMenuItem.Text = "Pesquisar Matéria-Prima";
            // 
            // verificarAtualizaçõesToolStripMenuItem
            // 
            this.verificarAtualizaçõesToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.verificarAtualizaçõesToolStripMenuItem.Name = "verificarAtualizaçõesToolStripMenuItem";
            this.verificarAtualizaçõesToolStripMenuItem.Size = new System.Drawing.Size(193, 29);
            this.verificarAtualizaçõesToolStripMenuItem.Text = "Verificar Atualizações";
            this.verificarAtualizaçõesToolStripMenuItem.Click += new System.EventHandler(this.verificarAtualizaçõesToolStripMenuItem_Click);
            // 
            // formPrincipalRedStock
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuRedStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuRedStock;
            this.MaximizeBox = false;
            this.Name = "formPrincipalRedStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedStock - Gerenciamento de Produtos";
            this.Load += new System.EventHandler(this.formPrincipalRedStock_Load);
            this.menuRedStock.ResumeLayout(false);
            this.menuRedStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuRedStock;
        private System.Windows.Forms.ToolStripMenuItem inícioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarMinhaSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarTransaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checarCEPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotaçãoDeMoedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarCPNJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarTransferênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarMatériaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarAtualizaçõesToolStripMenuItem;
    }
}

