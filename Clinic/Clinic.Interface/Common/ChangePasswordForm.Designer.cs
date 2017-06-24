namespace Clinic.Interface.Common
{
    partial class ChangePasswordForm
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
            this.labelledTextBox = new Clinic.Interface.Common.LabelledTextBox();
            this.doneCancelDialog = new Clinic.Interface.Common.DoneCancelDialog();
            this.SuspendLayout();
            // 
            // labelledTextBox
            // 
            this.labelledTextBox.Input = "";
            this.labelledTextBox.Label = "New password:";
            this.labelledTextBox.Location = new System.Drawing.Point(13, 13);
            this.labelledTextBox.Name = "labelledTextBox";
            this.labelledTextBox.Size = new System.Drawing.Size(259, 44);
            this.labelledTextBox.TabIndex = 0;
            // 
            // doneCancelDialog
            // 
            this.doneCancelDialog.Location = new System.Drawing.Point(13, 64);
            this.doneCancelDialog.Name = "doneCancelDialog";
            this.doneCancelDialog.Size = new System.Drawing.Size(259, 30);
            this.doneCancelDialog.TabIndex = 1;
            this.doneCancelDialog.Cancel += new System.EventHandler(this.doneCancelDialog_Cancel);
            this.doneCancelDialog.Done += new System.EventHandler(this.doneCancelDialog_Done);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.doneCancelDialog);
            this.Controls.Add(this.labelledTextBox);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);

        }

        #endregion

        private LabelledTextBox labelledTextBox;
        private DoneCancelDialog doneCancelDialog;
    }
}