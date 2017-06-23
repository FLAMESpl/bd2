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
            this.TestDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestDictionary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestDictionaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTestDetailsDoctorReturn
            // 
            this.btnTestDetailsDoctorReturn.Location = new System.Drawing.Point(305, 381);
            this.btnTestDetailsDoctorReturn.Name = "btnTestDetailsDoctorReturn";
            this.btnTestDetailsDoctorReturn.Size = new System.Drawing.Size(168, 32);
            this.btnTestDetailsDoctorReturn.TabIndex = 10;
            this.btnTestDetailsDoctorReturn.Text = "Go back to Visit details...";
            this.btnTestDetailsDoctorReturn.UseVisualStyleBackColor = true;
            this.btnTestDetailsDoctorReturn.Click += new System.EventHandler(this.btnTestDetailsDoctorReturn_Click);
            // 
            // btnDoctorAssignTest
            // 
            this.btnDoctorAssignTest.Location = new System.Drawing.Point(171, 381);
            this.btnDoctorAssignTest.Name = "btnDoctorAssignTest";
            this.btnDoctorAssignTest.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorAssignTest.TabIndex = 9;
            this.btnDoctorAssignTest.Text = "Assign lab test to Visit(s)";
            this.btnDoctorAssignTest.UseVisualStyleBackColor = true;
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
            this.dataGridTestDictionary.Location = new System.Drawing.Point(85, 187);
            this.dataGridTestDictionary.Name = "dataGridTestDictionary";
            this.dataGridTestDictionary.Size = new System.Drawing.Size(348, 150);
            this.dataGridTestDictionary.TabIndex = 8;
            // 
            // TestDictionaryBindingSource
            // 
            this.TestDictionaryBindingSource.DataSource = typeof(Clinic.Data.TestDictionary);
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
            // TestDetailsDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 446);
            this.Controls.Add(this.btnTestDetailsDoctorReturn);
            this.Controls.Add(this.btnDoctorAssignTest);
            this.Controls.Add(this.dataGridTestDictionary);
            this.Name = "TestDetailsDoctorForm";
            this.Text = "TestDetailsDoctorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTestDictionary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestDictionaryBindingSource)).EndInit();
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
    }
}