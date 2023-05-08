
namespace ProjectWB
{
    partial class FormAccountant
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MTS_status = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MTS_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Evi_ttmoney = new System.Windows.Forms.TextBox();
            this.Evi_no = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.evinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTSnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evittmoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eviapprovalstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidenceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medwelfareAccDataSet = new ProjectWB.MedwelfareAccDataSet();
            this.evidenceTableAdapter1 = new ProjectWB.MedwelfareAccDataSetTableAdapters.EvidenceTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mTSnoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTSstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTSdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyTransferStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medwelfareMTSDataSet = new ProjectWB.MedwelfareMTSDataSet();
            this.moneyTransferStatusTableAdapter = new ProjectWB.MedwelfareMTSDataSetTableAdapters.MoneyTransferStatusTableAdapter();
            this.Acc_id = new System.Windows.Forms.TextBox();
            this.Acc_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medwelfareAccDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTransferStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medwelfareMTSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(178, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.MTS_status);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MTS_no);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Evi_ttmoney);
            this.groupBox1.Controls.Add(this.Evi_no);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(1132, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 298);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รายละเอียดข้อมูล";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 27);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(42, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 49);
            this.button2.TabIndex = 38;
            this.button2.Text = "โอนเงินแล้ว";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(227, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 49);
            this.button1.TabIndex = 36;
            this.button1.Text = "ยืนยัน";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MTS_status
            // 
            this.MTS_status.Location = new System.Drawing.Point(157, 140);
            this.MTS_status.Name = "MTS_status";
            this.MTS_status.Size = new System.Drawing.Size(217, 30);
            this.MTS_status.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(10, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "วันที่โอน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "ลำดับการโอน";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(10, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "ยอดเงินใบเสร็จ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(10, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "สถานะการโอน";
            // 
            // MTS_no
            // 
            this.MTS_no.Location = new System.Drawing.Point(157, 103);
            this.MTS_no.Name = "MTS_no";
            this.MTS_no.Size = new System.Drawing.Size(217, 30);
            this.MTS_no.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "คำร้องที่";
            // 
            // Evi_ttmoney
            // 
            this.Evi_ttmoney.Location = new System.Drawing.Point(157, 67);
            this.Evi_ttmoney.Name = "Evi_ttmoney";
            this.Evi_ttmoney.Size = new System.Drawing.Size(217, 30);
            this.Evi_ttmoney.TabIndex = 32;
            // 
            // Evi_no
            // 
            this.Evi_no.Location = new System.Drawing.Point(157, 31);
            this.Evi_no.Name = "Evi_no";
            this.Evi_no.Size = new System.Drawing.Size(217, 30);
            this.Evi_no.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evinoDataGridViewTextBoxColumn,
            this.mTSnoDataGridViewTextBoxColumn,
            this.evittmoneyDataGridViewTextBoxColumn,
            this.evidateDataGridViewTextBoxColumn,
            this.eviapprovalstatusDataGridViewTextBoxColumn,
            this.empidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.evidenceBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 384);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // evinoDataGridViewTextBoxColumn
            // 
            this.evinoDataGridViewTextBoxColumn.DataPropertyName = "Evi_no";
            this.evinoDataGridViewTextBoxColumn.HeaderText = "คำร้องที่";
            this.evinoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evinoDataGridViewTextBoxColumn.Name = "evinoDataGridViewTextBoxColumn";
            this.evinoDataGridViewTextBoxColumn.ReadOnly = true;
            this.evinoDataGridViewTextBoxColumn.Width = 125;
            // 
            // mTSnoDataGridViewTextBoxColumn
            // 
            this.mTSnoDataGridViewTextBoxColumn.DataPropertyName = "MTS_no";
            this.mTSnoDataGridViewTextBoxColumn.HeaderText = "ลำดับการโอน";
            this.mTSnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mTSnoDataGridViewTextBoxColumn.Name = "mTSnoDataGridViewTextBoxColumn";
            this.mTSnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // evittmoneyDataGridViewTextBoxColumn
            // 
            this.evittmoneyDataGridViewTextBoxColumn.DataPropertyName = "Evi_ttmoney";
            this.evittmoneyDataGridViewTextBoxColumn.HeaderText = "ยอดเงินใบเสร็จ";
            this.evittmoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evittmoneyDataGridViewTextBoxColumn.Name = "evittmoneyDataGridViewTextBoxColumn";
            this.evittmoneyDataGridViewTextBoxColumn.Width = 125;
            // 
            // evidateDataGridViewTextBoxColumn
            // 
            this.evidateDataGridViewTextBoxColumn.DataPropertyName = "Evi_date";
            this.evidateDataGridViewTextBoxColumn.HeaderText = "วันที่ขอเบิก";
            this.evidateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evidateDataGridViewTextBoxColumn.Name = "evidateDataGridViewTextBoxColumn";
            this.evidateDataGridViewTextBoxColumn.Width = 125;
            // 
            // eviapprovalstatusDataGridViewTextBoxColumn
            // 
            this.eviapprovalstatusDataGridViewTextBoxColumn.DataPropertyName = "Evi_approvalstatus";
            this.eviapprovalstatusDataGridViewTextBoxColumn.HeaderText = "สถานะการเบิก";
            this.eviapprovalstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eviapprovalstatusDataGridViewTextBoxColumn.Name = "eviapprovalstatusDataGridViewTextBoxColumn";
            this.eviapprovalstatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "Emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "รหัสพนักงาน";
            this.empidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.Width = 125;
            // 
            // evidenceBindingSource1
            // 
            this.evidenceBindingSource1.DataMember = "Evidence";
            this.evidenceBindingSource1.DataSource = this.medwelfareAccDataSet;
            // 
            // medwelfareAccDataSet
            // 
            this.medwelfareAccDataSet.DataSetName = "MedwelfareAccDataSet";
            this.medwelfareAccDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evidenceTableAdapter1
            // 
            this.evidenceTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mTSnoDataGridViewTextBoxColumn1,
            this.mTSstatusDataGridViewTextBoxColumn,
            this.mTSdateDataGridViewTextBoxColumn,
            this.accidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.moneyTransferStatusBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(566, 141);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(543, 384);
            this.dataGridView2.TabIndex = 37;
            // 
            // mTSnoDataGridViewTextBoxColumn1
            // 
            this.mTSnoDataGridViewTextBoxColumn1.DataPropertyName = "MTS_no";
            this.mTSnoDataGridViewTextBoxColumn1.HeaderText = "ลำดับการโอน";
            this.mTSnoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.mTSnoDataGridViewTextBoxColumn1.Name = "mTSnoDataGridViewTextBoxColumn1";
            this.mTSnoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // mTSstatusDataGridViewTextBoxColumn
            // 
            this.mTSstatusDataGridViewTextBoxColumn.DataPropertyName = "MTS_status";
            this.mTSstatusDataGridViewTextBoxColumn.HeaderText = "สถานะการโอน";
            this.mTSstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mTSstatusDataGridViewTextBoxColumn.Name = "mTSstatusDataGridViewTextBoxColumn";
            this.mTSstatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // mTSdateDataGridViewTextBoxColumn
            // 
            this.mTSdateDataGridViewTextBoxColumn.DataPropertyName = "MTS_date";
            this.mTSdateDataGridViewTextBoxColumn.HeaderText = "วันที่โอน";
            this.mTSdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mTSdateDataGridViewTextBoxColumn.Name = "mTSdateDataGridViewTextBoxColumn";
            this.mTSdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // accidDataGridViewTextBoxColumn
            // 
            this.accidDataGridViewTextBoxColumn.DataPropertyName = "Acc_id";
            this.accidDataGridViewTextBoxColumn.HeaderText = "รหัสพนักงานการเงิน";
            this.accidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accidDataGridViewTextBoxColumn.Name = "accidDataGridViewTextBoxColumn";
            this.accidDataGridViewTextBoxColumn.Width = 125;
            // 
            // moneyTransferStatusBindingSource
            // 
            this.moneyTransferStatusBindingSource.DataMember = "MoneyTransferStatus";
            this.moneyTransferStatusBindingSource.DataSource = this.medwelfareMTSDataSet;
            // 
            // medwelfareMTSDataSet
            // 
            this.medwelfareMTSDataSet.DataSetName = "MedwelfareMTSDataSet";
            this.medwelfareMTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moneyTransferStatusTableAdapter
            // 
            this.moneyTransferStatusTableAdapter.ClearBeforeFill = true;
            // 
            // Acc_id
            // 
            this.Acc_id.Location = new System.Drawing.Point(1271, 41);
            this.Acc_id.Name = "Acc_id";
            this.Acc_id.Size = new System.Drawing.Size(217, 22);
            this.Acc_id.TabIndex = 38;
            this.Acc_id.Visible = false;
            // 
            // Acc_name
            // 
            this.Acc_name.Location = new System.Drawing.Point(1271, 12);
            this.Acc_name.Name = "Acc_name";
            this.Acc_name.Size = new System.Drawing.Size(217, 22);
            this.Acc_name.TabIndex = 39;
            this.Acc_name.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(180, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 40;
            this.label5.Text = "คำร้องขอเบิก";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(773, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 41;
            this.label6.Text = "การโอนเงิน";
            // 
            // FormAccountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectWB.Properties.Resources.Screenshot_2022_11_07_091441;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1590, 634);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Acc_name);
            this.Controls.Add(this.Acc_id);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "FormAccountant";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบแผนกการเงิน";
            this.Load += new System.EventHandler(this.Formfinance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medwelfareAccDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTransferStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medwelfareMTSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Evi_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MTS_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MTS_status;
        private System.Windows.Forms.TextBox Evi_ttmoney;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private MedwelfareAccDataSet medwelfareAccDataSet;
        private System.Windows.Forms.BindingSource evidenceBindingSource1;
        private MedwelfareAccDataSetTableAdapters.EvidenceTableAdapter evidenceTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MedwelfareMTSDataSet medwelfareMTSDataSet;
        private System.Windows.Forms.BindingSource moneyTransferStatusBindingSource;
        private MedwelfareMTSDataSetTableAdapters.MoneyTransferStatusTableAdapter moneyTransferStatusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mTSnoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mTSstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mTSdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Acc_id;
        private System.Windows.Forms.TextBox Acc_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn evinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mTSnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evittmoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evidateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eviapprovalstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}