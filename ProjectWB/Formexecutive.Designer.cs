
namespace ProjectWB
{
    partial class Formexecutive
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.evidenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medwelfareEmpStatusDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medwelfareEmpStatusDataSet = new ProjectWB.MedwelfareEmpStatusDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Evi_approvalstatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Evi_date = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Evi_right = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Evi_ttmoney = new System.Windows.Forms.TextBox();
            this.Emp_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Evi_hospital = new System.Windows.Forms.TextBox();
            this.Evi_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Evi_Affiliation = new System.Windows.Forms.TextBox();
            this.Evi_position = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.evidenceTableAdapter = new ProjectWB.MedwelfareEmpStatusDataSetTableAdapters.EvidenceTableAdapter();
            this.Evi_no = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Exe_name = new System.Windows.Forms.TextBox();
            this.Approve = new System.Windows.Forms.Button();
            this.Exe_id = new System.Windows.Forms.TextBox();
            this.evinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evinameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evipositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eviAffiliationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evirightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evihospitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evittmoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eviapprovalstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exe_idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medwelfareEmpStatusDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medwelfareEmpStatusDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evinoDataGridViewTextBoxColumn,
            this.empidDataGridViewTextBoxColumn,
            this.evinameDataGridViewTextBoxColumn,
            this.evipositionDataGridViewTextBoxColumn,
            this.eviAffiliationDataGridViewTextBoxColumn,
            this.evirightDataGridViewTextBoxColumn,
            this.evihospitalDataGridViewTextBoxColumn,
            this.evittmoneyDataGridViewTextBoxColumn,
            this.evidateDataGridViewTextBoxColumn,
            this.eviapprovalstatusDataGridViewTextBoxColumn,
            this.Exe_idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.evidenceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1470, 649);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // evidenceBindingSource
            // 
            this.evidenceBindingSource.DataMember = "Evidence";
            this.evidenceBindingSource.DataSource = this.medwelfareEmpStatusDataSetBindingSource;
            // 
            // medwelfareEmpStatusDataSetBindingSource
            // 
            this.medwelfareEmpStatusDataSetBindingSource.DataSource = this.medwelfareEmpStatusDataSet;
            this.medwelfareEmpStatusDataSetBindingSource.Position = 0;
            // 
            // medwelfareEmpStatusDataSet
            // 
            this.medwelfareEmpStatusDataSet.DataSetName = "MedwelfareEmpStatusDataSet";
            this.medwelfareEmpStatusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(561, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Approve);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Evi_no);
            this.groupBox1.Controls.Add(this.Evi_approvalstatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Evi_date);
            this.groupBox1.Controls.Add(this.Confirm);
            this.groupBox1.Controls.Add(this.Evi_right);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Evi_ttmoney);
            this.groupBox1.Controls.Add(this.Emp_id);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Evi_hospital);
            this.groupBox1.Controls.Add(this.Evi_name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Evi_Affiliation);
            this.groupBox1.Controls.Add(this.Evi_position);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(1593, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 484);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รายละเอียดข้อมูล";
            // 
            // Evi_approvalstatus
            // 
            this.Evi_approvalstatus.Location = new System.Drawing.Point(158, 366);
            this.Evi_approvalstatus.Name = "Evi_approvalstatus";
            this.Evi_approvalstatus.Size = new System.Drawing.Size(217, 30);
            this.Evi_approvalstatus.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(16, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "สถานะการเบิก";
            // 
            // Evi_date
            // 
            this.Evi_date.Location = new System.Drawing.Point(158, 330);
            this.Evi_date.Name = "Evi_date";
            this.Evi_date.Size = new System.Drawing.Size(217, 30);
            this.Evi_date.TabIndex = 38;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(221, 411);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(138, 46);
            this.Confirm.TabIndex = 35;
            this.Confirm.Text = "ยืนยัน";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // Evi_right
            // 
            this.Evi_right.Location = new System.Drawing.Point(158, 220);
            this.Evi_right.Name = "Evi_right";
            this.Evi_right.Size = new System.Drawing.Size(217, 30);
            this.Evi_right.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(16, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "วันที่ขอเบิก";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(16, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "ยอดเงินใบเสร็จ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "รหัสพนักงาน";
            // 
            // Evi_ttmoney
            // 
            this.Evi_ttmoney.Location = new System.Drawing.Point(158, 292);
            this.Evi_ttmoney.Name = "Evi_ttmoney";
            this.Evi_ttmoney.Size = new System.Drawing.Size(217, 30);
            this.Evi_ttmoney.TabIndex = 32;
            // 
            // Emp_id
            // 
            this.Emp_id.Location = new System.Drawing.Point(158, 76);
            this.Emp_id.Name = "Emp_id";
            this.Emp_id.Size = new System.Drawing.Size(217, 30);
            this.Emp_id.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(16, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "สถานพยาบาล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(18, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "ชื่อผู้เบิก";
            // 
            // Evi_hospital
            // 
            this.Evi_hospital.Location = new System.Drawing.Point(158, 256);
            this.Evi_hospital.Name = "Evi_hospital";
            this.Evi_hospital.Size = new System.Drawing.Size(217, 30);
            this.Evi_hospital.TabIndex = 30;
            // 
            // Evi_name
            // 
            this.Evi_name.Location = new System.Drawing.Point(158, 112);
            this.Evi_name.Name = "Evi_name";
            this.Evi_name.Size = new System.Drawing.Size(217, 30);
            this.Evi_name.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(16, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "สิทธิ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "ตำแหน่ง";
            // 
            // Evi_Affiliation
            // 
            this.Evi_Affiliation.Location = new System.Drawing.Point(158, 184);
            this.Evi_Affiliation.Name = "Evi_Affiliation";
            this.Evi_Affiliation.Size = new System.Drawing.Size(217, 30);
            this.Evi_Affiliation.TabIndex = 28;
            // 
            // Evi_position
            // 
            this.Evi_position.Location = new System.Drawing.Point(158, 148);
            this.Evi_position.Name = "Evi_position";
            this.Evi_position.Size = new System.Drawing.Size(217, 30);
            this.Evi_position.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(16, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "สังกัดแผนก";
            // 
            // evidenceTableAdapter
            // 
            this.evidenceTableAdapter.ClearBeforeFill = true;
            // 
            // Evi_no
            // 
            this.Evi_no.Location = new System.Drawing.Point(158, 40);
            this.Evi_no.Name = "Evi_no";
            this.Evi_no.Size = new System.Drawing.Size(217, 30);
            this.Evi_no.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(16, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "คำร้องที่";
            // 
            // Exe_name
            // 
            this.Exe_name.Location = new System.Drawing.Point(1102, 12);
            this.Exe_name.Name = "Exe_name";
            this.Exe_name.Size = new System.Drawing.Size(217, 22);
            this.Exe_name.TabIndex = 42;
            this.Exe_name.Visible = false;
            // 
            // Approve
            // 
            this.Approve.BackColor = System.Drawing.Color.LimeGreen;
            this.Approve.Location = new System.Drawing.Point(51, 411);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(138, 46);
            this.Approve.TabIndex = 42;
            this.Approve.Text = "อนุมัติ";
            this.Approve.UseVisualStyleBackColor = false;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // Exe_id
            // 
            this.Exe_id.Location = new System.Drawing.Point(1102, 42);
            this.Exe_id.Name = "Exe_id";
            this.Exe_id.Size = new System.Drawing.Size(217, 22);
            this.Exe_id.TabIndex = 43;
            this.Exe_id.Visible = false;
            // 
            // evinoDataGridViewTextBoxColumn
            // 
            this.evinoDataGridViewTextBoxColumn.DataPropertyName = "Evi_no";
            this.evinoDataGridViewTextBoxColumn.HeaderText = "คำร้องที่";
            this.evinoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evinoDataGridViewTextBoxColumn.Name = "evinoDataGridViewTextBoxColumn";
            this.evinoDataGridViewTextBoxColumn.ReadOnly = true;
            this.evinoDataGridViewTextBoxColumn.Width = 75;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "Emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "รหัสพนักงาน";
            this.empidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.Width = 85;
            // 
            // evinameDataGridViewTextBoxColumn
            // 
            this.evinameDataGridViewTextBoxColumn.DataPropertyName = "Evi_name";
            this.evinameDataGridViewTextBoxColumn.HeaderText = "ชื่อผู้เบิก";
            this.evinameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evinameDataGridViewTextBoxColumn.Name = "evinameDataGridViewTextBoxColumn";
            // 
            // evipositionDataGridViewTextBoxColumn
            // 
            this.evipositionDataGridViewTextBoxColumn.DataPropertyName = "Evi_position";
            this.evipositionDataGridViewTextBoxColumn.HeaderText = "ตำแหน่ง";
            this.evipositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evipositionDataGridViewTextBoxColumn.Name = "evipositionDataGridViewTextBoxColumn";
            // 
            // eviAffiliationDataGridViewTextBoxColumn
            // 
            this.eviAffiliationDataGridViewTextBoxColumn.DataPropertyName = "Evi_Affiliation";
            this.eviAffiliationDataGridViewTextBoxColumn.HeaderText = "แผนก";
            this.eviAffiliationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eviAffiliationDataGridViewTextBoxColumn.Name = "eviAffiliationDataGridViewTextBoxColumn";
            // 
            // evirightDataGridViewTextBoxColumn
            // 
            this.evirightDataGridViewTextBoxColumn.DataPropertyName = "Evi_right";
            this.evirightDataGridViewTextBoxColumn.HeaderText = "สิทธิ";
            this.evirightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evirightDataGridViewTextBoxColumn.Name = "evirightDataGridViewTextBoxColumn";
            this.evirightDataGridViewTextBoxColumn.Width = 75;
            // 
            // evihospitalDataGridViewTextBoxColumn
            // 
            this.evihospitalDataGridViewTextBoxColumn.DataPropertyName = "Evi_hospital";
            this.evihospitalDataGridViewTextBoxColumn.HeaderText = "สถานพยาบาล";
            this.evihospitalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evihospitalDataGridViewTextBoxColumn.Name = "evihospitalDataGridViewTextBoxColumn";
            // 
            // evittmoneyDataGridViewTextBoxColumn
            // 
            this.evittmoneyDataGridViewTextBoxColumn.DataPropertyName = "Evi_ttmoney";
            this.evittmoneyDataGridViewTextBoxColumn.HeaderText = "ยอดเงินใบเสร็จ";
            this.evittmoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evittmoneyDataGridViewTextBoxColumn.Name = "evittmoneyDataGridViewTextBoxColumn";
            // 
            // evidateDataGridViewTextBoxColumn
            // 
            this.evidateDataGridViewTextBoxColumn.DataPropertyName = "Evi_date";
            this.evidateDataGridViewTextBoxColumn.HeaderText = "วันที่ขอเบิก";
            this.evidateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evidateDataGridViewTextBoxColumn.Name = "evidateDataGridViewTextBoxColumn";
            // 
            // eviapprovalstatusDataGridViewTextBoxColumn
            // 
            this.eviapprovalstatusDataGridViewTextBoxColumn.DataPropertyName = "Evi_approvalstatus";
            this.eviapprovalstatusDataGridViewTextBoxColumn.HeaderText = "สถานะการเบิก";
            this.eviapprovalstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eviapprovalstatusDataGridViewTextBoxColumn.Name = "eviapprovalstatusDataGridViewTextBoxColumn";
            this.eviapprovalstatusDataGridViewTextBoxColumn.Width = 115;
            // 
            // Exe_idDataGridViewTextBoxColumn
            // 
            this.Exe_idDataGridViewTextBoxColumn.DataPropertyName = "Exe_id";
            this.Exe_idDataGridViewTextBoxColumn.HeaderText = "รหัสผู้บริหาร";
            this.Exe_idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.Exe_idDataGridViewTextBoxColumn.Name = "Exe_idDataGridViewTextBoxColumn";
            this.Exe_idDataGridViewTextBoxColumn.Width = 85;
            // 
            // Formexecutive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectWB.Properties.Resources.Screenshot_2022_11_07_091441;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1791, 774);
            this.Controls.Add(this.Exe_id);
            this.Controls.Add(this.Exe_name);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Formexecutive";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบผู้บริหาร";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Formexecutive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medwelfareEmpStatusDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medwelfareEmpStatusDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Evi_date;
        private System.Windows.Forms.TextBox Evi_right;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Evi_ttmoney;
        private System.Windows.Forms.TextBox Emp_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Evi_hospital;
        private System.Windows.Forms.TextBox Evi_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Evi_Affiliation;
        private System.Windows.Forms.TextBox Evi_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.BindingSource medwelfareEmpStatusDataSetBindingSource;
        private MedwelfareEmpStatusDataSet medwelfareEmpStatusDataSet;
        private System.Windows.Forms.TextBox Evi_approvalstatus;
        private System.Windows.Forms.BindingSource evidenceBindingSource;
        private MedwelfareEmpStatusDataSetTableAdapters.EvidenceTableAdapter evidenceTableAdapter;
        private System.Windows.Forms.TextBox Evi_no;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Exe_name;
        private System.Windows.Forms.Button Approve;
        private System.Windows.Forms.TextBox Exe_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn evinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evinameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evipositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eviAffiliationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evirightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evihospitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evittmoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evidateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eviapprovalstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exe_idDataGridViewTextBoxColumn;
    }
}