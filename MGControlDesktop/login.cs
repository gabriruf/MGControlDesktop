using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;
using Npgsql;
using NpgsqlTypes;
using BCrypt;

namespace MGControlDesktop {
    public partial class login : Form {

        public login() {
            InitializeComponent();
        }

        public NpgsqlConnection sqlConn;
        public NpgsqlCommand sqlCmd;
        public NpgsqlDataReader sqlRead;
        public string sqlStrConn = "Server=localhost;Port=5432;Username=postgres;password=pirocudo;Database=mgcontrol";
        public string sqlStrCode = "";

        private PrivateFontCollection mainFont = new PrivateFontCollection();
        private readonly string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

        private void login_Load(object sender, EventArgs e) {
            Btn_login.Enabled = false;
            Txt_email.TextChanged += new EventHandler(checkCharText);
            Txt_pwd.TextChanged += new EventHandler(checkCharText);
            
            mainFont.AddFontFile($"{projectPath}/fonts/FiraSansRegular.ttf");
            Lbl_appTitle.Font = new Font(mainFont.Families[0], 24, FontStyle.Regular);
        }

        void checkCharText(object sender, EventArgs e) {
            if (Txt_email.Text.Length == 0 || Txt_pwd.Text.Length == 0) {
                Btn_login.Enabled = false;
            } else {
                Btn_login.Enabled = true;
            }
        }

        void checkCreden() {
            if (Txt_pwd.TextLength < 12) {
                MessageBox.Show("Senha não cumpre os requisitos!\nRazão: Senha menor que 12 caracteres.", "Sistema informa!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            sqlConn = new NpgsqlConnection(sqlStrConn);
            sqlConn.Open();
            sqlStrCode = $"SELECT email, senha FROM seguranca WHERE email = '{Txt_email.Text}' AND (senha = crypt('{Txt_pwd.Text}', senha)) = true";

            sqlCmd = new NpgsqlCommand(sqlStrCode, sqlConn);
            sqlRead = sqlCmd.ExecuteReader();

            if (sqlRead.Read()) {
                new Monitoring().Show();
            } else {
                MessageBox.Show("Credenciais não encontrados!", "Sistema informa!");
            }
        }

        private void Btn_login_Click(object sender, EventArgs e) {
            checkCreden();
        }
    }
}

