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
            this.TestDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ScheduledTestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ApprovedTestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabScheduledTests = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewScheduled = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewExecutedTests = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridTestDictionary = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDoctorAssignTest = new System.Windows.Forms.Button();
            this.btnTestDetailsDoctorReturn = new System.Windows.Forms.Button();
            this.codeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comissionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLabManagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLabAssistantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labAssistantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDictionaryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNotesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comissionDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerNotesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executionDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLabManagerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLabAssistantDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labAssistantDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDictionaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTestDetailsDoctorRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TestDictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduledTestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovedTestsBindingSource)).BeginInit();
            this.tabScheduledTests.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScheduled)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExecutedTests)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestDictionary)).BeginInit();
            this.SuspendLayout();
            // 
            // TestDictionaryBindingSource
            // 
            this.TestDictionaryBindingSource.DataSource = typeof(Clinic.Data.TestDictionary);
            // 
            // ScheduledTestsBindingSource
            // 
            this.ScheduledTestsBindingSource.DataSource = typeof(Clinic.Data.LaboratoryTest);
            // 
            // ApprovedTestsBindingSource
            // 
            this.ApprovedTestsBindingSource.DataSource = typeof(Clinic.Data.LaboratoryTest);
            // 
            // tabScheduledTests
            // 
            this.tabScheduledTests.Controls.Add(this.tabPage1);
            this.tabScheduledTests.Controls.Add(this.tabPage2);
            this.tabScheduledTests.Location = new System.Drawing.Point(12, 12);
            this.tabScheduledTests.Name = "tabScheduledTests";
            this.tabScheduledTests.SelectedIndex = 0;
            this.tabScheduledTests.Size = new System.Drawing.Size(871, 226);
            this.tabScheduledTests.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewScheduled);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(863, 200);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scheduled tests";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewScheduled
            // 
            this.dataGridViewScheduled.AutoGenerateColumns = false;
            this.dataGridViewScheduled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScheduled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn2,
            this.doctorNotesDataGridViewTextBoxColumn,
            this.comissionDateDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.resultDataGridViewTextBoxColumn1,
            this.executionDateDataGridViewTextBoxColumn,
            this.managerNotesDataGridViewTextBoxColumn,
            this.resolutionDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.idVisitDataGridViewTextBoxColumn1,
            this.idLabManagerDataGridViewTextBoxColumn,
            this.idLabAssistantDataGridViewTextBoxColumn,
            this.labAssistantDataGridViewTextBoxColumn,
            this.visitDataGridViewTextBoxColumn1,
            this.testDictionaryDataGridViewTextBoxColumn1});
            this.dataGridViewScheduled.DataSource = this.ScheduledTestsBindingSource;
            this.dataGridViewScheduled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewScheduled.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewScheduled.Name = "dataGridViewScheduled";
            this.dataGridViewScheduled.Size = new System.Drawing.Size(857, 194);
            this.dataGridViewScheduled.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewExecutedTests);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(863, 200);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Finished tests";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExecutedTests
            // 
            this.dataGridViewExecutedTests.AutoGenerateColumns = false;
            this.dataGridViewExecutedTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExecutedTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn1,
            this.doctorNotesDataGridViewTextBoxColumn1,
            this.idDataGridViewTextBoxColumn,
            this.comissionDateDataGridViewTextBoxColumn1,
            this.resultDataGridViewTextBoxColumn,
            this.resolutionDateDataGridViewTextBoxColumn1,
            this.managerNotesDataGridViewTextBoxColumn1,
            this.executionDateDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1,
            this.idVisitDataGridViewTextBoxColumn,
            this.idLabManagerDataGridViewTextBoxColumn1,
            this.idLabAssistantDataGridViewTextBoxColumn1,
            this.labAssistantDataGridViewTextBoxColumn1,
            this.visitDataGridViewTextBoxColumn,
            this.testDictionaryDataGridViewTextBoxColumn});
            this.dataGridViewExecutedTests.DataSource = this.ApprovedTestsBindingSource;
            this.dataGridViewExecutedTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExecutedTests.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewExecutedTests.Name = "dataGridViewExecutedTests";
            this.dataGridViewExecutedTests.Size = new System.Drawing.Size(857, 194);
            this.dataGridViewExecutedTests.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridTestDictionary);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 237);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assign more tests:";
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
            // codeDataGridViewTextBoxColumn2
            // 
            this.codeDataGridViewTextBoxColumn2.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn2.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn2.Name = "codeDataGridViewTextBoxColumn2";
            // 
            // doctorNotesDataGridViewTextBoxColumn
            // 
            this.doctorNotesDataGridViewTextBoxColumn.DataPropertyName = "DoctorNotes";
            this.doctorNotesDataGridViewTextBoxColumn.HeaderText = "DoctorNotes";
            this.doctorNotesDataGridViewTextBoxColumn.Name = "doctorNotesDataGridViewTextBoxColumn";
            // 
            // comissionDateDataGridViewTextBoxColumn
            // 
            this.comissionDateDataGridViewTextBoxColumn.DataPropertyName = "ComissionDate";
            this.comissionDateDataGridViewTextBoxColumn.HeaderText = "ComissionDate";
            this.comissionDateDataGridViewTextBoxColumn.Name = "comissionDateDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // resultDataGridViewTextBoxColumn1
            // 
            this.resultDataGridViewTextBoxColumn1.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn1.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn1.Name = "resultDataGridViewTextBoxColumn1";
            this.resultDataGridViewTextBoxColumn1.Visible = false;
            // 
            // executionDateDataGridViewTextBoxColumn
            // 
            this.executionDateDataGridViewTextBoxColumn.DataPropertyName = "ExecutionDate";
            this.executionDateDataGridViewTextBoxColumn.HeaderText = "ExecutionDate";
            this.executionDateDataGridViewTextBoxColumn.Name = "executionDateDataGridViewTextBoxColumn";
            this.executionDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // managerNotesDataGridViewTextBoxColumn
            // 
            this.managerNotesDataGridViewTextBoxColumn.DataPropertyName = "ManagerNotes";
            this.managerNotesDataGridViewTextBoxColumn.HeaderText = "ManagerNotes";
            this.managerNotesDataGridViewTextBoxColumn.Name = "managerNotesDataGridViewTextBoxColumn";
            this.managerNotesDataGridViewTextBoxColumn.Visible = false;
            // 
            // resolutionDateDataGridViewTextBoxColumn
            // 
            this.resolutionDateDataGridViewTextBoxColumn.DataPropertyName = "ResolutionDate";
            this.resolutionDateDataGridViewTextBoxColumn.HeaderText = "ResolutionDate";
            this.resolutionDateDataGridViewTextBoxColumn.Name = "resolutionDateDataGridViewTextBoxColumn";
            this.resolutionDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // idVisitDataGridViewTextBoxColumn1
            // 
            this.idVisitDataGridViewTextBoxColumn1.DataPropertyName = "IdVisit";
            this.idVisitDataGridViewTextBoxColumn1.HeaderText = "IdVisit";
            this.idVisitDataGridViewTextBoxColumn1.Name = "idVisitDataGridViewTextBoxColumn1";
            this.idVisitDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idLabManagerDataGridViewTextBoxColumn
            // 
            this.idLabManagerDataGridViewTextBoxColumn.DataPropertyName = "IdLabManager";
            this.idLabManagerDataGridViewTextBoxColumn.HeaderText = "IdLabManager";
            this.idLabManagerDataGridViewTextBoxColumn.Name = "idLabManagerDataGridViewTextBoxColumn";
            this.idLabManagerDataGridViewTextBoxColumn.Visible = false;
            // 
            // idLabAssistantDataGridViewTextBoxColumn
            // 
            this.idLabAssistantDataGridViewTextBoxColumn.DataPropertyName = "IdLabAssistant";
            this.idLabAssistantDataGridViewTextBoxColumn.HeaderText = "IdLabAssistant";
            this.idLabAssistantDataGridViewTextBoxColumn.Name = "idLabAssistantDataGridViewTextBoxColumn";
            this.idLabAssistantDataGridViewTextBoxColumn.Visible = false;
            // 
            // labAssistantDataGridViewTextBoxColumn
            // 
            this.labAssistantDataGridViewTextBoxColumn.DataPropertyName = "LabAssistant";
            this.labAssistantDataGridViewTextBoxColumn.HeaderText = "LabAssistant";
            this.labAssistantDataGridViewTextBoxColumn.Name = "labAssistantDataGridViewTextBoxColumn";
            this.labAssistantDataGridViewTextBoxColumn.Visible = false;
            // 
            // visitDataGridViewTextBoxColumn1
            // 
            this.visitDataGridViewTextBoxColumn1.DataPropertyName = "Visit";
            this.visitDataGridViewTextBoxColumn1.HeaderText = "Visit";
            this.visitDataGridViewTextBoxColumn1.Name = "visitDataGridViewTextBoxColumn1";
            this.visitDataGridViewTextBoxColumn1.Visible = false;
            // 
            // testDictionaryDataGridViewTextBoxColumn1
            // 
            this.testDictionaryDataGridViewTextBoxColumn1.DataPropertyName = "TestDictionary";
            this.testDictionaryDataGridViewTextBoxColumn1.HeaderText = "TestDictionary";
            this.testDictionaryDataGridViewTextBoxColumn1.Name = "testDictionaryDataGridViewTextBoxColumn1";
            this.testDictionaryDataGridViewTextBoxColumn1.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn1
            // 
            this.codeDataGridViewTextBoxColumn1.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn1.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn1.Name = "codeDataGridViewTextBoxColumn1";
            // 
            // doctorNotesDataGridViewTextBoxColumn1
            // 
            this.doctorNotesDataGridViewTextBoxColumn1.DataPropertyName = "DoctorNotes";
            this.doctorNotesDataGridViewTextBoxColumn1.HeaderText = "DoctorNotes";
            this.doctorNotesDataGridViewTextBoxColumn1.Name = "doctorNotesDataGridViewTextBoxColumn1";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // comissionDateDataGridViewTextBoxColumn1
            // 
            this.comissionDateDataGridViewTextBoxColumn1.DataPropertyName = "ComissionDate";
            this.comissionDateDataGridViewTextBoxColumn1.HeaderText = "ComissionDate";
            this.comissionDateDataGridViewTextBoxColumn1.Name = "comissionDateDataGridViewTextBoxColumn1";
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            // 
            // resolutionDateDataGridViewTextBoxColumn1
            // 
            this.resolutionDateDataGridViewTextBoxColumn1.DataPropertyName = "ResolutionDate";
            this.resolutionDateDataGridViewTextBoxColumn1.HeaderText = "ResolutionDate";
            this.resolutionDateDataGridViewTextBoxColumn1.Name = "resolutionDateDataGridViewTextBoxColumn1";
            // 
            // managerNotesDataGridViewTextBoxColumn1
            // 
            this.managerNotesDataGridViewTextBoxColumn1.DataPropertyName = "ManagerNotes";
            this.managerNotesDataGridViewTextBoxColumn1.HeaderText = "ManagerNotes";
            this.managerNotesDataGridViewTextBoxColumn1.Name = "managerNotesDataGridViewTextBoxColumn1";
            // 
            // executionDateDataGridViewTextBoxColumn1
            // 
            this.executionDateDataGridViewTextBoxColumn1.DataPropertyName = "ExecutionDate";
            this.executionDateDataGridViewTextBoxColumn1.HeaderText = "ExecutionDate";
            this.executionDateDataGridViewTextBoxColumn1.Name = "executionDateDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idVisitDataGridViewTextBoxColumn
            // 
            this.idVisitDataGridViewTextBoxColumn.DataPropertyName = "IdVisit";
            this.idVisitDataGridViewTextBoxColumn.HeaderText = "IdVisit";
            this.idVisitDataGridViewTextBoxColumn.Name = "idVisitDataGridViewTextBoxColumn";
            this.idVisitDataGridViewTextBoxColumn.Visible = false;
            // 
            // idLabManagerDataGridViewTextBoxColumn1
            // 
            this.idLabManagerDataGridViewTextBoxColumn1.DataPropertyName = "IdLabManager";
            this.idLabManagerDataGridViewTextBoxColumn1.HeaderText = "IdLabManager";
            this.idLabManagerDataGridViewTextBoxColumn1.Name = "idLabManagerDataGridViewTextBoxColumn1";
            this.idLabManagerDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idLabAssistantDataGridViewTextBoxColumn1
            // 
            this.idLabAssistantDataGridViewTextBoxColumn1.DataPropertyName = "IdLabAssistant";
            this.idLabAssistantDataGridViewTextBoxColumn1.HeaderText = "IdLabAssistant";
            this.idLabAssistantDataGridViewTextBoxColumn1.Name = "idLabAssistantDataGridViewTextBoxColumn1";
            this.idLabAssistantDataGridViewTextBoxColumn1.Visible = false;
            // 
            // labAssistantDataGridViewTextBoxColumn1
            // 
            this.labAssistantDataGridViewTextBoxColumn1.DataPropertyName = "LabAssistant";
            this.labAssistantDataGridViewTextBoxColumn1.HeaderText = "LabAssistant";
            this.labAssistantDataGridViewTextBoxColumn1.Name = "labAssistantDataGridViewTextBoxColumn1";
            this.labAssistantDataGridViewTextBoxColumn1.Visible = false;
            // 
            // visitDataGridViewTextBoxColumn
            // 
            this.visitDataGridViewTextBoxColumn.DataPropertyName = "Visit";
            this.visitDataGridViewTextBoxColumn.HeaderText = "Visit";
            this.visitDataGridViewTextBoxColumn.Name = "visitDataGridViewTextBoxColumn";
            this.visitDataGridViewTextBoxColumn.Visible = false;
            // 
            // testDictionaryDataGridViewTextBoxColumn
            // 
            this.testDictionaryDataGridViewTextBoxColumn.DataPropertyName = "TestDictionary";
            this.testDictionaryDataGridViewTextBoxColumn.HeaderText = "TestDictionary";
            this.testDictionaryDataGridViewTextBoxColumn.Name = "testDictionaryDataGridViewTextBoxColumn";
            this.testDictionaryDataGridViewTextBoxColumn.Visible = false;
            // 
            // btnTestDetailsDoctorRefresh
            // 
            this.btnTestDetailsDoctorRefresh.Location = new System.Drawing.Point(474, 457);
            this.btnTestDetailsDoctorRefresh.Name = "btnTestDetailsDoctorRefresh";
            this.btnTestDetailsDoctorRefresh.Size = new System.Drawing.Size(168, 29);
            this.btnTestDetailsDoctorRefresh.TabIndex = 16;
            this.btnTestDetailsDoctorRefresh.Text = "Refresh all data in window";
            this.btnTestDetailsDoctorRefresh.UseVisualStyleBackColor = true;
            this.btnTestDetailsDoctorRefresh.Click += new System.EventHandler(this.btnTestDetailsDoctorRefresh_Click);
            // 
            // TestDetailsDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 565);
            this.Controls.Add(this.btnTestDetailsDoctorRefresh);
            this.Controls.Add(this.tabScheduledTests);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTestDetailsDoctorReturn);
            this.Name = "TestDetailsDoctorForm";
            this.Text = "TestDetailsDoctorForm";
            ((System.ComponentModel.ISupportInitialize)(this.TestDictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduledTestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApprovedTestsBindingSource)).EndInit();
            this.tabScheduledTests.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScheduled)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExecutedTests)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestDictionary)).EndInit();
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
        private System.Windows.Forms.BindingSource ScheduledTestsBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabScheduledTests;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewScheduled;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource ApprovedTestsBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewExecutedTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comissionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn executionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolutionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLabManagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLabAssistantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labAssistantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDictionaryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNotesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comissionDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolutionDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerNotesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn executionDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLabManagerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLabAssistantDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn labAssistantDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDictionaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTestDetailsDoctorRefresh;
    }
}