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
            this.groupBoxText = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // buttonAcceptTest
            // 
            this.buttonAcceptTest.Location = new System.Drawing.Point(87, 220);
            this.buttonAcceptTest.Name = "buttonAcceptTest";
            this.buttonAcceptTest.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptTest.TabIndex = 0;
            this.buttonAcceptTest.Text = "Accept Test";
            this.buttonAcceptTest.UseVisualStyleBackColor = true;
            // 
            // buttonCancelTest
            // 
            this.buttonCancelTest.Location = new System.Drawing.Point(279, 220);
            this.buttonCancelTest.Name = "buttonCancelTest";
            this.buttonCancelTest.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelTest.TabIndex = 1;
            this.buttonCancelTest.Text = "Cancel Test";
            this.buttonCancelTest.UseVisualStyleBackColor = true;
            // 
            // labelledTextBoxComment
            // 
            this.labelledTextBoxComment.Input = "";
            this.labelledTextBoxComment.Label = "Manager commentary";
            this.labelledTextBoxComment.Location = new System.Drawing.Point(44, 154);
            this.labelledTextBoxComment.Name = "labelledTextBoxComment";
            this.labelledTextBoxComment.Size = new System.Drawing.Size(365, 60);
            this.labelledTextBoxComment.TabIndex = 2;
            // 
            // groupBoxText
            // 
            this.groupBoxText.Location = new System.Drawing.Point(23, 17);
            this.groupBoxText.Name = "groupBoxText";
            this.groupBoxText.Size = new System.Drawing.Size(407, 121);
            this.groupBoxText.TabIndex = 3;
            this.groupBoxText.TabStop = false;
            this.groupBoxText.Text = "Test";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 288);
            this.Controls.Add(this.groupBoxText);
            this.Controls.Add(this.labelledTextBoxComment);
            this.Controls.Add(this.buttonCancelTest);
            this.Controls.Add(this.buttonAcceptTest);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAcceptTest;
        private System.Windows.Forms.Button buttonCancelTest;
        private Common.LabelledTextBox labelledTextBoxComment;
        private System.Windows.Forms.GroupBox groupBoxText;
    }
}