
namespace ProjectWB
{
    partial class FormStatus
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
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eviapprovalstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTSnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medwelfareEmpStatusDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medwelfareEmpStatusDataSet = new ProjectWB.MedwelfareEmpStatusDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.Emp_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Evi_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Evi_date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Evi_approvalstatus = new System.Windows.Forms.TextBox();
            this.evidenceTableAdapter = new ProjectWB.MedwelfareEmpStatusDataSetTableAdapters.EvidenceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medwelfareEmpStatusDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medwelfareEmpStatusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn,
            this.evinoDataGridViewTextBoxColumn,
            this.evidateDataGridViewTextBoxColumn,
            this.eviapprovalstatusDataGridViewTextBoxColumn,
            this.mTSnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.evidenceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(917, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "Emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "รหัสพนักงาน";
            this.empidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.Width = 125;
            // 
            // evinoDataGridViewTextBoxColumn
            // 
            this.evinoDataGridViewTextBoxColumn.DataPropertyName = "Evi_no";
            this.evinoDataGridViewTextBoxColumn.HeaderText = "เลขที่ใบคำร้อง";
            this.evinoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evinoDataGridViewTextBoxColumn.Name = "evinoDataGridViewTextBoxColumn";
            this.evinoDataGridViewTextBoxColumn.ReadOnly = true;
            this.evinoDataGridViewTextBoxColumn.Width = 125;
            // 
            // evidateDataGridViewTextBoxColumn
            // 
            this.evidateDataGridViewTextBoxColumn.DataPropertyName = "Evi_date";
            this.evidateDataGridViewTextBoxColumn.HeaderText = "วันที่เบิก";
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
            // mTSnoDataGridViewTextBoxColumn
            // 
            this.mTSnoDataGridViewTextBoxColumn.DataPropertyName = "MTS_no";
            this.mTSnoDataGridViewTextBoxColumn.HeaderText = "MTS_no";
            this.mTSnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mTSnoDataGridViewTextBoxColumn.Name = "mTSnoDataGridViewTextBoxColumn";
            this.mTSnoDataGridViewTextBoxColumn.Visible = false;
            this.mTSnoDataGridViewTextBoxColumn.Width = 125;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "รหัสพนักงาน";
            // 
            // Emp_id
            // 
            this.Emp_id.Location = new System.Drawing.Point(152, 27);
            this.Emp_id.Name = "Emp_id";
            this.Emp_id.Size = new System.Drawing.Size(217, 22);
            this.Emp_id.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "เลขที่ใบคำร้อง";
            // 
            // Evi_no
            // 
            this.Evi_no.Location = new System.Drawing.Point(152, 66);
            this.Evi_no.Name = "Evi_no";
            this.Evi_no.Size = new System.Drawing.Size(217, 22);
            this.Evi_no.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "วันที่เบิก";
            // 
            // Evi_date
            // 
            this.Evi_date.Location = new System.Drawing.Point(152, 105);
            this.Evi_date.Name = "Evi_date";
            this.Evi_date.Size = new System.Drawing.Size(217, 22);
            this.Evi_date.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(21, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "สถานะการเบิก";
            // 
            // Evi_approvalstatus
            // 
            this.Evi_approvalstatus.Location = new System.Drawing.Point(152, 142);
            this.Evi_approvalstatus.Name = "Evi_approvalstatus";
            this.Evi_approvalstatus.Size = new System.Drawing.Size(217, 22);
            this.Evi_approvalstatus.TabIndex = 14;
            // 
            // evidenceTableAdapter
            // 
            this.evidenceTableAdapter.ClearBeforeFill = true;
            // 
            // FormStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectWB.Properties.Resources.Screenshot_2022_11_07_091441;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 588);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Evi_approvalstatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Evi_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Evi_no);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Emp_id);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "FormStatus";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "สถานะการเบิก";
            this.Load += new System.EventHandler(this.FormStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medwelfareEmpStatusDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medwelfareEmpStatusDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Emp_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Evi_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Evi_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Evi_approvalstatus;
        private System.Windows.Forms.BindingSource medwelfareEmpStatusDataSetBindingSource;
        private MedwelfareEmpStatusDataSet medwelfareEmpStatusDataSet;
        private System.Windows.Forms.BindingSource evidenceBindingSource;
        private MedwelfareEmpStatusDataSetTableAdapters.EvidenceTableAdapter evidenceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evidateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eviapprovalstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mTSnoDataGridViewTextBoxColumn;
    }
}