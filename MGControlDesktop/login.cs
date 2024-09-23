using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGControlDesktop {
    public partial class login : Form {
        public login() {
            InitializeComponent();
        }

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

        void checkPwd() {
            if (Txt_pwd.TextLength < 12) {
                MessageBox.Show("Senha não cumpre os requisitos!\nRazão: Senha menor que 12 caracteres."
                    , "Sistema informa!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_login_Click(object sender, EventArgs e) {
            checkPwd();
        }
    }
}

