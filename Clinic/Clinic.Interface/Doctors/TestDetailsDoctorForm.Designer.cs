namespace Clinic.Interface.Doctors
{
    partial class TestDetailsDoctorForm
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
            this.btnTestDetailsDoctorReturn = new System.Windows.Forms.Button();
            this.btnDoctorAssignTest = new System.Windows.Forms.Button();
            this.dataGridTestDictionary = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewAssignedTests = new System.Windows.Forms.DataGridView();
            this.AssignedTestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDictionaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxAssignedTests = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestDictionary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestDictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignedTestsBindingSource)).BeginInit();
            this.grpBoxAssignedTests.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTestDetailsDoctorReturn
            // 
            this.btnTestDetailsDoctorReturn.Location = new System.Drawing.Point(474, 492);
            this.btnTestDetailsDoctorReturn.Name = "btnTestDetailsDoctorReturn";
            this.btnTestDetailsDoctorReturn.Size = new System.Drawing.Size(168, 32);
            this.btnTestDetailsDoctorReturn.TabIndex = 10;
            this.btnTestDetailsDoctorReturn.Text = "Go back to Visit details...";
            this.btnTestDetailsDoctorReturn.UseVisualStyleBackColor = true;
            this.btnTestDetailsDoctorReturn.Click += new System.EventHandler(this.btnTestDetailsDoctorReturn_Click);
            // 
            // btnDoctorAssignTest
            // 
            this.btnDoctorAssignTest.Location = new System.Drawing.Point(9, 267);
            this.btnDoctorAssignTest.Name = "btnDoctorAssignTest";
            this.btnDoctorAssignTest.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorAssignTest.TabIndex = 9;
            this.btnDoctorAssignTest.Text = "Assign lab test to Visit(s)";
            this.btnDoctorAssignTest.UseVisualStyleBackColor = true;
            this.btnDoctorAssignTest.Click += new System.EventHandler(this.btnDoctorAssignTest_Click);
            // 
            // dataGridTestDictionary
            // 
            this.dataGridTestDictionary.AutoGenerateColumns = false;
            this.dataGridTestDictionary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTestDictionary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridTestDictionary.DataSource = this.TestDictionaryBindingSource;
            this.dataGridTestDictionary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTestDictionary.Location = new System.Drawing.Point(3, 16);
            this.dataGridTestDictionary.Name = "dataGridTestDictionary";
            this.dataGridTestDictionary.Size = new System.Drawing.Size(398, 218);
            this.dataGridTestDictionary.TabIndex = 8;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // TestDictionaryBindingSource
            // 
            this.TestDictionaryBindingSource.DataSource = typeof(Clinic.Data.TestDictionary);
            // 
            // dataGridViewAssignedTests
            // 
            this.dataGridViewAssignedTests.AutoGenerateColumns = false;
            this.dataGridViewAssignedTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignedTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.idVisitDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn1,
            this.visitDataGridViewTextBoxColumn,
            this.testDictionaryDataGridViewTextBoxColumn});
            this.dataGridViewAssignedTests.DataSource = this.AssignedTestsBindingSource;
            this.dataGridViewAssignedTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAssignedTests.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewAssignedTests.Name = "dataGridViewAssignedTests";
            this.dataGridViewAssignedTests.Size = new System.Drawing.Size(658, 188);
            this.dataGridViewAssignedTests.TabIndex = 11;
            // 
            // AssignedTestsBindingSource
            // 
            this.AssignedTestsBindingSource.DataSource = typeof(Clinic.Data.PhysicalTest);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            // 
            // idVisitDataGridViewTextBoxColumn
            // 
            this.idVisitDataGridViewTextBoxColumn.DataPropertyName = "IdVisit";
            this.idVisitDataGridViewTextBoxColumn.HeaderText = "IdVisit";
            this.idVisitDataGridViewTextBoxColumn.Name = "idVisitDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn1
            // 
            this.codeDataGridViewTextBoxColumn1.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn1.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn1.Name = "codeDataGridViewTextBoxColumn1";
            // 
            // visitDataGridViewTextBoxColumn
            // 
            this.visitDataGridViewTextBoxColumn.DataPropertyName = "Visit";
            this.visitDataGridViewTextBoxColumn.HeaderText = "Visit";
            this.visitDataGridViewTextBoxColumn.Name = "visitDataGridViewTextBoxColumn";
            // 
            // testDictionaryDataGridViewTextBoxColumn
            // 
            this.testDictionaryDataGridViewTextBoxColumn.DataPropertyName = "TestDictionary";
            this.testDictionaryDataGridViewTextBoxColumn.HeaderText = "TestDictionary";
            this.testDictionaryDataGridViewTextBoxColumn.Name = "testDictionaryDataGridViewTextBoxColumn";
            // 
            // grpBoxAssignedTests
            // 
            this.grpBoxAssignedTests.Controls.Add(this.dataGridViewAssignedTests);
            this.grpBoxAssignedTests.Location = new System.Drawing.Point(12, 12);
            this.grpBoxAssignedTests.Name = "grpBoxAssignedTests";
            this.grpBoxAssignedTests.Size = new System.Drawing.Size(664, 207);
            this.grpBoxAssignedTests.TabIndex = 12;
            this.grpBoxAssignedTests.TabStop = false;
            this.grpBoxAssignedTests.Text = "Assigned tests:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridTestDictionary);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 237);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose tests:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnDoctorAssignTest);
            this.groupBox2.Location = new System.Drawing.Point(15, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 306);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assign new tests";
            // 
            // TestDetailsDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBoxAssignedTests);
            this.Controls.Add(this.btnTestDetailsDoctorReturn);
            this.Name = "TestDetailsDoctorForm";
            this.Text = "TestDetailsDoctorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestDictionary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestDictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignedTestsBindingSource)).EndInit();
            this.grpBoxAssignedTests.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTestDictionary;
        private System.Windows.Forms.Button btnDoctorAssignTest;
        private System.Windows.Forms.Button btnTestDetailsDoctorReturn;
        private System.Windows.Forms.BindingSource TestDictionaryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewAssignedTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDictionaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource AssignedTestsBindingSource;
        private System.Windows.Forms.GroupBox grpBoxAssignedTests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}