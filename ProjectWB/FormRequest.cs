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
using System.IO;


namespace ProjectWB
{
    public partial class FormRequest : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N854IPV;Initial Catalog=Medwelfare;User ID=sa;Password=Modtanoy");
        SqlCommand cmd;
        public FormRequest()
        {
            InitializeComponent();
        }
        MedwelfareEntities1 db = new MedwelfareEntities1();

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please insert Image";
            ofd.Filter = "JPG|*.jpg";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Upimage.Text = ofd.FileName;
                pB1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ยืนยันการส่งคำร้องขอเบิกใช่หรือไม่", "ผลการทำงาน", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Insert();
            }
            
            /*if (Upimage.Text != "")
            {

                Request cs = new Request();
                FileStream fs = new FileStream(pB1.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                cs.Emp_id = int.Parse(Emp_id.Text.Trim());
                cs.R_receipt = ImageData;
                cs.R_doc = ImageDatas;
                db.Request.Add(cs);
                db.SaveChanges();
                MessageBox.Show("Save");
            }*/

        }

        private void FormRequest_Load(object sender, EventArgs e)
        {
            Evi_name.Text = (Program.aa);
        }

        private void Insert()
        {
            string Query = "insert into Evidence (Emp_id,Evi_name,Evi_position,Evi_Affiliation,Evi_right,Evi_hospital,Evi_ttmoney,Evi_date,Evi_approvalstatus)" +
            "values('" + this.Emp_id.Text + "','" + this.Emp_name.Text + "','" + this.Evi_position.Text + "','" + this.Evi_Affiliation.Text + "','" + this.rig_no.Text + "'," +
            "'" + this.Evi_hospital.Text + "','" + this.Evi_ttmoney.Text + "', '" + this.dateTimePicker1.Text + "', '" + this.Evi_approvalstatus.Text + "')";
            cmd = new SqlCommand(Query, con);
            SqlDataReader reader;
            if (Emp_id.Text != "" && Emp_name.Text != "" && Evi_position.Text != "" && Evi_Affiliation.Text != "" && rig_no.Text != "" && Evi_hospital.Text != "" && Evi_ttmoney.Text != "" && dateTimePicker1.Text != "" && Evi_approvalstatus.Text != "")
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("ส่งคำร้องขอเบิกสำเร็จ");
                    Program.ee = Emp_id.Text;
                    FormStatus fs = new FormStatus();
                    this.Hide();
                    fs.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            else
            {
                MessageBox.Show("โปรดใส่ข้อมูลให้ครบ");
            }
        }

        private void button2_Click(object sender, EventArgs e) //เรียกข้อมูล
        {
            if (Evi_name.Text.Trim() == "")
            {
                return;
            }
            else
            {
                var cs = (from s in db.Employee
                          select new
                          {
                              EU = s.Emp_username,
                              EI = s.Emp_id,
                              EN = s.Emp_name,
                              EP = s.Emp_position,
                              EA = s.Emp_Affiliation,
                              ER = s.rig_no
                          }).Where(w => w.EU.ToString() == Evi_name.Text.Trim());
                if (cs.Count() > 0)
                {
                    Evi_name.Text = cs.FirstOrDefault().EU.ToString();
                    Emp_id.Text = cs.FirstOrDefault().EI.ToString();
                    Emp_name.Text = cs.FirstOrDefault().EN.ToString();
                    Evi_position.Text = cs.FirstOrDefault().EP.ToString();
                    Evi_Affiliation.Text = cs.FirstOrDefault().EA.ToString();
                    rig_no.Text = cs.FirstOrDefault().ER.ToString();
                }
                Evi_approvalstatus.Text = "Waiting for inspection";
            }
        }

        private void button3_Click(object sender, EventArgs e) //ลบ
        {
            Emp_id.Text = "";
            Emp_name.Text = "";
            Evi_position.Text = "";
            Evi_Affiliation.Text = "";
            rig_no.Text = "";
            Evi_hospital.Text = "";
            Evi_ttmoney.Text = "";
            Evi_approvalstatus.Text = "";
        }
    }
}

