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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAcceptTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePatientLaboratoryTests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTests
            // 
            this.dataGridViewTests.AutoGenerateColumns = false;
            this.dataGridViewTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTests.DataSource = this.bindingSourcePatientLaboratoryTests;
            this.dataGridViewTests.Location = new System.Drawing.Point(12, 38);
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
            this.buttonAddTests.Location = new System.Drawing.Point(471, 10);
            this.buttonAddTests.Name = "buttonAddTests";
            this.buttonAddTests.Size = new System.Drawing.Size(140, 22);
            this.buttonAddTests.TabIndex = 8;
            this.buttonAddTests.Text = "Add tests to dictionary";
            this.buttonAddTests.UseVisualStyleBackColor = true;
            this.buttonAddTests.Click += new System.EventHandler(this.buttonAddTests_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(374, 340);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(110, 23);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAcceptTest
            // 
            this.buttonAcceptTest.Location = new System.Drawing.Point(104, 340);
            this.buttonAcceptTest.Name = "buttonAcceptTest";
            this.buttonAcceptTest.Size = new System.Drawing.Size(140, 23);
            this.buttonAcceptTest.TabIndex = 5;
            this.buttonAcceptTest.Text = "Accept/Cancel Test";
            this.buttonAcceptTest.UseVisualStyleBackColor = true;
            this.buttonAcceptTest.Click += new System.EventHandler(this.buttonAcceptTest_Click);
            // 
            // LaboratoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(629, 388);
            this.Controls.Add(this.dataGridViewTests);
            this.Controls.Add(this.buttonAddTests);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAcceptTest);
            this.Name = "LaboratoryForm";
            this.Text = "Laboratory";
            this.Load += new System.EventHandler(this.LaboratoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePatientLaboratoryTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommDate;
        private System.Windows.Forms.Button buttonAcceptTest;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAddTests;
        private System.Windows.Forms.DataGridView dataGridViewTests;
        private System.Windows.Forms.BindingSource bindingSourcePatientLaboratoryTests;
    }
}