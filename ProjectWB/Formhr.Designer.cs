
namespace ProjectWB
{
    partial class Formhr
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rig_Uname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rig_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rig_name = new System.Windows.Forms.TextBox();
            this.rig_balance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.medwelfareRightEmpDataSet = new ProjectWB.MedwelfareRightEmpDataSet();
            this.rightEmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rightEmpTableAdapter = new ProjectWB.MedwelfareRightEmpDataSetTableAdapters.RightEmpTableAdapter();
            this.rignoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rignameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rigbalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rigUnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rigdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medwelfareRightEmpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightEmpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rignoDataGridViewTextBoxColumn,
            this.rignameDataGridViewTextBoxColumn,
            this.rigbalanceDataGridViewTextBoxColumn,
            this.rigUnameDataGridViewTextBoxColumn,
            this.rigdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rightEmpBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(364, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rig_Uname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rig_no);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rig_name);
            this.groupBox1.Controls.Add(this.rig_balance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(823, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 300);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลสิทธิสวัสดิการ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 42);
            this.button1.TabIndex = 35;
            this.button1.Text = "ยืนยันการแก้ไข";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rig_Uname
            // 
            this.rig_Uname.Location = new System.Drawing.Point(157, 139);
            this.rig_Uname.Name = "rig_Uname";
            this.rig_Uname.Size = new System.Drawing.Size(372, 30);
            this.rig_Uname.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "ผู้มีสิทธิ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 27);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(6, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "วันที่แก้ไข";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "สิทธิลำดับที่";
            // 
            // rig_no
            // 
            this.rig_no.Location = new System.Drawing.Point(157, 31);
            this.rig_no.Name = "rig_no";
            this.rig_no.Size = new System.Drawing.Size(372, 30);
            this.rig_no.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "ชื่อสิทธิ";
            // 
            // rig_name
            // 
            this.rig_name.Location = new System.Drawing.Point(157, 67);
            this.rig_name.Name = "rig_name";
            this.rig_name.Size = new System.Drawing.Size(372, 30);
            this.rig_name.TabIndex = 24;
            // 
            // rig_balance
            // 
            this.rig_balance.Location = new System.Drawing.Point(157, 103);
            this.rig_balance.Name = "rig_balance";
            this.rig_balance.Size = new System.Drawing.Size(372, 30);
            this.rig_balance.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "วงเงิน";
            // 
            // medwelfareRightEmpDataSet
            // 
            this.medwelfareRightEmpDataSet.DataSetName = "MedwelfareRightEmpDataSet";
            this.medwelfareRightEmpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rightEmpBindingSource
            // 
            this.rightEmpBindingSource.DataMember = "RightEmp";
            this.rightEmpBindingSource.DataSource = this.medwelfareRightEmpDataSet;
            // 
            // rightEmpTableAdapter
            // 
            this.rightEmpTableAdapter.ClearBeforeFill = true;
            // 
            // rignoDataGridViewTextBoxColumn
            // 
            this.rignoDataGridViewTextBoxColumn.DataPropertyName = "rig_no";
            this.rignoDataGridViewTextBoxColumn.HeaderText = "สิทธิลำดับที่";
            this.rignoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rignoDataGridViewTextBoxColumn.Name = "rignoDataGridViewTextBoxColumn";
            this.rignoDataGridViewTextBoxColumn.Width = 80;
            // 
            // rignameDataGridViewTextBoxColumn
            // 
            this.rignameDataGridViewTextBoxColumn.DataPropertyName = "rig_name";
            this.rignameDataGridViewTextBoxColumn.HeaderText = "ชื่อสิทธิ";
            this.rignameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rignameDataGridViewTextBoxColumn.Name = "rignameDataGridViewTextBoxColumn";
            this.rignameDataGridViewTextBoxColumn.Width = 120;
            // 
            // rigbalanceDataGridViewTextBoxColumn
            // 
            this.rigbalanceDataGridViewTextBoxColumn.DataPropertyName = "rig_balance";
            this.rigbalanceDataGridViewTextBoxColumn.HeaderText = "วงเงิน";
            this.rigbalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rigbalanceDataGridViewTextBoxColumn.Name = "rigbalanceDataGridViewTextBoxColumn";
            this.rigbalanceDataGridViewTextBoxColumn.Width = 90;
            // 
            // rigUnameDataGridViewTextBoxColumn
            // 
            this.rigUnameDataGridViewTextBoxColumn.DataPropertyName = "rig_Uname";
            this.rigUnameDataGridViewTextBoxColumn.HeaderText = "ผู้มีสิทธิ";
            this.rigUnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rigUnameDataGridViewTextBoxColumn.Name = "rigUnameDataGridViewTextBoxColumn";
            // 
            // rigdateDataGridViewTextBoxColumn
            // 
            this.rigdateDataGridViewTextBoxColumn.DataPropertyName = "rig_date";
            this.rigdateDataGridViewTextBoxColumn.HeaderText = "วันที่แก้ไขล่าสุด";
            this.rigdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rigdateDataGridViewTextBoxColumn.Name = "rigdateDataGridViewTextBoxColumn";
            this.rigdateDataGridViewTextBoxColumn.Width = 120;
            // 
            // Formhr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectWB.Properties.Resources.Screenshot_2022_11_07_091441;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1388, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Formhr";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบแผนกทรัพยากรมนุษย์";
            this.Load += new System.EventHandler(this.Formhr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medwelfareRightEmpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightEmpBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn rreceiptDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn rdocDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rig_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rig_name;
        private System.Windows.Forms.TextBox rig_balance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rig_Uname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private MedwelfareRightEmpDataSet medwelfareRightEmpDataSet;
        private System.Windows.Forms.BindingSource rightEmpBindingSource;
        private MedwelfareRightEmpDataSetTableAdapters.RightEmpTableAdapter rightEmpTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rignoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rignameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rigbalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rigUnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rigdateDataGridViewTextBoxColumn;
    }
}