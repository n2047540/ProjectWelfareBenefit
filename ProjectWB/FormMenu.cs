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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formlogin fme = new Formlogin();
            fme.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formloginhr fh = new Formloginhr();
            fh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formloginm fm = new Formloginm();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formloginexe fe = new Formloginexe();
            fe.Show();
        }
    }
}
