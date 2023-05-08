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
    public partial class FormStatus : Form
    {
        public FormStatus()
        {
            InitializeComponent();
        }
        MedwelfareEntities1 db = new MedwelfareEntities1();

        private void FormStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medwelfareEmpStatusDataSet.Evidence' table. You can move, or remove it, as needed.
            this.evidenceTableAdapter.Fill(this.medwelfareEmpStatusDataSet.Evidence);
            Emp_id.Text = (Program.ee);
             var cc = (from s in db.Evidence
             select new
             {
                 EV = s.Evi_no,
                 EI = s.Emp_id,
                 EN = s.Evi_date,
                 EP = s.Evi_approvalstatus,
             }).Where(w => w.EV.ToString() == Evi_no.Text.Trim());
            if (cc.Count() > 0)
            {
                Evi_no.Text = cc.FirstOrDefault().EV.ToString();
                Emp_id.Text = cc.FirstOrDefault().EI.ToString();
                Evi_date.Text = cc.FirstOrDefault().EN.ToString();
                Evi_approvalstatus.Text = cc.FirstOrDefault().EP.ToString();
            }
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Emp_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Evi_no.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Evi_date.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Evi_approvalstatus.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
