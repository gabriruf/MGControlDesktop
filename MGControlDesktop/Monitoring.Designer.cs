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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_liberar = new System.Windows.Forms.Button();
            this.Btn_block = new System.Windows.Forms.Button();
            this.Lbl_credentials = new System.Windows.Forms.Label();
            this.Lbl_user = new System.Windows.Forms.Label();
            this.Lbl_role = new System.Windows.Forms.Label();
            this.Lbl_dbUser = new System.Windows.Forms.Label();
            this.Lbl_dbRole = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registros de Operações:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(477, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 266);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem,
            this.monitoraçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deslogarToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // deslogarToolStripMenuItem
            // 
            this.deslogarToolStripMenuItem.Name = "deslogarToolStripMenuItem";
            this.deslogarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.deslogarToolStripMenuItem.Text = "Deslogar";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // monitoraçãoToolStripMenuItem
            // 
            this.monitoraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem1});
            this.monitoraçãoToolStripMenuItem.Name = "monitoraçãoToolStripMenuItem";
            this.monitoraçãoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.monitoraçãoToolStripMenuItem.Text = "Monitoração";
            // 
            // resetToolStripMenuItem1
            // 
            this.resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
            this.resetToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem1.Text = "Reset";
            // 
            // Btn_liberar
            // 
            this.Btn_liberar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_liberar.Location = new System.Drawing.Point(12, 194);
            this.Btn_liberar.Name = "Btn_liberar";
            this.Btn_liberar.Size = new System.Drawing.Size(103, 38);
            this.Btn_liberar.TabIndex = 3;
            this.Btn_liberar.Text = "Liberar";
            this.Btn_liberar.UseVisualStyleBackColor = true;
            // 
            // Btn_block
            // 
            this.Btn_block.Font = new System.Drawing.Font("Cambria", 12F);
            this.Btn_block.Location = new System.Drawing.Point(162, 194);
            this.Btn_block.Name = "Btn_block";
            this.Btn_block.Size = new System.Drawing.Size(103, 38);
            this.Btn_block.TabIndex = 4;
            this.Btn_block.Text = "Bloquear";
            this.Btn_block.UseVisualStyleBackColor = true;
            // 
            // Lbl_credentials
            // 
            this.Lbl_credentials.AutoSize = true;
            this.Lbl_credentials.Font = new System.Drawing.Font("Constantia", 15.75F);
            this.Lbl_credentials.Location = new System.Drawing.Point(84, 39);
            this.Lbl_credentials.Name = "Lbl_credentials";
            this.Lbl_credentials.Size = new System.Drawing.Size(124, 26);
            this.Lbl_credentials.TabIndex = 5;
            this.Lbl_credentials.Text = "Credenciais:";
            // 
            // Lbl_user
            // 
            this.Lbl_user.AutoSize = true;
            this.Lbl_user.Font = new System.Drawing.Font("Constantia", 13.75F);
            this.Lbl_user.Location = new System.Drawing.Point(13, 89);
            this.Lbl_user.Name = "Lbl_user";
            this.Lbl_user.Size = new System.Drawing.Size(79, 23);
            this.Lbl_user.TabIndex = 6;
            this.Lbl_user.Text = "Usuário:";
            // 
            // Lbl_role
            // 
            this.Lbl_role.AutoSize = true;
            this.Lbl_role.Font = new System.Drawing.Font("Constantia", 13.75F);
            this.Lbl_role.Location = new System.Drawing.Point(16, 135);
            this.Lbl_role.Name = "Lbl_role";
            this.Lbl_role.Size = new System.Drawing.Size(63, 23);
            this.Lbl_role.TabIndex = 7;
            this.Lbl_role.Text = "Cargo:";
            // 
            // Lbl_dbUser
            // 
            this.Lbl_dbUser.AutoSize = true;
            this.Lbl_dbUser.Font = new System.Drawing.Font("Constantia", 13.75F);
            this.Lbl_dbUser.Location = new System.Drawing.Point(98, 89);
            this.Lbl_dbUser.Name = "Lbl_dbUser";
            this.Lbl_dbUser.Size = new System.Drawing.Size(0, 23);
            this.Lbl_dbUser.TabIndex = 8;
            // 
            // Lbl_dbRole
            // 
            this.Lbl_dbRole.AutoSize = true;
            this.Lbl_dbRole.Font = new System.Drawing.Font("Constantia", 13.75F);
            this.Lbl_dbRole.Location = new System.Drawing.Point(98, 135);
            this.Lbl_dbRole.Name = "Lbl_dbRole";
            this.Lbl_dbRole.Size = new System.Drawing.Size(0, 23);
            this.Lbl_dbRole.TabIndex = 9;
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "MGControl - Desktop (Monitoração)";
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
        private System.Windows.Forms.ToolStripMenuItem deslogarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitoraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem1;
        private System.Windows.Forms.Button Btn_liberar;
        private System.Windows.Forms.Button Btn_block;
        private System.Windows.Forms.Label Lbl_credentials;
        private System.Windows.Forms.Label Lbl_user;
        private System.Windows.Forms.Label Lbl_role;
        private System.Windows.Forms.Label Lbl_dbUser;
        private System.Windows.Forms.Label Lbl_dbRole;
    }
}