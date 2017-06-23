﻿namespace Clinic.Interface.Doctors
{
    partial class DetailsDoctorForm
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
            this.btnDoctorAssignTest = new System.Windows.Forms.Button();
            this.btnDoctorReturn = new System.Windows.Forms.Button();
            this.testDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet = new Clinic.Interface.clinicDataSet();
            this.testDictionaryTableAdapter = new Clinic.Interface.clinicDataSetTableAdapters.TestDictionaryTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDetailsPatientPESEL = new System.Windows.Forms.Label();
            this.lblDetailsPatientSurname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditDiagnosis = new System.Windows.Forms.Button();
            this.lblDetailsDescription = new System.Windows.Forms.Label();
            this.lblDetailsPatientName = new System.Windows.Forms.Label();
            this.btnTestDetails = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridTestDictionary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.testDictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestDictionary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoctorAssignTest
            // 
            this.btnDoctorAssignTest.Location = new System.Drawing.Point(817, 285);
            this.btnDoctorAssignTest.Name = "btnDoctorAssignTest";
            this.btnDoctorAssignTest.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorAssignTest.TabIndex = 4;
            this.btnDoctorAssignTest.Text = "Assign lab test to Visit(s)";
            this.btnDoctorAssignTest.UseVisualStyleBackColor = true;
            this.btnDoctorAssignTest.Click += new System.EventHandler(this.btnDoctorAssignLabTest);
            // 
            // btnDoctorReturn
            // 
            this.btnDoctorReturn.Location = new System.Drawing.Point(367, 440);
            this.btnDoctorReturn.Name = "btnDoctorReturn";
            this.btnDoctorReturn.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorReturn.TabIndex = 2;
            this.btnDoctorReturn.Text = "Go back to all Visits...";
            this.btnDoctorReturn.UseVisualStyleBackColor = true;
            this.btnDoctorReturn.Click += new System.EventHandler(this.btnDoctorReturn_Click);
            // 
            // testDictionaryBindingSource
            // 
            this.testDictionaryBindingSource.DataMember = "TestDictionary";
            this.testDictionaryBindingSource.DataSource = this.clinicDataSet;
            // 
            // clinicDataSet
            // 
            this.clinicDataSet.DataSetName = "clinicDataSet";
            this.clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDictionaryTableAdapter
            // 
            this.testDictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDetailsPatientPESEL);
            this.groupBox1.Controls.Add(this.lblDetailsPatientSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEditDiagnosis);
            this.groupBox1.Controls.Add(this.lblDetailsDescription);
            this.groupBox1.Controls.Add(this.lblDetailsPatientName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 304);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visit details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "<diagnosis>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "<description>";
            // 
            // lblDetailsPatientPESEL
            // 
            this.lblDetailsPatientPESEL.AutoSize = true;
            this.lblDetailsPatientPESEL.Location = new System.Drawing.Point(7, 46);
            this.lblDetailsPatientPESEL.Name = "lblDetailsPatientPESEL";
            this.lblDetailsPatientPESEL.Size = new System.Drawing.Size(77, 13);
            this.lblDetailsPatientPESEL.TabIndex = 5;
            this.lblDetailsPatientPESEL.Text = "Patient PESEL";
            // 
            // lblDetailsPatientSurname
            // 
            this.lblDetailsPatientSurname.AutoSize = true;
            this.lblDetailsPatientSurname.Location = new System.Drawing.Point(7, 33);
            this.lblDetailsPatientSurname.Name = "lblDetailsPatientSurname";
            this.lblDetailsPatientSurname.Size = new System.Drawing.Size(85, 13);
            this.lblDetailsPatientSurname.TabIndex = 4;
            this.lblDetailsPatientSurname.Text = "Patient Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Diagnosis:";
            // 
            // btnEditDiagnosis
            // 
            this.btnEditDiagnosis.Location = new System.Drawing.Point(321, 20);
            this.btnEditDiagnosis.Name = "btnEditDiagnosis";
            this.btnEditDiagnosis.Size = new System.Drawing.Size(141, 42);
            this.btnEditDiagnosis.TabIndex = 2;
            this.btnEditDiagnosis.Text = "Edit Diagnosis";
            this.btnEditDiagnosis.UseVisualStyleBackColor = true;
            // 
            // lblDetailsDescription
            // 
            this.lblDetailsDescription.AutoSize = true;
            this.lblDetailsDescription.Location = new System.Drawing.Point(7, 77);
            this.lblDetailsDescription.Name = "lblDetailsDescription";
            this.lblDetailsDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDetailsDescription.TabIndex = 1;
            this.lblDetailsDescription.Text = "Description:";
            // 
            // lblDetailsPatientName
            // 
            this.lblDetailsPatientName.AutoSize = true;
            this.lblDetailsPatientName.Location = new System.Drawing.Point(7, 20);
            this.lblDetailsPatientName.Name = "lblDetailsPatientName";
            this.lblDetailsPatientName.Size = new System.Drawing.Size(71, 13);
            this.lblDetailsPatientName.TabIndex = 0;
            this.lblDetailsPatientName.Text = "Patient Name";
            // 
            // btnTestDetails
            // 
            this.btnTestDetails.Location = new System.Drawing.Point(233, 440);
            this.btnTestDetails.Name = "btnTestDetails";
            this.btnTestDetails.Size = new System.Drawing.Size(128, 32);
            this.btnTestDetails.TabIndex = 9;
            this.btnTestDetails.Text = "Show/Edit tests...";
            this.btnTestDetails.UseVisualStyleBackColor = true;
            this.btnTestDetails.Click += new System.EventHandler(this.btnTestDetails_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // dataGridTestDictionary
            // 
            this.dataGridTestDictionary.AutoGenerateColumns = false;
            this.dataGridTestDictionary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTestDictionary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridTestDictionary.DataSource = this.testDictionaryBindingSource;
            this.dataGridTestDictionary.Location = new System.Drawing.Point(646, 105);
            this.dataGridTestDictionary.Name = "dataGridTestDictionary";
            this.dataGridTestDictionary.Size = new System.Drawing.Size(348, 150);
            this.dataGridTestDictionary.TabIndex = 7;
            // 
            // DetailsDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 517);
            this.Controls.Add(this.btnTestDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridTestDictionary);
            this.Controls.Add(this.btnDoctorAssignTest);
            this.Controls.Add(this.btnDoctorReturn);
            this.Name = "DetailsDoctorForm";
            this.Text = "DetailsDoctorForm";
            this.Load += new System.EventHandler(this.DetailsDoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestDictionary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDoctorReturn;
        private System.Windows.Forms.Button btnDoctorAssignTest;
        private clinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource testDictionaryBindingSource;
        private clinicDataSetTableAdapters.TestDictionaryTableAdapter testDictionaryTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDetailsDescription;
        private System.Windows.Forms.Label lblDetailsPatientName;
        private System.Windows.Forms.Button btnEditDiagnosis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDetailsPatientPESEL;
        private System.Windows.Forms.Label lblDetailsPatientSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTestDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridTestDictionary;
    }
}