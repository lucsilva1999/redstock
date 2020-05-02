namespace RedStock
{
    partial class telaLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLogin));
            this.btnLoginEntrar = new System.Windows.Forms.Button();
            this.btnLoginSair = new System.Windows.Forms.Button();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.imgRedStockLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgRedStockLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoginEntrar
            // 
            this.btnLoginEntrar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLoginEntrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLoginEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnLoginEntrar.Location = new System.Drawing.Point(119, 187);
            this.btnLoginEntrar.Name = "btnLoginEntrar";
            this.btnLoginEntrar.Size = new System.Drawing.Size(138, 50);
            this.btnLoginEntrar.TabIndex = 1;
            this.btnLoginEntrar.Text = "Entrar";
            this.btnLoginEntrar.UseVisualStyleBackColor = false;
            this.btnLoginEntrar.Click += new System.EventHandler(this.btnLoginEntrar_Click);
            // 
            // btnLoginSair
            // 
            this.btnLoginSair.BackColor = System.Drawing.Color.Crimson;
            this.btnLoginSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLoginSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginSair.ForeColor = System.Drawing.Color.Black;
            this.btnLoginSair.Location = new System.Drawing.Point(283, 187);
            this.btnLoginSair.Name = "btnLoginSair";
            this.btnLoginSair.Size = new System.Drawing.Size(138, 50);
            this.btnLoginSair.TabIndex = 2;
            this.btnLoginSair.Text = "Sair";
            this.btnLoginSair.UseVisualStyleBackColor = false;
            this.btnLoginSair.Click += new System.EventHandler(this.btnLoginSair_Click);
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Location = new System.Drawing.Point(176, 96);
            this.txtLoginUsuario.MaxLength = 20;
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(165, 26);
            this.txtLoginUsuario.TabIndex = 3;
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.Location = new System.Drawing.Point(176, 151);
            this.txtLoginSenha.MaxLength = 20;
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.Size = new System.Drawing.Size(165, 26);
            this.txtLoginSenha.TabIndex = 4;
            this.txtLoginSenha.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.Location = new System.Drawing.Point(172, 73);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.SystemColors.Control;
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSenha.Location = new System.Drawing.Point(174, 127);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 20);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha";
            // 
            // imgRedStockLogo
            // 
            this.imgRedStockLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgRedStockLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgRedStockLogo.Image")));
            this.imgRedStockLogo.Location = new System.Drawing.Point(176, -37);
            this.imgRedStockLogo.Name = "imgRedStockLogo";
            this.imgRedStockLogo.Size = new System.Drawing.Size(165, 148);
            this.imgRedStockLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRedStockLogo.TabIndex = 0;
            this.imgRedStockLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(140, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnLoginSair;
            this.ClientSize = new System.Drawing.Size(537, 268);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtLoginSenha);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.btnLoginSair);
            this.Controls.Add(this.btnLoginEntrar);
            this.Controls.Add(this.imgRedStockLogo);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaLogin";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedStock - Gerenciamento de Produtos";
            this.Load += new System.EventHandler(this.telaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgRedStockLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgRedStockLogo;
        private System.Windows.Forms.Button btnLoginEntrar;
        private System.Windows.Forms.Button btnLoginSair;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtLoginSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}