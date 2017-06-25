namespace Clinic.Interface.LabManager
{
    partial class LaboratoryForm
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
            this.dataGridViewTests = new System.Windows.Forms.DataGridView();
            this.bindingSourcePatientLaboratoryTests = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddTests = new System.Windows.Forms.Button();
            this.buttonAcceptTest = new System.Windows.Forms.Button();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelledTextBoxSurname = new Clinic.Interface.Common.LabelledTextBox();
            this.labelledTextBoxName = new Clinic.Interface.Common.LabelledTextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commissionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePatientLaboratoryTests)).BeginInit();
            this.groupBoxPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTests
            // 
            this.dataGridViewTests.AutoGenerateColumns = false;
            this.dataGridViewTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.testDataGridViewTextBoxColumn,
            this.commissionDateDataGridViewTextBoxColumn,
            this.doctorNotesDataGridViewTextBoxColumn,
            this.executionDateDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dataGridViewTests.DataSource = this.bindingSourcePatientLaboratoryTests;
            this.dataGridViewTests.Location = new System.Drawing.Point(12, 103);
            this.dataGridViewTests.MultiSelect = false;
            this.dataGridViewTests.Name = "dataGridViewTests";
            this.dataGridViewTests.ReadOnly = true;
            this.dataGridViewTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTests.Size = new System.Drawing.Size(599, 285);
            this.dataGridViewTests.TabIndex = 9;
            // 
            // bindingSourcePatientLaboratoryTests
            // 
            this.bindingSourcePatientLaboratoryTests.DataSource = typeof(Clinic.Facades.Tests.PatientLaboratoryTest);
            // 
            // buttonAddTests
            // 
            this.buttonAddTests.Location = new System.Drawing.Point(391, 415);
            this.buttonAddTests.Name = "buttonAddTests";
            this.buttonAddTests.Size = new System.Drawing.Size(140, 22);
            this.buttonAddTests.TabIndex = 8;
            this.buttonAddTests.Text = "Add tests to dictionary";
            this.buttonAddTests.UseVisualStyleBackColor = true;
            this.buttonAddTests.Click += new System.EventHandler(this.buttonAddTests_Click);
            // 
            // buttonAcceptTest
            // 
            this.buttonAcceptTest.Location = new System.Drawing.Point(101, 414);
            this.buttonAcceptTest.Name = "buttonAcceptTest";
            this.buttonAcceptTest.Size = new System.Drawing.Size(140, 23);
            this.buttonAcceptTest.TabIndex = 5;
            this.buttonAcceptTest.Text = "Accept/Cancel Test";
            this.buttonAcceptTest.UseVisualStyleBackColor = true;
            this.buttonAcceptTest.Click += new System.EventHandler(this.buttonAcceptTest_Click);
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.buttonClear);
            this.groupBoxPatient.Controls.Add(this.buttonSearch);
            this.groupBoxPatient.Controls.Add(this.labelledTextBoxSurname);
            this.groupBoxPatient.Controls.Add(this.labelledTextBoxName);
            this.groupBoxPatient.Location = new System.Drawing.Point(14, 7);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(597, 90);
            this.groupBoxPatient.TabIndex = 10;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(442, 51);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(135, 26);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(442, 19);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(135, 26);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelledTextBoxSurname
            // 
            this.labelledTextBoxSurname.Input = "";
            this.labelledTextBoxSurname.Label = "Surname";
            this.labelledTextBoxSurname.Location = new System.Drawing.Point(190, 21);
            this.labelledTextBoxSurname.Name = "labelledTextBoxSurname";
            this.labelledTextBoxSurname.Size = new System.Drawing.Size(192, 45);
            this.labelledTextBoxSurname.TabIndex = 1;
            // 
            // labelledTextBoxName
            // 
            this.labelledTextBoxName.Input = "";
            this.labelledTextBoxName.Label = "Name";
            this.labelledTextBoxName.Location = new System.Drawing.Point(9, 21);
            this.labelledTextBoxName.Name = "labelledTextBoxName";
            this.labelledTextBoxName.Size = new System.Drawing.Size(175, 46);
            this.labelledTextBoxName.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testDataGridViewTextBoxColumn
            // 
            this.testDataGridViewTextBoxColumn.DataPropertyName = "Test";
            this.testDataGridViewTextBoxColumn.HeaderText = "Test";
            this.testDataGridViewTextBoxColumn.Name = "testDataGridViewTextBoxColumn";
            this.testDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commissionDateDataGridViewTextBoxColumn
            // 
            this.commissionDateDataGridViewTextBoxColumn.DataPropertyName = "CommissionDate";
            this.commissionDateDataGridViewTextBoxColumn.HeaderText = "Commission date";
            this.commissionDateDataGridViewTextBoxColumn.Name = "commissionDateDataGridViewTextBoxColumn";
            this.commissionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorNotesDataGridViewTextBoxColumn
            // 
            this.doctorNotesDataGridViewTextBoxColumn.DataPropertyName = "DoctorNotes";
            this.doctorNotesDataGridViewTextBoxColumn.HeaderText = "Doctor notes";
            this.doctorNotesDataGridViewTextBoxColumn.Name = "doctorNotesDataGridViewTextBoxColumn";
            this.doctorNotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // executionDateDataGridViewTextBoxColumn
            // 
            this.executionDateDataGridViewTextBoxColumn.DataPropertyName = "ExecutionDate";
            this.executionDateDataGridViewTextBoxColumn.HeaderText = "Execution date";
            this.executionDateDataGridViewTextBoxColumn.Name = "executionDateDataGridViewTextBoxColumn";
            this.executionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LaboratoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(629, 487);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.dataGridViewTests);
            this.Controls.Add(this.buttonAddTests);
            this.Controls.Add(this.buttonAcceptTest);
            this.Name = "LaboratoryForm";
            this.Text = "Laboratory";
            this.Load += new System.EventHandler(this.LaboratoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePatientLaboratoryTests)).EndInit();
            this.groupBoxPatient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommDate;
        private System.Windows.Forms.Button buttonAcceptTest;
        private System.Windows.Forms.Button buttonAddTests;
        private System.Windows.Forms.DataGridView dataGridViewTests;
        private System.Windows.Forms.BindingSource bindingSourcePatientLaboratoryTests;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSearch;
        private Common.LabelledTextBox labelledTextBoxSurname;
        private Common.LabelledTextBox labelledTextBoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commissionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn executionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
    }
}