namespace Clinic.Interface.Lab
{
    partial class TestDictionaryForm
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
            this.groupBoxTestType = new System.Windows.Forms.GroupBox();
            this.radioButtonPhysical = new System.Windows.Forms.RadioButton();
            this.radioButtonLaboratory = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelledTextBoxName = new Clinic.Interface.Common.LabelledTextBox();
            this.labelledTextBoxCode = new Clinic.Interface.Common.LabelledTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).BeginInit();
            this.groupBoxTestType.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTests
            // 
            this.dataGridViewTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTests.Location = new System.Drawing.Point(11, 158);
            this.dataGridViewTests.MultiSelect = false;
            this.dataGridViewTests.Name = "dataGridViewTests";
            this.dataGridViewTests.ReadOnly = true;
            this.dataGridViewTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTests.Size = new System.Drawing.Size(358, 129);
            this.dataGridViewTests.TabIndex = 10;
            // 
            // groupBoxTestType
            // 
            this.groupBoxTestType.Controls.Add(this.radioButtonLaboratory);
            this.groupBoxTestType.Controls.Add(this.radioButtonPhysical);
            this.groupBoxTestType.Location = new System.Drawing.Point(277, 12);
            this.groupBoxTestType.Name = "groupBoxTestType";
            this.groupBoxTestType.Size = new System.Drawing.Size(86, 78);
            this.groupBoxTestType.TabIndex = 13;
            this.groupBoxTestType.TabStop = false;
            this.groupBoxTestType.Text = "Test type";
            // 
            // radioButtonPhysical
            // 
            this.radioButtonPhysical.AutoSize = true;
            this.radioButtonPhysical.Checked = true;
            this.radioButtonPhysical.Location = new System.Drawing.Point(6, 19);
            this.radioButtonPhysical.Name = "radioButtonPhysical";
            this.radioButtonPhysical.Size = new System.Drawing.Size(64, 17);
            this.radioButtonPhysical.TabIndex = 0;
            this.radioButtonPhysical.TabStop = true;
            this.radioButtonPhysical.Text = "Physical";
            this.radioButtonPhysical.UseVisualStyleBackColor = true;
            this.radioButtonPhysical.CheckedChanged += new System.EventHandler(this.radioButtonPhysical_CheckedChanged);
            // 
            // radioButtonLaboratory
            // 
            this.radioButtonLaboratory.AutoSize = true;
            this.radioButtonLaboratory.Location = new System.Drawing.Point(6, 47);
            this.radioButtonLaboratory.Name = "radioButtonLaboratory";
            this.radioButtonLaboratory.Size = new System.Drawing.Size(75, 17);
            this.radioButtonLaboratory.TabIndex = 1;
            this.radioButtonLaboratory.Text = "Laboratory";
            this.radioButtonLaboratory.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(11, 108);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 26);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(124, 108);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 26);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(236, 108);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 26);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelledTextBoxName
            // 
            this.labelledTextBoxName.Input = "";
            this.labelledTextBoxName.Label = "Name";
            this.labelledTextBoxName.Location = new System.Drawing.Point(97, 29);
            this.labelledTextBoxName.Name = "labelledTextBoxName";
            this.labelledTextBoxName.Size = new System.Drawing.Size(174, 46);
            this.labelledTextBoxName.TabIndex = 12;
            // 
            // labelledTextBoxCode
            // 
            this.labelledTextBoxCode.Input = "";
            this.labelledTextBoxCode.Label = "Code";
            this.labelledTextBoxCode.Location = new System.Drawing.Point(12, 29);
            this.labelledTextBoxCode.Name = "labelledTextBoxCode";
            this.labelledTextBoxCode.Size = new System.Drawing.Size(79, 47);
            this.labelledTextBoxCode.TabIndex = 11;
            // 
            // TestDictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 299);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBoxTestType);
            this.Controls.Add(this.labelledTextBoxName);
            this.Controls.Add(this.labelledTextBoxCode);
            this.Controls.Add(this.dataGridViewTests);
            this.Name = "TestDictionaryForm";
            this.Text = "Test Dictionary";
            this.Load += new System.EventHandler(this.TestDictionaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).EndInit();
            this.groupBoxTestType.ResumeLayout(false);
            this.groupBoxTestType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTests;
        private Common.LabelledTextBox labelledTextBoxCode;
        private Common.LabelledTextBox labelledTextBoxName;
        private System.Windows.Forms.GroupBox groupBoxTestType;
        private System.Windows.Forms.RadioButton radioButtonLaboratory;
        private System.Windows.Forms.RadioButton radioButtonPhysical;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
    }
}