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
    public partial class FormRemainwf : Form
    {
        public FormRemainwf()
        {
            InitializeComponent();
        }
        MedwelfareEntities1 db = new MedwelfareEntities1();

        private void FormRemainwf_Load(object sender, EventArgs e)
        {
             Evi_name.Text = (Program.aa);
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
                              EA = s.Emp_balance,
                              EI = s.rig_no,
                          }).Where(w => w.EU.ToString() == Evi_name.Text.Trim());
                var sc = (from r in db.RightEmp
                          select new
                          {
                              EI = r.rig_no,
                              EN = r.rig_name,
                              EP = r.rig_balance,
                          }).Where(w => w.EI.ToString() == rig_no.Text.Trim());
                if (cs.Count() > 0)
                {
                    Evi_name.Text = cs.FirstOrDefault().EU.ToString();
                    rig_no.Text = cs.FirstOrDefault().EI.ToString();
                    rig_name.Text = sc.FirstOrDefault().EN.ToString();
                    rig_balance.Text = sc.FirstOrDefault().EP.ToString();
                    Emp_balance.Text = cs.FirstOrDefault().EA.ToString();
                }
            }
            Emp_balance.Focus();
        }
    }
}
