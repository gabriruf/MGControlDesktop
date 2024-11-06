namespace MGControlDesktop
{
    partial class login
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
            this.Lbl_email = new System.Windows.Forms.Label();
            this.Lbl_pwd = new System.Windows.Forms.Label();
            this.Txt_email = new System.Windows.Forms.TextBox();
            this.Txt_pwd = new System.Windows.Forms.TextBox();
            this.Btn_login = new System.Windows.Forms.Button();
            this.Lbl_appTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_email
            // 
            this.Lbl_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_email.AutoSize = true;
            this.Lbl_email.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_email.Location = new System.Drawing.Point(158, 146);
            this.Lbl_email.Name = "Lbl_email";
            this.Lbl_email.Size = new System.Drawing.Size(94, 24);
            this.Lbl_email.TabIndex = 0;
            this.Lbl_email.Text = "E-mail:";
            // 
            // Lbl_pwd
            // 
            this.Lbl_pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_pwd.AutoSize = true;
            this.Lbl_pwd.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_pwd.Location = new System.Drawing.Point(170, 184);
            this.Lbl_pwd.Name = "Lbl_pwd";
            this.Lbl_pwd.Size = new System.Drawing.Size(82, 24);
            this.Lbl_pwd.TabIndex = 1;
            this.Lbl_pwd.Text = "Senha:";
            // 
            // Txt_email
            // 
            this.Txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_email.Font = new System.Drawing.Font("Lucida Console", 9.75F);
            this.Txt_email.Location = new System.Drawing.Point(259, 149);
            this.Txt_email.Name = "Txt_email";
            this.Txt_email.Size = new System.Drawing.Size(384, 20);
            this.Txt_email.TabIndex = 2;
            // 
            // Txt_pwd
            // 
            this.Txt_pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_pwd.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_pwd.Location = new System.Drawing.Point(259, 189);
            this.Txt_pwd.Name = "Txt_pwd";
            this.Txt_pwd.Size = new System.Drawing.Size(384, 20);
            this.Txt_pwd.TabIndex = 3;
            this.Txt_pwd.UseSystemPasswordChar = true;
            // 
            // Btn_login
            // 
            this.Btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_login.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.Btn_login.Location = new System.Drawing.Point(350, 285);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(120, 70);
            this.Btn_login.TabIndex = 4;
            this.Btn_login.Text = "Entrar";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Lbl_appTitle
            // 
            this.Lbl_appTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_appTitle.AutoSize = true;
            this.Lbl_appTitle.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_appTitle.Location = new System.Drawing.Point(239, 38);
            this.Lbl_appTitle.Name = "Lbl_appTitle";
            this.Lbl_appTitle.Size = new System.Drawing.Size(323, 37);
            this.Lbl_appTitle.TabIndex = 5;
            this.Lbl_appTitle.Text = "MGControl Desktop";
            this.Lbl_appTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_appTitle);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.Txt_pwd);
            this.Controls.Add(this.Txt_email);
            this.Controls.Add(this.Lbl_pwd);
            this.Controls.Add(this.Lbl_email);
            this.Name = "login";
            this.Text = "MGControl - Desktop (Login)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_email;
        private System.Windows.Forms.Label Lbl_pwd;
        private System.Windows.Forms.TextBox Txt_email;
        private System.Windows.Forms.TextBox Txt_pwd;
        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.Label Lbl_appTitle;
    }
}

