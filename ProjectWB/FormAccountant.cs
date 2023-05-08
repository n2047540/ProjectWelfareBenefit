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
    public partial class FormAccountant : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N854IPV;Initial Catalog=Medwelfare;User ID=sa;Password=Modtanoy");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public FormAccountant()
        {
            InitializeComponent();
        }
        MedwelfareEntities1 db = new MedwelfareEntities1();

        private void Formfinance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medwelfareMTSDataSet.MoneyTransferStatus' table. You can move, or remove it, as needed.
            this.moneyTransferStatusTableAdapter.Fill(this.medwelfareMTSDataSet.MoneyTransferStatus);
            // TODO: This line of code loads data into the 'medwelfareAccDataSet.Evidence' table. You can move, or remove it, as needed.
            this.evidenceTableAdapter1.Fill(this.medwelfareAccDataSet.Evidence);
            label1.Text = ("ยินดีต้อนรับคุณ " + Program.cc + " เข้าสู่ระบบแก้ไขสถานะการโอนเงิน");
            Acc_name.Text = (Program.cc);
            var cc = (from s in db.Evidence
                      select new
                      {
                          EO = s.Evi_no,
                          EM = s.Evi_ttmoney,
                          EX = s.MTS_no
                      }).Where(w => w.EO.ToString() == Evi_no.Text.Trim());
            if (cc.Count() > 0)
            {
                Evi_no.Text = cc.FirstOrDefault().EO.ToString();
                Evi_ttmoney.Text = cc.FirstOrDefault().EM.ToString();
                MTS_no.Text = cc.FirstOrDefault().EX.ToString();
            }
            var cs = (from s in db.MoneyTransferStatus
                      select new
                      {
                          EI = s.MTS_no,
                          EM = s.MTS_status,
                          ED = s.MTS_date,
                          ES = s.Acc_id
                      }).Where(w => w.EI.ToString() == MTS_no.Text.Trim());
            if (cs.Count() > 0)
            {
                MTS_no.Text = cs.FirstOrDefault().EI.ToString();
                MTS_status.Text = cs.FirstOrDefault().EM.ToString();
                dateTimePicker1.Text = cs.FirstOrDefault().ED.ToString();
                Acc_id.Text = cs.FirstOrDefault().ES.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e) //ยืนยัน
        {
            string Query = "insert into MoneyTransferStatus (MTS_no,MTS_status,MTS_date,Acc_id)" +
            "values('" + this.MTS_no.Text + "','" + this.MTS_status.Text + "','"+ this.dateTimePicker1.Text + "','" + this.Acc_id.Text + "')";
            cmd = new SqlCommand(Query, con);
            SqlDataReader reader;
            if (MTS_no.Text != "")
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    con.Close();
                    Program.ee = Acc_id.Text;
                    DisplayData2();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            else
            {
                MessageBox.Show("โปรดใส่ข้อมูลให้ครบ");
            }
            cmd = new SqlCommand("update Evidence set MTS_no=@M where Evi_no=@no", con);
            con.Open();
            cmd.Parameters.AddWithValue("@no", Evi_no.Text);
            cmd.Parameters.AddWithValue("@M", MTS_no.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("บันทึกสำเร็จ");
            con.Close();
            DisplayData();

        }

        private void DisplayData() //แสดงข้อมูล
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Evidence", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void DisplayData2() //แสดงข้อมูล
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from MoneyTransferStatus", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e) //โอนแล้ว
        {
            MTS_status.Text = "Success";
            Acc_name.Text = (Program.cc);
            var cs = (from s in db.Accountant
                      select new
                      {
                          EU = s.Acc_id,
                          EI = s.Acc_name,
                      }).Where(w => w.EI.ToString() == Acc_name.Text.Trim());
            if (cs.Count() > 0)
            {
                Acc_id.Text = cs.FirstOrDefault().EU.ToString();
                Acc_name.Text = cs.FirstOrDefault().EI.ToString();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Evi_no.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Evi_ttmoney.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
