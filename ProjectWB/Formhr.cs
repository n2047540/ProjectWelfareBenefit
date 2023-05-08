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
    public partial class Formhr : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N854IPV;Initial Catalog=Medwelfare;User ID=sa;Password=Modtanoy");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Formhr()
        {
            InitializeComponent();
        }

        MedwelfareEntities1 db = new MedwelfareEntities1();
        private void Formhr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medwelfareRightEmpDataSet.RightEmp' table. You can move, or remove it, as needed.
            this.rightEmpTableAdapter.Fill(this.medwelfareRightEmpDataSet.RightEmp);
            label1.Text = ("ยินดีต้อนรับคุณ " + Program.bb + " เข้าสู่ระบบแก้ไขสวัสดิการรักษาพยาบาลพนักงาน");
            //+"\r\n"
            var cc = (from s in db.RightEmp
                      select new
                      {
                          EV = s.rig_no,
                          EI = s.rig_name,
                          EN = s.rig_balance,
                          EP = s.rig_Uname,
                          ED = s.rig_date
                      }).Where(w => w.EV.ToString() == rig_no.Text.Trim());
            if (cc.Count() > 0)
            {
                rig_no.Text = cc.FirstOrDefault().EV.ToString();
                rig_name.Text = cc.FirstOrDefault().EI.ToString();
                rig_balance.Text = cc.FirstOrDefault().EN.ToString();
                rig_Uname.Text = cc.FirstOrDefault().EP.ToString();
                dateTimePicker1.Text = cc.FirstOrDefault().ED.ToString();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rig_no.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rig_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            rig_balance.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            rig_Uname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rig_no.Text != "" && rig_name.Text != "" && rig_balance.Text != "" && rig_Uname.Text != "")
            {
                cmd = new SqlCommand("update RightEmp set rig_name=@name,rig_balance=@balance,rig_Uname=@Uname,rig_date=@in where rig_no=@no", con);
                con.Open();
                cmd.Parameters.AddWithValue("@no", rig_no.Text);
                cmd.Parameters.AddWithValue("@name", rig_name.Text);
                cmd.Parameters.AddWithValue("@balance", rig_balance.Text);
                cmd.Parameters.AddWithValue("@Uname", rig_Uname.Text);
                cmd.Parameters.AddWithValue("@in", dateTimePicker1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                con.Close();
                DisplayData();
            }
            else
            {
                MessageBox.Show("โปรดกรอกข้อมูลเพื่อทำการแก้ไข!");
            }
        }

        private void DisplayData() //แสดงข้อมูล
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from RightEmp", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
