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
    public partial class Formexecutive : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N854IPV;Initial Catalog=Medwelfare;User ID=sa;Password=Modtanoy");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Formexecutive()
        {
            InitializeComponent();
        }
        MedwelfareEntities1 db = new MedwelfareEntities1();
        private void Formexecutive_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medwelfareEmpStatusDataSet.Evidence' table. You can move, or remove it, as needed.
            this.evidenceTableAdapter.Fill(this.medwelfareEmpStatusDataSet.Evidence);
            // TODO: This line of code loads data into the 'welfareDataSet1.Employee' table. You can move, or remove it, as needed.
            label1.Text = ("ยินดีต้อนรับคุณ " + Program.dd + " เข้าสู่ระบบจัดการสวัสดิการรักษาพยาบาลพนักงาน");
            Exe_name.Text = (Program.dd);
            var cc = (from s in db.Evidence
                      select new
                      {
                          EI = s.Emp_id,
                          EO = s.Evi_no,
                          EN = s.Evi_name,
                          EP = s.Evi_position,
                          EA = s.Evi_Affiliation,
                          ER = s.Evi_right,
                          EH = s.Evi_hospital,
                          EM = s.Evi_ttmoney,
                          ED = s.Evi_date,
                          EW = s.Evi_approvalstatus,
                          EX = s.Exe_id
                      }).Where(w => w.EO.ToString() == Evi_no.Text.Trim());
            if (cc.Count() > 0)
            {
                Evi_no.Text = cc.FirstOrDefault().EO.ToString();
                Emp_id.Text = cc.FirstOrDefault().EI.ToString();
                Evi_name.Text = cc.FirstOrDefault().EN.ToString();
                Evi_position.Text = cc.FirstOrDefault().EP.ToString();
                Evi_Affiliation.Text = cc.FirstOrDefault().EA.ToString();
                Evi_right.Text = cc.FirstOrDefault().ER.ToString();
                Evi_hospital.Text = cc.FirstOrDefault().EH.ToString();
                Evi_ttmoney.Text = cc.FirstOrDefault().EM.ToString();
                Evi_date.Text = cc.FirstOrDefault().ED.ToString();
                Evi_approvalstatus.Text = cc.FirstOrDefault().EW.ToString();
                Exe_id.Text = cc.FirstOrDefault().EX.ToString();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Evi_no.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Emp_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Evi_name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Evi_position.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Evi_Affiliation.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Evi_right.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Evi_hospital.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Evi_ttmoney.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            Evi_date.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            Evi_approvalstatus.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            Exe_name.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Evi_no.Text != "")
            {
                cmd = new SqlCommand("update Evidence set Evi_approvalstatus=@appr,Exe_id=@Exid where Evi_no=@no", con);
                con.Open();
                cmd.Parameters.AddWithValue("@no", Evi_no.Text);
                cmd.Parameters.AddWithValue("@appr", Evi_approvalstatus.Text);
                cmd.Parameters.AddWithValue("@Exid", Exe_id.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("อนุมัติคำร้องเรียบร้อย");
                con.Close();
                DisplayData();
            }
            else
            {
                MessageBox.Show("โปรดเลือกคำร้องขอเบิก!");
            }
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

        private void Approve_Click(object sender, EventArgs e)
        {
            Evi_approvalstatus.Text = "Approve";
            Exe_name.Text = (Program.dd);
            var cs = (from s in db.Executive
                      select new
                      {
                          EU = s.Exe_id,
                          EI = s.Exe_name,
                      }).Where(w => w.EI.ToString() == Exe_name.Text.Trim());
            if (cs.Count() > 0)
            {
                Exe_id.Text = cs.FirstOrDefault().EU.ToString();
                Exe_name.Text = cs.FirstOrDefault().EI.ToString();
            }
        }
    }
}
