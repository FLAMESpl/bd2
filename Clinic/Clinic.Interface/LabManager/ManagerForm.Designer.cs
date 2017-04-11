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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AssignmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelledInputName = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputDate = new Clinic.Interface.Common.LabelledInput();
            this.buttonClear = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancelTest = new System.Windows.Forms.Button();
            this.buttonAcceptTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignmentDate,
            this.Name,
            this.Result,
            this.CommDate,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AssignmentDate
            // 
            this.AssignmentDate.HeaderText = "assignment date";
            this.AssignmentDate.Name = "AssignmentDate";
            this.AssignmentDate.ReadOnly = true;
            this.AssignmentDate.Width = 120;
            // 
            // Name
            // 
            this.Name.HeaderText = "name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.HeaderText = "result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // CommDate
            // 
            this.CommDate.HeaderText = "commence date";
            this.CommDate.Name = "CommDate";
            this.CommDate.ReadOnly = true;
            this.CommDate.Width = 120;
            // 
            // Status
            // 
            this.Status.HeaderText = "status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(592, 180);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelledInputName);
            this.flowLayoutPanel2.Controls.Add(this.labelledInputDate);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(22, 13);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(592, 63);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // labelledInputName
            // 
            this.labelledInputName.Input = "";
            this.labelledInputName.Label = "Name";
            this.labelledInputName.Location = new System.Drawing.Point(3, 3);
            this.labelledInputName.Name = "labelledInputName";
            this.labelledInputName.Size = new System.Drawing.Size(133, 44);
            this.labelledInputName.TabIndex = 1;
            // 
            // labelledInputDate
            // 
            this.labelledInputDate.Input = "";
            this.labelledInputDate.Label = "Date";
            this.labelledInputDate.Location = new System.Drawing.Point(142, 3);
            this.labelledInputDate.Name = "labelledInputDate";
            this.labelledInputDate.Size = new System.Drawing.Size(133, 44);
            this.labelledInputDate.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(3, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.buttonClear);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(22, 77);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(592, 40);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // buttonCancelTest
            // 
            this.buttonCancelTest.Location = new System.Drawing.Point(315, 320);
            this.buttonCancelTest.Name = "buttonCancelTest";
            this.buttonCancelTest.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelTest.TabIndex = 4;
            this.buttonCancelTest.Text = "Cancel Test";
            this.buttonCancelTest.UseVisualStyleBackColor = true;
            // 
            // buttonAcceptTest
            // 
            this.buttonAcceptTest.Location = new System.Drawing.Point(204, 320);
            this.buttonAcceptTest.Name = "buttonAcceptTest";
            this.buttonAcceptTest.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptTest.TabIndex = 5;
            this.buttonAcceptTest.Text = "Accept Test";
            this.buttonAcceptTest.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 388);
            this.Controls.Add(this.buttonAcceptTest);
            this.Controls.Add(this.buttonCancelTest);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Common.LabelledInput labelledInputName;
        private Common.LabelledInput labelledInputDate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button buttonCancelTest;
        private System.Windows.Forms.Button buttonAcceptTest;
    }
}