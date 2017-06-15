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
            this.btnDoctorCancelVisit = new System.Windows.Forms.Button();
            this.btnDoctorFinalizeVisit = new System.Windows.Forms.Button();
            this.btnDoctorReturn = new System.Windows.Forms.Button();
            this.lblChooseInfo = new System.Windows.Forms.Label();
            this.btnDoctorAssignTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoctorCancelVisit
            // 
            this.btnDoctorCancelVisit.Location = new System.Drawing.Point(146, 40);
            this.btnDoctorCancelVisit.Name = "btnDoctorCancelVisit";
            this.btnDoctorCancelVisit.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorCancelVisit.TabIndex = 0;
            this.btnDoctorCancelVisit.Text = "Cancel Visit";
            this.btnDoctorCancelVisit.UseVisualStyleBackColor = true;
            this.btnDoctorCancelVisit.Click += new System.EventHandler(this.btnDoctorCancelVisit_Click);
            // 
            // btnDoctorFinalizeVisit
            // 
            this.btnDoctorFinalizeVisit.Location = new System.Drawing.Point(12, 40);
            this.btnDoctorFinalizeVisit.Name = "btnDoctorFinalizeVisit";
            this.btnDoctorFinalizeVisit.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorFinalizeVisit.TabIndex = 1;
            this.btnDoctorFinalizeVisit.Text = "Finalize Visit";
            this.btnDoctorFinalizeVisit.UseVisualStyleBackColor = true;
            this.btnDoctorFinalizeVisit.Click += new System.EventHandler(this.btnDoctorFinalizeVisit_Click);
            // 
            // btnDoctorReturn
            // 
            this.btnDoctorReturn.Location = new System.Drawing.Point(346, 40);
            this.btnDoctorReturn.Name = "btnDoctorReturn";
            this.btnDoctorReturn.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorReturn.TabIndex = 2;
            this.btnDoctorReturn.Text = "Go back to all Visits...";
            this.btnDoctorReturn.UseVisualStyleBackColor = true;
            this.btnDoctorReturn.Click += new System.EventHandler(this.btnDoctorReturn_Click);
            // 
            // lblChooseInfo
            // 
            this.lblChooseInfo.AutoSize = true;
            this.lblChooseInfo.Location = new System.Drawing.Point(13, 9);
            this.lblChooseInfo.Name = "lblChooseInfo";
            this.lblChooseInfo.Size = new System.Drawing.Size(132, 13);
            this.lblChooseInfo.TabIndex = 3;
            this.lblChooseInfo.Text = "Choose an action for  visit:";
            // 
            // btnDoctorAssignTest
            // 
            this.btnDoctorAssignTest.Location = new System.Drawing.Point(12, 78);
            this.btnDoctorAssignTest.Name = "btnDoctorAssignTest";
            this.btnDoctorAssignTest.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorAssignTest.TabIndex = 4;
            this.btnDoctorAssignTest.Text = "Assign a lab test";
            this.btnDoctorAssignTest.UseVisualStyleBackColor = true;
            this.btnDoctorAssignTest.Click += new System.EventHandler(this.btnDoctorAssignLabTest);
            // 
            // DetailsDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 152);
            this.Controls.Add(this.btnDoctorAssignTest);
            this.Controls.Add(this.lblChooseInfo);
            this.Controls.Add(this.btnDoctorReturn);
            this.Controls.Add(this.btnDoctorFinalizeVisit);
            this.Controls.Add(this.btnDoctorCancelVisit);
            this.Name = "DetailsDoctorForm";
            this.Text = "DetailsDoctorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoctorCancelVisit;
        private System.Windows.Forms.Button btnDoctorFinalizeVisit;
        private System.Windows.Forms.Button btnDoctorReturn;
        private System.Windows.Forms.Label lblChooseInfo;
        private System.Windows.Forms.Button btnDoctorAssignTest;
    }
}