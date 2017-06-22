namespace Clinic.Interface.Doctors
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
            this.lblChooseInfo = new System.Windows.Forms.Label();
            this.btnDoctorReturn = new System.Windows.Forms.Button();
            this.btnDoctorFinalizeVisit = new System.Windows.Forms.Button();
            this.btnDoctorCancelVisit = new System.Windows.Forms.Button();
            this.dataGridTestDictionary = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet = new Clinic.Interface.clinicDataSet();
            this.testDictionaryTableAdapter = new Clinic.Interface.clinicDataSetTableAdapters.TestDictionaryTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDetailsPatientName = new System.Windows.Forms.Label();
            this.lblDetailsDescription = new System.Windows.Forms.Label();
            this.btnEditDiagnosis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDetailsPatientSurname = new System.Windows.Forms.Label();
            this.lblDetailsPatientPESEL = new System.Windows.Forms.Label();
            this.cmbChooseDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDetailsPhysicalTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestDictionary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoctorAssignTest
            // 
            this.btnDoctorAssignTest.Location = new System.Drawing.Point(13, 386);
            this.btnDoctorAssignTest.Name = "btnDoctorAssignTest";
            this.btnDoctorAssignTest.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorAssignTest.TabIndex = 4;
            this.btnDoctorAssignTest.Text = "Assign lab test to Visit(s)";
            this.btnDoctorAssignTest.UseVisualStyleBackColor = true;
            this.btnDoctorAssignTest.Click += new System.EventHandler(this.btnDoctorAssignLabTest);
            // 
            // lblChooseInfo
            // 
            this.lblChooseInfo.AutoSize = true;
            this.lblChooseInfo.Location = new System.Drawing.Point(10, 242);
            this.lblChooseInfo.Name = "lblChooseInfo";
            this.lblChooseInfo.Size = new System.Drawing.Size(140, 13);
            this.lblChooseInfo.TabIndex = 3;
            this.lblChooseInfo.Text = "Choose an action for visit(s):";
            // 
            // btnDoctorReturn
            // 
            this.btnDoctorReturn.Location = new System.Drawing.Point(347, 258);
            this.btnDoctorReturn.Name = "btnDoctorReturn";
            this.btnDoctorReturn.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorReturn.TabIndex = 2;
            this.btnDoctorReturn.Text = "Go back to all Visits...";
            this.btnDoctorReturn.UseVisualStyleBackColor = true;
            this.btnDoctorReturn.Click += new System.EventHandler(this.btnDoctorReturn_Click);
            // 
            // btnDoctorFinalizeVisit
            // 
            this.btnDoctorFinalizeVisit.Location = new System.Drawing.Point(13, 258);
            this.btnDoctorFinalizeVisit.Name = "btnDoctorFinalizeVisit";
            this.btnDoctorFinalizeVisit.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorFinalizeVisit.TabIndex = 1;
            this.btnDoctorFinalizeVisit.Text = "Finalize Visit(s)";
            this.btnDoctorFinalizeVisit.UseVisualStyleBackColor = true;
            this.btnDoctorFinalizeVisit.Click += new System.EventHandler(this.btnDoctorFinalizeVisit_Click);
            // 
            // btnDoctorCancelVisit
            // 
            this.btnDoctorCancelVisit.Location = new System.Drawing.Point(147, 258);
            this.btnDoctorCancelVisit.Name = "btnDoctorCancelVisit";
            this.btnDoctorCancelVisit.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorCancelVisit.TabIndex = 0;
            this.btnDoctorCancelVisit.Text = "Cancel Visit(s)";
            this.btnDoctorCancelVisit.UseVisualStyleBackColor = true;
            this.btnDoctorCancelVisit.Click += new System.EventHandler(this.btnDoctorCancelVisit_Click);
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
            this.dataGridTestDictionary.Location = new System.Drawing.Point(147, 297);
            this.dataGridTestDictionary.Name = "dataGridTestDictionary";
            this.dataGridTestDictionary.Size = new System.Drawing.Size(348, 150);
            this.dataGridTestDictionary.TabIndex = 7;
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbChooseDate);
            this.groupBox1.Controls.Add(this.lblDetailsPatientPESEL);
            this.groupBox1.Controls.Add(this.lblDetailsPatientSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEditDiagnosis);
            this.groupBox1.Controls.Add(this.lblDetailsDescription);
            this.groupBox1.Controls.Add(this.lblDetailsPatientName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 226);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visit details";
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
            // lblDetailsDescription
            // 
            this.lblDetailsDescription.AutoSize = true;
            this.lblDetailsDescription.Location = new System.Drawing.Point(7, 77);
            this.lblDetailsDescription.Name = "lblDetailsDescription";
            this.lblDetailsDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDetailsDescription.TabIndex = 1;
            this.lblDetailsDescription.Text = "Description:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Diagnosis:";
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
            // lblDetailsPatientPESEL
            // 
            this.lblDetailsPatientPESEL.AutoSize = true;
            this.lblDetailsPatientPESEL.Location = new System.Drawing.Point(7, 46);
            this.lblDetailsPatientPESEL.Name = "lblDetailsPatientPESEL";
            this.lblDetailsPatientPESEL.Size = new System.Drawing.Size(77, 13);
            this.lblDetailsPatientPESEL.TabIndex = 5;
            this.lblDetailsPatientPESEL.Text = "Patient PESEL";
            // 
            // cmbChooseDate
            // 
            this.cmbChooseDate.FormattingEnabled = true;
            this.cmbChooseDate.Location = new System.Drawing.Point(167, 36);
            this.cmbChooseDate.Name = "cmbChooseDate";
            this.cmbChooseDate.Size = new System.Drawing.Size(138, 21);
            this.cmbChooseDate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose a Visit:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "<diagnosis>";
            // 
            // btnDetailsPhysicalTest
            // 
            this.btnDetailsPhysicalTest.Location = new System.Drawing.Point(13, 297);
            this.btnDetailsPhysicalTest.Name = "btnDetailsPhysicalTest";
            this.btnDetailsPhysicalTest.Size = new System.Drawing.Size(128, 32);
            this.btnDetailsPhysicalTest.TabIndex = 9;
            this.btnDetailsPhysicalTest.Text = "Physical Test";
            this.btnDetailsPhysicalTest.UseVisualStyleBackColor = true;
            this.btnDetailsPhysicalTest.Click += new System.EventHandler(this.btnDetailsPhysicalTest_Click);
            // 
            // DetailsDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 490);
            this.Controls.Add(this.btnDetailsPhysicalTest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridTestDictionary);
            this.Controls.Add(this.btnDoctorAssignTest);
            this.Controls.Add(this.lblChooseInfo);
            this.Controls.Add(this.btnDoctorReturn);
            this.Controls.Add(this.btnDoctorFinalizeVisit);
            this.Controls.Add(this.btnDoctorCancelVisit);
            this.Name = "DetailsDoctorForm";
            this.Text = "DetailsDoctorForm";
            this.Load += new System.EventHandler(this.DetailsDoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestDictionary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoctorCancelVisit;
        private System.Windows.Forms.Button btnDoctorFinalizeVisit;
        private System.Windows.Forms.Button btnDoctorReturn;
        private System.Windows.Forms.Label lblChooseInfo;
        private System.Windows.Forms.Button btnDoctorAssignTest;
        private System.Windows.Forms.DataGridView dataGridTestDictionary;
        private clinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource testDictionaryBindingSource;
        private clinicDataSetTableAdapters.TestDictionaryTableAdapter testDictionaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDetailsDescription;
        private System.Windows.Forms.Label lblDetailsPatientName;
        private System.Windows.Forms.Button btnEditDiagnosis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDetailsPatientPESEL;
        private System.Windows.Forms.Label lblDetailsPatientSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChooseDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDetailsPhysicalTest;
    }
}