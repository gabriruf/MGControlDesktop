using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace MGControlDesktop {
    public partial class Monitoring : Form {

        public NpgsqlConnection sqlConn;
        public NpgsqlCommand sqlCmd;
        public NpgsqlDataReader sqlRead;
        public NpgsqlDataAdapter sqlAdapter;
        public string sqlStrConn = "Server=localhost;Port=5432;Username=postgres;password=root;Database=mgcontrol";
        public string sqlStrCode = "";

        private PrivateFontCollection mainFont = new PrivateFontCollection();
        private readonly string projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;

        public Monitoring() {
            InitializeComponent();
        }

        private void Monitoring_Load(object sender, EventArgs e) {
            Lbl_dbUser.Text = String.Empty;
            Lbl_dbRole.Text = String.Empty;
            LoadDataSchool();

            mainFont.AddFontFile($"{projectPath}/fonts/FiraSansRegular.ttf");
            Lbl_dbRole.Font = new Font(mainFont.Families[0], 12, FontStyle.Regular);
            Lbl_dbUser.Font = new Font(mainFont.Families[0], 12, FontStyle.Regular);
            Lbl_copyright.Font = new Font(mainFont.Families[0], 9, FontStyle.Regular);
        }

        private void Monitoring_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void Btn_liberar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"O acesso ao usuário: {Lbl_dbUser.Text}, foi concedido!", "Sistema informa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Lbl_dbUser.Text = String.Empty;
            Lbl_dbRole.Text = String.Empty;
        }

        private void Btn_block_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"O acesso ao usuário: {Lbl_dbUser.Text}, foi negado!", "Sistema informa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Lbl_dbUser.Text = String.Empty;
            Lbl_dbRole.Text = String.Empty;
        }

        private void LoadDataCompany() {
            sqlStrCode = "SELECT nome, cargo, email, empresa FROM funcEmpresa ORDER BY empresa ASC";

            try {
                using (sqlConn = new NpgsqlConnection(sqlStrConn)) {
                    sqlConn.Open();
                    sqlAdapter = new NpgsqlDataAdapter(sqlStrCode, sqlConn);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    DataGrid_Funcionarios.DataSource = dt;
                }
            } catch (Exception ex) {
                MessageBox.Show("Um erro ocorreu: " + ex.Message);
            }
        }

        private void LoadDataSchool() {
            sqlStrCode = "SELECT nome, cargo, email, inst_educ FROM funcEscola ORDER BY inst_educ ASC";

            try {
                using (sqlConn = new NpgsqlConnection(sqlStrConn)) {
                    sqlConn.Open();
                    sqlAdapter = new NpgsqlDataAdapter(sqlStrCode, sqlConn);
                    DataTable dt = new DataTable();
                    sqlAdapter.Fill(dt);
                    DataGrid_Funcionarios.DataSource = dt;
                }
            } catch (Exception ex) {
                MessageBox.Show("Um erro ocorreu: " + ex.Message);
            }
        }

        private void DataGrid_Funcionarios_CellClick(object sender, DataGridViewCellEventArgs e) {
            int rowIndex = e.RowIndex;
            
            var dbUserColumn = "nome";
            var dbRoleColumn = "cargo";

            if (DataGrid_Funcionarios.Columns.Contains(dbUserColumn) && DataGrid_Funcionarios.Columns.Contains(dbRoleColumn)) {
                Lbl_dbUser.Text = Convert.ToString(DataGrid_Funcionarios.Rows[rowIndex].Cells[dbUserColumn].Value);
                Lbl_dbRole.Text = Convert.ToString(DataGrid_Funcionarios.Rows[rowIndex].Cells[dbRoleColumn].Value);
            } else {
                MessageBox.Show("Dados não encontrados", "Sistema informa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStrip_delogin_Click(object sender, EventArgs e) {
            this.Hide();
            new login().Show();
        }
        
        private void btnStrip_reset_Click(object sender, EventArgs e) {
            Lbl_dbRole.Text = String.Empty;
            Lbl_dbUser.Text = String.Empty;
        }

        private void btnStrip_controlEmpresa_Click(object sender, EventArgs e) {
            Lbl_dbUser.Text = String.Empty;
            Lbl_dbRole.Text = String.Empty;
            LoadDataCompany();
        }

        private void btnStrip_controlEscola_Click(object sender, EventArgs e) {
            Lbl_dbUser.Text = String.Empty;
            Lbl_dbRole.Text = String.Empty;
            LoadDataSchool();
        }
    }
}
