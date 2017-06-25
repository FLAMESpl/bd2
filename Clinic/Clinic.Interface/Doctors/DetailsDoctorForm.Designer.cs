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
            this.btnDoctorReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBoxDetailsDoctorDiagnosis = new System.Windows.Forms.GroupBox();
            this.txtBoxDetailsDiagnosis = new System.Windows.Forms.TextBox();
            this.grpBoxDetailsDescription = new System.Windows.Forms.GroupBox();
            this.txtBoxDetailsDescription = new System.Windows.Forms.TextBox();
            this.lblInfoPatientData = new System.Windows.Forms.Label();
            this.lblDetailsPatientPESEL = new System.Windows.Forms.Label();
            this.lblDetailsPatientSurname = new System.Windows.Forms.Label();
            this.lblDetailsPatientName = new System.Windows.Forms.Label();
            this.btnSaveDiagnosis = new System.Windows.Forms.Button();
            this.btnTestDetails = new System.Windows.Forms.Button();
            this.lblInfoVisitDate = new System.Windows.Forms.Label();
            this.lblDetailsVisitDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpBoxDetailsDoctorDiagnosis.SuspendLayout();
            this.grpBoxDetailsDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoctorReturn
            // 
            this.btnDoctorReturn.Location = new System.Drawing.Point(367, 440);
            this.btnDoctorReturn.Name = "btnDoctorReturn";
            this.btnDoctorReturn.Size = new System.Drawing.Size(128, 32);
            this.btnDoctorReturn.TabIndex = 2;
            this.btnDoctorReturn.Text = "Go back to all Visits...";
            this.btnDoctorReturn.UseVisualStyleBackColor = true;
            this.btnDoctorReturn.Click += new System.EventHandler(this.btnDoctorReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDetailsVisitDate);
            this.groupBox1.Controls.Add(this.lblInfoVisitDate);
            this.groupBox1.Controls.Add(this.grpBoxDetailsDoctorDiagnosis);
            this.groupBox1.Controls.Add(this.grpBoxDetailsDescription);
            this.groupBox1.Controls.Add(this.lblInfoPatientData);
            this.groupBox1.Controls.Add(this.lblDetailsPatientPESEL);
            this.groupBox1.Controls.Add(this.lblDetailsPatientSurname);
            this.groupBox1.Controls.Add(this.lblDetailsPatientName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 401);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visit details";
            // 
            // grpBoxDetailsDoctorDiagnosis
            // 
            this.grpBoxDetailsDoctorDiagnosis.Controls.Add(this.txtBoxDetailsDiagnosis);
            this.grpBoxDetailsDoctorDiagnosis.Location = new System.Drawing.Point(6, 235);
            this.grpBoxDetailsDoctorDiagnosis.Name = "grpBoxDetailsDoctorDiagnosis";
            this.grpBoxDetailsDoctorDiagnosis.Size = new System.Drawing.Size(470, 160);
            this.grpBoxDetailsDoctorDiagnosis.TabIndex = 14;
            this.grpBoxDetailsDoctorDiagnosis.TabStop = false;
            this.grpBoxDetailsDoctorDiagnosis.Text = "Doctor Diagnosis:";
            // 
            // txtBoxDetailsDiagnosis
            // 
            this.txtBoxDetailsDiagnosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxDetailsDiagnosis.Location = new System.Drawing.Point(3, 16);
            this.txtBoxDetailsDiagnosis.Multiline = true;
            this.txtBoxDetailsDiagnosis.Name = "txtBoxDetailsDiagnosis";
            this.txtBoxDetailsDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDetailsDiagnosis.Size = new System.Drawing.Size(464, 141);
            this.txtBoxDetailsDiagnosis.TabIndex = 12;
            this.txtBoxDetailsDiagnosis.Text = "To be filled...";
            // 
            // grpBoxDetailsDescription
            // 
            this.grpBoxDetailsDescription.Controls.Add(this.txtBoxDetailsDescription);
            this.grpBoxDetailsDescription.Location = new System.Drawing.Point(6, 80);
            this.grpBoxDetailsDescription.Name = "grpBoxDetailsDescription";
            this.grpBoxDetailsDescription.Size = new System.Drawing.Size(470, 149);
            this.grpBoxDetailsDescription.TabIndex = 13;
            this.grpBoxDetailsDescription.TabStop = false;
            this.grpBoxDetailsDescription.Text = "Registry Description:";
            // 
            // txtBoxDetailsDescription
            // 
            this.txtBoxDetailsDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxDetailsDescription.Location = new System.Drawing.Point(3, 16);
            this.txtBoxDetailsDescription.Multiline = true;
            this.txtBoxDetailsDescription.Name = "txtBoxDetailsDescription";
            this.txtBoxDetailsDescription.ReadOnly = true;
            this.txtBoxDetailsDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDetailsDescription.Size = new System.Drawing.Size(464, 130);
            this.txtBoxDetailsDescription.TabIndex = 1;
            this.txtBoxDetailsDescription.Text = "Empty";
            // 
            // lblInfoPatientData
            // 
            this.lblInfoPatientData.AutoSize = true;
            this.lblInfoPatientData.Location = new System.Drawing.Point(6, 16);
            this.lblInfoPatientData.Name = "lblInfoPatientData";
            this.lblInfoPatientData.Size = new System.Drawing.Size(67, 13);
            this.lblInfoPatientData.TabIndex = 12;
            this.lblInfoPatientData.Text = "Patient data:";
            // 
            // lblDetailsPatientPESEL
            // 
            this.lblDetailsPatientPESEL.AutoSize = true;
            this.lblDetailsPatientPESEL.Location = new System.Drawing.Point(6, 58);
            this.lblDetailsPatientPESEL.Name = "lblDetailsPatientPESEL";
            this.lblDetailsPatientPESEL.Size = new System.Drawing.Size(77, 13);
            this.lblDetailsPatientPESEL.TabIndex = 5;
            this.lblDetailsPatientPESEL.Text = "Patient PESEL";
            // 
            // lblDetailsPatientSurname
            // 
            this.lblDetailsPatientSurname.AutoSize = true;
            this.lblDetailsPatientSurname.Location = new System.Drawing.Point(6, 45);
            this.lblDetailsPatientSurname.Name = "lblDetailsPatientSurname";
            this.lblDetailsPatientSurname.Size = new System.Drawing.Size(85, 13);
            this.lblDetailsPatientSurname.TabIndex = 4;
            this.lblDetailsPatientSurname.Text = "Patient Surname";
            // 
            // lblDetailsPatientName
            // 
            this.lblDetailsPatientName.AutoSize = true;
            this.lblDetailsPatientName.Location = new System.Drawing.Point(6, 32);
            this.lblDetailsPatientName.Name = "lblDetailsPatientName";
            this.lblDetailsPatientName.Size = new System.Drawing.Size(71, 13);
            this.lblDetailsPatientName.TabIndex = 0;
            this.lblDetailsPatientName.Text = "Patient Name";
            // 
            // btnSaveDiagnosis
            // 
            this.btnSaveDiagnosis.Location = new System.Drawing.Point(49, 435);
            this.btnSaveDiagnosis.Name = "btnSaveDiagnosis";
            this.btnSaveDiagnosis.Size = new System.Drawing.Size(141, 42);
            this.btnSaveDiagnosis.TabIndex = 2;
            this.btnSaveDiagnosis.Text = "Save Diagnosis";
            this.btnSaveDiagnosis.UseVisualStyleBackColor = true;
            this.btnSaveDiagnosis.Click += new System.EventHandler(this.btnSaveDiagnosis_Click);
            // 
            // btnTestDetails
            // 
            this.btnTestDetails.Location = new System.Drawing.Point(233, 440);
            this.btnTestDetails.Name = "btnTestDetails";
            this.btnTestDetails.Size = new System.Drawing.Size(128, 32);
            this.btnTestDetails.TabIndex = 9;
            this.btnTestDetails.Text = "Show/Edit tests...";
            this.btnTestDetails.UseVisualStyleBackColor = true;
            this.btnTestDetails.Click += new System.EventHandler(this.btnTestDetails_Click);
            // 
            // lblInfoVisitDate
            // 
            this.lblInfoVisitDate.AutoSize = true;
            this.lblInfoVisitDate.Location = new System.Drawing.Point(141, 16);
            this.lblInfoVisitDate.Name = "lblInfoVisitDate";
            this.lblInfoVisitDate.Size = new System.Drawing.Size(55, 13);
            this.lblInfoVisitDate.TabIndex = 15;
            this.lblInfoVisitDate.Text = "Visit Date:";
            // 
            // lblDetailsVisitDate
            // 
            this.lblDetailsVisitDate.AutoSize = true;
            this.lblDetailsVisitDate.Location = new System.Drawing.Point(144, 31);
            this.lblDetailsVisitDate.Name = "lblDetailsVisitDate";
            this.lblDetailsVisitDate.Size = new System.Drawing.Size(36, 13);
            this.lblDetailsVisitDate.TabIndex = 16;
            this.lblDetailsVisitDate.Text = "Empty";
            // 
            // DetailsDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 517);
            this.Controls.Add(this.btnTestDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDoctorReturn);
            this.Controls.Add(this.btnSaveDiagnosis);
            this.Name = "DetailsDoctorForm";
            this.Text = "Visit Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetailsDoctorForm_FormClosing);
            this.Load += new System.EventHandler(this.DetailsDoctorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxDetailsDoctorDiagnosis.ResumeLayout(false);
            this.grpBoxDetailsDoctorDiagnosis.PerformLayout();
            this.grpBoxDetailsDescription.ResumeLayout(false);
            this.grpBoxDetailsDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDoctorReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDetailsPatientName;
        private System.Windows.Forms.Button btnSaveDiagnosis;
        private System.Windows.Forms.Label lblDetailsPatientPESEL;
        private System.Windows.Forms.Label lblDetailsPatientSurname;
        private System.Windows.Forms.Button btnTestDetails;
        private System.Windows.Forms.Label lblInfoPatientData;
        private System.Windows.Forms.GroupBox grpBoxDetailsDescription;
        private System.Windows.Forms.GroupBox grpBoxDetailsDoctorDiagnosis;
        private System.Windows.Forms.TextBox txtBoxDetailsDiagnosis;
        private System.Windows.Forms.TextBox txtBoxDetailsDescription;
        private System.Windows.Forms.Label lblDetailsVisitDate;
        private System.Windows.Forms.Label lblInfoVisitDate;
    }
}