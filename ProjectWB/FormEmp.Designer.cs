
namespace ProjectWB
{
    partial class FormEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ดสถานะการเบกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemainToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hello = new System.Windows.Forms.Label();
            this.Emp_id = new System.Windows.Forms.TextBox();
            this.Evi_name = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RequestToolStripMenuItem,
            this.ดสถานะการเบกToolStripMenuItem,
            this.RemainToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1343, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RequestToolStripMenuItem
            // 
            this.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem";
            this.RequestToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.RequestToolStripMenuItem.Text = "ส่งคำร้อง";
            this.RequestToolStripMenuItem.Click += new System.EventHandler(this.RequestToolStripMenuItem_Click);
            // 
            // ดสถานะการเบกToolStripMenuItem
            // 
            this.ดสถานะการเบกToolStripMenuItem.Name = "ดสถานะการเบกToolStripMenuItem";
            this.ดสถานะการเบกToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.ดสถานะการเบกToolStripMenuItem.Text = "ดูสถานะการเบิก";
            this.ดสถานะการเบกToolStripMenuItem.Click += new System.EventHandler(this.StatusToolStripMenuItem_Click);
            // 
            // RemainToolStripMenuItem1
            // 
            this.RemainToolStripMenuItem1.Name = "RemainToolStripMenuItem1";
            this.RemainToolStripMenuItem1.Size = new System.Drawing.Size(201, 24);
            this.RemainToolStripMenuItem1.Text = "ตรวจสอบสิทธิสวัสดิการคงเหลือ";
            this.RemainToolStripMenuItem1.Click += new System.EventHandler(this.RemainToolStripMenuItem1_Click);
            // 
            // hello
            // 
            this.hello.AutoSize = true;
            this.hello.BackColor = System.Drawing.Color.Transparent;
            this.hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.hello.Location = new System.Drawing.Point(315, 281);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(0, 46);
            this.hello.TabIndex = 1;
            // 
            // Emp_id
            // 
            this.Emp_id.Location = new System.Drawing.Point(1114, 45);
            this.Emp_id.Name = "Emp_id";
            this.Emp_id.Size = new System.Drawing.Size(217, 22);
            this.Emp_id.TabIndex = 9;
            this.Emp_id.Visible = false;
            // 
            // Evi_name
            // 
            this.Evi_name.Location = new System.Drawing.Point(1114, 73);
            this.Evi_name.Name = "Evi_name";
            this.Evi_name.Size = new System.Drawing.Size(217, 22);
            this.Evi_name.TabIndex = 10;
            this.Evi_name.Visible = false;
            // 
            // FormEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectWB.Properties.Resources.Screenshot_2022_11_07_091441;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1343, 711);
            this.Controls.Add(this.Evi_name);
            this.Controls.Add(this.Emp_id);
            this.Controls.Add(this.hello);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEmp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบพนักงาน";
            this.Load += new System.EventHandler(this.FormEmp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ดสถานะการเบกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemainToolStripMenuItem1;
        private System.Windows.Forms.Label hello;
        private System.Windows.Forms.TextBox Emp_id;
        private System.Windows.Forms.TextBox Evi_name;
    }
}