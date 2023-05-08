using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWB
{
    public partial class FormEmp : Form
    {
        public FormEmp(string text)
        {
            InitializeComponent();
        }
        MedwelfareEntities1 db = new MedwelfareEntities1();

        private void RequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRequest fr = new FormRequest();
            fr.Show();
        }

        private void FormEmp_Load(object sender, EventArgs e)
        {
            hello.Text = ("             ยินดีต้อนรับ! คุณ " + Program.aa + "\r\n" + "เข้าสู่ระบบสวัสดิการรักษาพยาบาลพนักงาน");
            Disdata();
        }

        private void StatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Disdata();
            FormStatus fs = new FormStatus();
            fs.Show();
        }

        private void RemainToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRemainwf fr = new FormRemainwf();
            fr.Show();
        }

        private void Disdata()
        {
            Evi_name.Text = (Program.aa);
            Program.ee = Emp_id.Text;
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
                          }).Where(w => w.EU.ToString() == Evi_name.Text.Trim());
                if (cs.Count() > 0)
                {
                    Evi_name.Text = cs.FirstOrDefault().EU.ToString();
                    Emp_id.Text = cs.FirstOrDefault().EI.ToString();
                }
            }
        }
    }
}
