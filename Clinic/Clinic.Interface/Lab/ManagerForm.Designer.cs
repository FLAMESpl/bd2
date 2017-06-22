namespace Clinic.Interface.LabManager
{
    partial class ManagerForm
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
            this.dataGridViewTests = new System.Windows.Forms.DataGridView();
            this.PatientFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecutionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAcceptCancelTest = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTests
            // 
            this.dataGridViewTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientFirstName,
            this.PatientSurname,
            this.TestName,
            this.CommissionDate,
            this.ExecutionDate,
            this.Result,
            this.Status});
            this.dataGridViewTests.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTests.Name = "dataGridViewTests";
            this.dataGridViewTests.Size = new System.Drawing.Size(599, 285);
            this.dataGridViewTests.TabIndex = 0;
            this.dataGridViewTests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PatientFirstName
            // 
            this.PatientFirstName.HeaderText = "Patient First Name";
            this.PatientFirstName.Name = "PatientFirstName";
            this.PatientFirstName.ReadOnly = true;
            // 
            // PatientSurname
            // 
            this.PatientSurname.HeaderText = "Patient Surname";
            this.PatientSurname.Name = "PatientSurname";
            this.PatientSurname.ReadOnly = true;
            // 
            // TestName
            // 
            this.TestName.HeaderText = "Test Name";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            // 
            // CommissionDate
            // 
            this.CommissionDate.HeaderText = "Commission date";
            this.CommissionDate.Name = "CommissionDate";
            this.CommissionDate.ReadOnly = true;
            this.CommissionDate.Width = 120;
            // 
            // ExecutionDate
            // 
            this.ExecutionDate.HeaderText = "Execution date";
            this.ExecutionDate.Name = "ExecutionDate";
            this.ExecutionDate.ReadOnly = true;
            this.ExecutionDate.Width = 120;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewTests);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(602, 288);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonAcceptCancelTest
            // 
            this.buttonAcceptCancelTest.Location = new System.Drawing.Point(163, 322);
            this.buttonAcceptCancelTest.Name = "buttonAcceptCancelTest";
            this.buttonAcceptCancelTest.Size = new System.Drawing.Size(122, 23);
            this.buttonAcceptCancelTest.TabIndex = 5;
            this.buttonAcceptCancelTest.Text = "Accept/Cancel Test";
            this.buttonAcceptCancelTest.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(332, 322);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(97, 23);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Refresh Tests";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 388);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAcceptCancelTest);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAcceptCancelTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecutionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button buttonRefresh;
    }
}