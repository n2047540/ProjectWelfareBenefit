using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectWB
{
    public partial class Formloginhr : Form
    {
        public Formloginhr()
        {
            InitializeComponent();
        }

        private void Formloginhr_Load(object sender, EventArgs e)
        {
            Username.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            Program.bb = Username.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-N854IPV;Initial Catalog=Medwelfare;User ID=sa;Password=Modtanoy");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM HR WHERE HR_username ='" + Username.Text + "' AND HR_password ='" + Password.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("ยินดีต้อนรับ!", "ผลการทำงาน", MessageBoxButtons.OK);
                this.Hide();
                Formhr fe = new Formhr();
                fe.Show();
            }
            else
            {
                MessageBox.Show("กรุณาตรวจสอบชื่อและรหัสอีกครั้ง", "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (Username.Text.Trim() == "")
            {
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Password.Focus();
                }
            }
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
