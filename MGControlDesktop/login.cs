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
        public string sqlStrConn = "Server=localhost;Port=5432;Username=postgres;password=root;Database=mgcontrol";
        public string sqlStrCode = "";

        private void login_Load(object sender, EventArgs e) {
            Btn_login.Enabled = false;
            Txt_email.TextChanged += new EventHandler(checkCharText);
            Txt_pwd.TextChanged += new EventHandler(checkCharText);
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
                Txt_email.Clear();
                Txt_pwd.Clear();
                Txt_email.Focus();
            } else {
                sqlConn = new NpgsqlConnection(sqlStrConn);
                sqlConn.Open();
                sqlStrCode = $"SELECT email, senha FROM seguranca WHERE email = '{Txt_email.Text}' AND (senha = crypt('{Txt_pwd.Text}', senha)) = true";

                sqlCmd = new NpgsqlCommand(sqlStrCode, sqlConn);
                sqlRead = sqlCmd.ExecuteReader();

                if (sqlRead.Read()) {
                    this.Hide();
                    new Monitoring().Show();
                } else {
                    MessageBox.Show("Credenciais não encontrados!", "Sistema informa!");
                    Txt_email.Clear();
                    Txt_pwd.Clear();
                    Txt_email.Focus();
                }
            }
        }

        private void Btn_login_Click(object sender, EventArgs e) {
            checkCreden();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}

