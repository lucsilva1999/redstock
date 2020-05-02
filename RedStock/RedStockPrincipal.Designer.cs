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
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarMinhaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarTransacoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checarCEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotacaoDeMoedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarCPNJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarTransferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarMateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarAtualizacoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRedStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuRedStock
            // 
            this.menuRedStock.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuRedStock.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuRedStock.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuRedStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.utilitarioToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.verificarAtualizacoesToolStripMenuItem});
            this.menuRedStock.Location = new System.Drawing.Point(0, 0);
            this.menuRedStock.Name = "menuRedStock";
            this.menuRedStock.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuRedStock.Size = new System.Drawing.Size(800, 33);
            this.menuRedStock.TabIndex = 0;
            this.menuRedStock.Text = "menuRedStock";
            this.menuRedStock.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuRedStock_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarMinhaSenhaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.inicioToolStripMenuItem.Text = "Início";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inícioToolStripMenuItem_Click);
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
            this.cadastrarUsuarioToolStripMenuItem,
            this.gerenciarUsuariosToolStripMenuItem,
            this.verificarTransacoesToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.produtosToolStripMenuItem.Text = "Sistema";
            // 
            // cadastrarUsuarioToolStripMenuItem
            // 
            this.cadastrarUsuarioToolStripMenuItem.Image = global::RedStock.Properties.Resources.users;
            this.cadastrarUsuarioToolStripMenuItem.Name = "cadastrarUsuarioToolStripMenuItem";
            this.cadastrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cadastrarUsuarioToolStripMenuItem.Text = "Cadastrar Usuário";
            // 
            // gerenciarUsuariosToolStripMenuItem
            // 
            this.gerenciarUsuariosToolStripMenuItem.Image = global::RedStock.Properties.Resources.agenda;
            this.gerenciarUsuariosToolStripMenuItem.Name = "gerenciarUsuariosToolStripMenuItem";
            this.gerenciarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gerenciarUsuariosToolStripMenuItem.Text = "Gerenciar Usuários";
            // 
            // verificarTransacoesToolStripMenuItem
            // 
            this.verificarTransacoesToolStripMenuItem.Image = global::RedStock.Properties.Resources.route;
            this.verificarTransacoesToolStripMenuItem.Name = "verificarTransacoesToolStripMenuItem";
            this.verificarTransacoesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verificarTransacoesToolStripMenuItem.Text = "Verificar transações";
            // 
            // utilitarioToolStripMenuItem
            // 
            this.utilitarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checarCEPToolStripMenuItem,
            this.cotacaoDeMoedasToolStripMenuItem,
            this.pesquisarCPNJToolStripMenuItem});
            this.utilitarioToolStripMenuItem.Name = "utilitarioToolStripMenuItem";
            this.utilitarioToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.utilitarioToolStripMenuItem.Text = "Utilitário";
            // 
            // checarCEPToolStripMenuItem
            // 
            this.checarCEPToolStripMenuItem.Image = global::RedStock.Properties.Resources.search_1;
            this.checarCEPToolStripMenuItem.Name = "checarCEPToolStripMenuItem";
            this.checarCEPToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.checarCEPToolStripMenuItem.Text = "Pesquisar CEP";
            // 
            // cotacaoDeMoedasToolStripMenuItem
            // 
            this.cotacaoDeMoedasToolStripMenuItem.Image = global::RedStock.Properties.Resources.internet;
            this.cotacaoDeMoedasToolStripMenuItem.Name = "cotacaoDeMoedasToolStripMenuItem";
            this.cotacaoDeMoedasToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.cotacaoDeMoedasToolStripMenuItem.Text = "Cotação de Moedas";
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
            this.pesquisarTransferenciasToolStripMenuItem,
            this.pesquisarMateriaPrimaToolStripMenuItem});
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
            // pesquisarTransferenciasToolStripMenuItem
            // 
            this.pesquisarTransferenciasToolStripMenuItem.Name = "pesquisarTransferenciasToolStripMenuItem";
            this.pesquisarTransferenciasToolStripMenuItem.Size = new System.Drawing.Size(304, 34);
            this.pesquisarTransferenciasToolStripMenuItem.Text = "Pesquisar Transferências";
            // 
            // pesquisarMateriaPrimaToolStripMenuItem
            // 
            this.pesquisarMateriaPrimaToolStripMenuItem.Name = "pesquisarMateriaPrimaToolStripMenuItem";
            this.pesquisarMateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(304, 34);
            this.pesquisarMateriaPrimaToolStripMenuItem.Text = "Pesquisar Matéria-Prima";
            // 
            // verificarAtualizacoesToolStripMenuItem
            // 
            this.verificarAtualizacoesToolStripMenuItem.ForeColor = System.Drawing.Color.Firebrick;
            this.verificarAtualizacoesToolStripMenuItem.Name = "verificarAtualizacoesToolStripMenuItem";
            this.verificarAtualizacoesToolStripMenuItem.Size = new System.Drawing.Size(193, 29);
            this.verificarAtualizacoesToolStripMenuItem.Text = "Verificar Atualizações";
            this.verificarAtualizacoesToolStripMenuItem.Click += new System.EventHandler(this.verificarAtualizaçõesToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarMinhaSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarTransacoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checarCEPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotacaoDeMoedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarCPNJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarTransferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarMateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarAtualizacoesToolStripMenuItem;
    }
}

