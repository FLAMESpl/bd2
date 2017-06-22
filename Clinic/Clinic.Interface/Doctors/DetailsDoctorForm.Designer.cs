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
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestDictionary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Visit details";
            // 
            // btnDoctorAssignTest
            // 
            this.btnDoctorAssignTest.Location = new System.Drawing.Point(13, 218);
            this.btnDoctorAssignTest.Name = "btnDoctorAssignTest";
            this.btnDoctorAssignTest.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorAssignTest.TabIndex = 4;
            this.btnDoctorAssignTest.Text = "Assign a lab test";
            this.btnDoctorAssignTest.UseVisualStyleBackColor = true;
            this.btnDoctorAssignTest.Click += new System.EventHandler(this.btnDoctorAssignLabTest);
            // 
            // lblChooseInfo
            // 
            this.lblChooseInfo.AutoSize = true;
            this.lblChooseInfo.Location = new System.Drawing.Point(14, 149);
            this.lblChooseInfo.Name = "lblChooseInfo";
            this.lblChooseInfo.Size = new System.Drawing.Size(140, 13);
            this.lblChooseInfo.TabIndex = 3;
            this.lblChooseInfo.Text = "Choose an action for visit(s):";
            // 
            // btnDoctorReturn
            // 
            this.btnDoctorReturn.Location = new System.Drawing.Point(347, 180);
            this.btnDoctorReturn.Name = "btnDoctorReturn";
            this.btnDoctorReturn.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorReturn.TabIndex = 2;
            this.btnDoctorReturn.Text = "Go back to all Visits...";
            this.btnDoctorReturn.UseVisualStyleBackColor = true;
            this.btnDoctorReturn.Click += new System.EventHandler(this.btnDoctorReturn_Click);
            // 
            // btnDoctorFinalizeVisit
            // 
            this.btnDoctorFinalizeVisit.Location = new System.Drawing.Point(13, 180);
            this.btnDoctorFinalizeVisit.Name = "btnDoctorFinalizeVisit";
            this.btnDoctorFinalizeVisit.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorFinalizeVisit.TabIndex = 1;
            this.btnDoctorFinalizeVisit.Text = "Finalize Visit";
            this.btnDoctorFinalizeVisit.UseVisualStyleBackColor = true;
            this.btnDoctorFinalizeVisit.Click += new System.EventHandler(this.btnDoctorFinalizeVisit_Click);
            // 
            // btnDoctorCancelVisit
            // 
            this.btnDoctorCancelVisit.Location = new System.Drawing.Point(147, 180);
            this.btnDoctorCancelVisit.Name = "btnDoctorCancelVisit";
            this.btnDoctorCancelVisit.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorCancelVisit.TabIndex = 0;
            this.btnDoctorCancelVisit.Text = "Cancel Visit";
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
            this.dataGridTestDictionary.Location = new System.Drawing.Point(147, 218);
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
            // DetailsDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 446);
            this.Controls.Add(this.dataGridTestDictionary);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoctorCancelVisit;
        private System.Windows.Forms.Button btnDoctorFinalizeVisit;
        private System.Windows.Forms.Button btnDoctorReturn;
        private System.Windows.Forms.Label lblChooseInfo;
        private System.Windows.Forms.Button btnDoctorAssignTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridTestDictionary;
        private clinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource testDictionaryBindingSource;
        private clinicDataSetTableAdapters.TestDictionaryTableAdapter testDictionaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}