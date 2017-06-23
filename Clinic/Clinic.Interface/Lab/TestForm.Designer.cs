namespace Clinic.Interface.Lab
{
    partial class TestForm
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
            this.buttonAcceptTest = new System.Windows.Forms.Button();
            this.buttonCancelTest = new System.Windows.Forms.Button();
            this.labelledTextBoxComment = new Clinic.Interface.Common.LabelledTextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAcceptTest
            // 
            this.buttonAcceptTest.Location = new System.Drawing.Point(47, 90);
            this.buttonAcceptTest.Name = "buttonAcceptTest";
            this.buttonAcceptTest.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptTest.TabIndex = 0;
            this.buttonAcceptTest.Text = "Accept Test";
            this.buttonAcceptTest.UseVisualStyleBackColor = true;
            this.buttonAcceptTest.Click += new System.EventHandler(this.buttonAcceptTest_Click);
            // 
            // buttonCancelTest
            // 
            this.buttonCancelTest.Location = new System.Drawing.Point(150, 90);
            this.buttonCancelTest.Name = "buttonCancelTest";
            this.buttonCancelTest.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelTest.TabIndex = 1;
            this.buttonCancelTest.Text = "Cancel Test";
            this.buttonCancelTest.UseVisualStyleBackColor = true;
            this.buttonCancelTest.Click += new System.EventHandler(this.buttonCancelTest_Click);
            // 
            // labelledTextBoxComment
            // 
            this.labelledTextBoxComment.Input = "";
            this.labelledTextBoxComment.Label = "Manager commentary";
            this.labelledTextBoxComment.Location = new System.Drawing.Point(12, 24);
            this.labelledTextBoxComment.Name = "labelledTextBoxComment";
            this.labelledTextBoxComment.Size = new System.Drawing.Size(365, 60);
            this.labelledTextBoxComment.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(254, 90);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 149);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelledTextBoxComment);
            this.Controls.Add(this.buttonCancelTest);
            this.Controls.Add(this.buttonAcceptTest);
            this.Name = "TestForm";
            this.Text = "Laboratory test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAcceptTest;
        private System.Windows.Forms.Button buttonCancelTest;
        private Common.LabelledTextBox labelledTextBoxComment;
        private System.Windows.Forms.Button buttonBack;
    }
}