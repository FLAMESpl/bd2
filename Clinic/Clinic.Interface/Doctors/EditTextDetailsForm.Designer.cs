namespace Clinic.Interface.Doctors
{
    partial class EditTextDetailsForm
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
            this.grpBoxTextBox = new System.Windows.Forms.GroupBox();
            this.txtBoxPhysicalResult = new System.Windows.Forms.TextBox();
            this.btnPhysicalTestResultCancel = new System.Windows.Forms.Button();
            this.btnPhysicalTestResultSave = new System.Windows.Forms.Button();
            this.grpBoxTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxTextBox
            // 
            this.grpBoxTextBox.Controls.Add(this.txtBoxPhysicalResult);
            this.grpBoxTextBox.Location = new System.Drawing.Point(12, 12);
            this.grpBoxTextBox.Name = "grpBoxTextBox";
            this.grpBoxTextBox.Size = new System.Drawing.Size(451, 170);
            this.grpBoxTextBox.TabIndex = 0;
            this.grpBoxTextBox.TabStop = false;
            this.grpBoxTextBox.Text = "Test Result:";
            // 
            // txtBoxPhysicalResult
            // 
            this.txtBoxPhysicalResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPhysicalResult.Location = new System.Drawing.Point(3, 16);
            this.txtBoxPhysicalResult.Multiline = true;
            this.txtBoxPhysicalResult.Name = "txtBoxPhysicalResult";
            this.txtBoxPhysicalResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxPhysicalResult.Size = new System.Drawing.Size(445, 151);
            this.txtBoxPhysicalResult.TabIndex = 2;
            this.txtBoxPhysicalResult.Text = "Physical test result";
            // 
            // btnPhysicalTestResultCancel
            // 
            this.btnPhysicalTestResultCancel.Location = new System.Drawing.Point(376, 210);
            this.btnPhysicalTestResultCancel.Name = "btnPhysicalTestResultCancel";
            this.btnPhysicalTestResultCancel.Size = new System.Drawing.Size(87, 34);
            this.btnPhysicalTestResultCancel.TabIndex = 1;
            this.btnPhysicalTestResultCancel.Text = "Cancel";
            this.btnPhysicalTestResultCancel.UseVisualStyleBackColor = true;
            this.btnPhysicalTestResultCancel.Click += new System.EventHandler(this.btnPhysicalTestResultCancel_Click);
            // 
            // btnPhysicalTestResultSave
            // 
            this.btnPhysicalTestResultSave.Location = new System.Drawing.Point(283, 210);
            this.btnPhysicalTestResultSave.Name = "btnPhysicalTestResultSave";
            this.btnPhysicalTestResultSave.Size = new System.Drawing.Size(87, 34);
            this.btnPhysicalTestResultSave.TabIndex = 2;
            this.btnPhysicalTestResultSave.Text = "Save";
            this.btnPhysicalTestResultSave.UseVisualStyleBackColor = true;
            this.btnPhysicalTestResultSave.Click += new System.EventHandler(this.btnPhysicalTestResultSave_Click);
            // 
            // EditTextDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 284);
            this.Controls.Add(this.btnPhysicalTestResultSave);
            this.Controls.Add(this.btnPhysicalTestResultCancel);
            this.Controls.Add(this.grpBoxTextBox);
            this.Name = "EditTextDetailsForm";
            this.Text = "Edit Details";
            this.grpBoxTextBox.ResumeLayout(false);
            this.grpBoxTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxTextBox;
        private System.Windows.Forms.TextBox txtBoxPhysicalResult;
        private System.Windows.Forms.Button btnPhysicalTestResultCancel;
        private System.Windows.Forms.Button btnPhysicalTestResultSave;
    }
}