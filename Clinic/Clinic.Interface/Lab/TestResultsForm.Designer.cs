namespace Clinic.Interface.Lab
{
    partial class TestResultsForm
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
            this.labelledTextBoxResult = new Clinic.Interface.Common.LabelledTextBox();
            this.buttonExecuteTest = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelledTextBoxResult
            // 
            this.labelledTextBoxResult.Input = "";
            this.labelledTextBoxResult.Label = "Test result";
            this.labelledTextBoxResult.Location = new System.Drawing.Point(12, 28);
            this.labelledTextBoxResult.Name = "labelledTextBoxResult";
            this.labelledTextBoxResult.Size = new System.Drawing.Size(326, 62);
            this.labelledTextBoxResult.TabIndex = 0;
            // 
            // buttonExecuteTest
            // 
            this.buttonExecuteTest.Location = new System.Drawing.Point(91, 90);
            this.buttonExecuteTest.Name = "buttonExecuteTest";
            this.buttonExecuteTest.Size = new System.Drawing.Size(67, 25);
            this.buttonExecuteTest.TabIndex = 1;
            this.buttonExecuteTest.Text = "Ok";
            this.buttonExecuteTest.UseVisualStyleBackColor = true;
            this.buttonExecuteTest.Click += new System.EventHandler(this.buttonExecuteTest_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(193, 92);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(70, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // TestResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 140);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonExecuteTest);
            this.Controls.Add(this.labelledTextBoxResult);
            this.Name = "TestResultsForm";
            this.Text = "TestResultsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Common.LabelledTextBox labelledTextBoxResult;
        private System.Windows.Forms.Button buttonExecuteTest;
        private System.Windows.Forms.Button buttonBack;
    }
}