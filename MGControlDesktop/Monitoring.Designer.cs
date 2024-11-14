namespace MGControlDesktop {
    partial class Monitoring {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGrid_Funcionarios = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStrip_delogin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStrip_reset = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStrip_controlEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStrip_controlEscola = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_liberar = new System.Windows.Forms.Button();
            this.Btn_block = new System.Windows.Forms.Button();
            this.Lbl_credentials = new System.Windows.Forms.Label();
            this.Lbl_user = new System.Windows.Forms.Label();
            this.Lbl_role = new System.Windows.Forms.Label();
            this.Lbl_dbUser = new System.Windows.Forms.Label();
            this.Lbl_dbRole = new System.Windows.Forms.Label();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.Lbl_copyright = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Funcionarios)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Painel de Registros:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.DataGrid_Funcionarios);
            this.panel1.Location = new System.Drawing.Point(370, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 266);
            this.panel1.TabIndex = 1;
            // 
            // DataGrid_Funcionarios
            // 
            this.DataGrid_Funcionarios.AllowUserToAddRows = false;
            this.DataGrid_Funcionarios.AllowUserToDeleteRows = false;
            this.DataGrid_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Funcionarios.Location = new System.Drawing.Point(0, 0);
            this.DataGrid_Funcionarios.Name = "DataGrid_Funcionarios";
            this.DataGrid_Funcionarios.Size = new System.Drawing.Size(418, 266);
            this.DataGrid_Funcionarios.TabIndex = 0;
            this.DataGrid_Funcionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Funcionarios_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem,
            this.sistemasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStrip_delogin,
            this.btnStrip_reset});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // btnStrip_delogin
            // 
            this.btnStrip_delogin.Name = "btnStrip_delogin";
            this.btnStrip_delogin.Size = new System.Drawing.Size(120, 22);
            this.btnStrip_delogin.Text = "Deslogar";
            this.btnStrip_delogin.Click += new System.EventHandler(this.btnStrip_delogin_Click);
            // 
            // btnStrip_reset
            // 
            this.btnStrip_reset.Name = "btnStrip_reset";
            this.btnStrip_reset.Size = new System.Drawing.Size(120, 22);
            this.btnStrip_reset.Text = "Reset";
            this.btnStrip_reset.Click += new System.EventHandler(this.btnStrip_reset_Click);
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStrip_controlEmpresa,
            this.btnStrip_controlEscola});
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // btnStrip_controlEmpresa
            // 
            this.btnStrip_controlEmpresa.Name = "btnStrip_controlEmpresa";
            this.btnStrip_controlEmpresa.Size = new System.Drawing.Size(151, 22);
            this.btnStrip_controlEmpresa.Text = "CA - Empresas";
            this.btnStrip_controlEmpresa.Click += new System.EventHandler(this.btnStrip_controlEmpresa_Click);
            // 
            // btnStrip_controlEscola
            // 
            this.btnStrip_controlEscola.Name = "btnStrip_controlEscola";
            this.btnStrip_controlEscola.Size = new System.Drawing.Size(151, 22);
            this.btnStrip_controlEscola.Text = "CA - Escolas";
            this.btnStrip_controlEscola.Click += new System.EventHandler(this.btnStrip_controlEscola_Click);
            // 
            // Btn_liberar
            // 
            this.Btn_liberar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_liberar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_liberar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_liberar.Location = new System.Drawing.Point(12, 194);
            this.Btn_liberar.Name = "Btn_liberar";
            this.Btn_liberar.Size = new System.Drawing.Size(103, 38);
            this.Btn_liberar.TabIndex = 3;
            this.Btn_liberar.Text = "Liberar";
            this.Btn_liberar.UseVisualStyleBackColor = false;
            this.Btn_liberar.Click += new System.EventHandler(this.Btn_liberar_Click);
            // 
            // Btn_block
            // 
            this.Btn_block.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_block.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_block.Location = new System.Drawing.Point(162, 194);
            this.Btn_block.Name = "Btn_block";
            this.Btn_block.Size = new System.Drawing.Size(103, 38);
            this.Btn_block.TabIndex = 4;
            this.Btn_block.Text = "Bloquear";
            this.Btn_block.UseVisualStyleBackColor = false;
            this.Btn_block.Click += new System.EventHandler(this.Btn_block_Click);
            // 
            // Lbl_credentials
            // 
            this.Lbl_credentials.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_credentials.AutoSize = true;
            this.Lbl_credentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_credentials.Location = new System.Drawing.Point(84, 39);
            this.Lbl_credentials.Name = "Lbl_credentials";
            this.Lbl_credentials.Size = new System.Drawing.Size(132, 25);
            this.Lbl_credentials.TabIndex = 5;
            this.Lbl_credentials.Text = "Credenciais:";
            // 
            // Lbl_user
            // 
            this.Lbl_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_user.AutoSize = true;
            this.Lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_user.Location = new System.Drawing.Point(13, 89);
            this.Lbl_user.Name = "Lbl_user";
            this.Lbl_user.Size = new System.Drawing.Size(92, 25);
            this.Lbl_user.TabIndex = 6;
            this.Lbl_user.Text = "Usuário:";
            // 
            // Lbl_role
            // 
            this.Lbl_role.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_role.AutoSize = true;
            this.Lbl_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Lbl_role.Location = new System.Drawing.Point(16, 135);
            this.Lbl_role.Name = "Lbl_role";
            this.Lbl_role.Size = new System.Drawing.Size(76, 25);
            this.Lbl_role.TabIndex = 7;
            this.Lbl_role.Text = "Cargo:";
            // 
            // Lbl_dbUser
            // 
            this.Lbl_dbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_dbUser.AutoSize = true;
            this.Lbl_dbUser.Font = new System.Drawing.Font("Constantia", 13.75F);
            this.Lbl_dbUser.Location = new System.Drawing.Point(106, 92);
            this.Lbl_dbUser.Name = "Lbl_dbUser";
            this.Lbl_dbUser.Size = new System.Drawing.Size(0, 23);
            this.Lbl_dbUser.TabIndex = 8;
            // 
            // Lbl_dbRole
            // 
            this.Lbl_dbRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_dbRole.AutoSize = true;
            this.Lbl_dbRole.Font = new System.Drawing.Font("Constantia", 13.75F);
            this.Lbl_dbRole.Location = new System.Drawing.Point(106, 140);
            this.Lbl_dbRole.MaximumSize = new System.Drawing.Size(250, 0);
            this.Lbl_dbRole.Name = "Lbl_dbRole";
            this.Lbl_dbRole.Size = new System.Drawing.Size(0, 23);
            this.Lbl_dbRole.TabIndex = 9;
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // Lbl_copyright
            // 
            this.Lbl_copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_copyright.AutoSize = true;
            this.Lbl_copyright.Font = new System.Drawing.Font("Fira Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_copyright.Location = new System.Drawing.Point(9, 427);
            this.Lbl_copyright.Name = "Lbl_copyright";
            this.Lbl_copyright.Size = new System.Drawing.Size(270, 14);
            this.Lbl_copyright.TabIndex = 10;
            this.Lbl_copyright.Text = "© 2024 MGControl, todos os direitos reservados";
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_copyright);
            this.Controls.Add(this.Lbl_dbRole);
            this.Controls.Add(this.Lbl_dbUser);
            this.Controls.Add(this.Lbl_role);
            this.Controls.Add(this.Lbl_user);
            this.Controls.Add(this.Lbl_credentials);
            this.Controls.Add(this.Btn_block);
            this.Controls.Add(this.Btn_liberar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Monitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MGControl - Desktop (Monitoração)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Monitoring_FormClosing);
            this.Load += new System.EventHandler(this.Monitoring_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Funcionarios)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnStrip_delogin;
        private System.Windows.Forms.Button Btn_liberar;
        private System.Windows.Forms.Button Btn_block;
        private System.Windows.Forms.Label Lbl_credentials;
        private System.Windows.Forms.Label Lbl_user;
        private System.Windows.Forms.Label Lbl_role;
        private System.Windows.Forms.Label Lbl_dbUser;
        private System.Windows.Forms.Label Lbl_dbRole;
        private System.Windows.Forms.DataGridView DataGrid_Funcionarios;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private System.Windows.Forms.ToolStripMenuItem btnStrip_reset;
        private System.Windows.Forms.Label Lbl_copyright;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnStrip_controlEmpresa;
        private System.Windows.Forms.ToolStripMenuItem btnStrip_controlEscola;
    }
}