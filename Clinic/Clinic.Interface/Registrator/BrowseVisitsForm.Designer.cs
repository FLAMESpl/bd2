namespace Clinic.Interface.Registrator
{
    partial class BrowseVisitsForm
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelPatient = new System.Windows.Forms.FlowLayoutPanel();
            this.labelledInputPatientName = new Clinic.Interface.Common.LabelledInput();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelDoctor = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelledInputPatientLastName = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputEvidenceNumber = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputDoctorFirstName = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputDoctorLastName = new Clinic.Interface.Common.LabelledInput();
            this.dataGridViewVisits = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelVisitDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.labelledInputStatus = new Clinic.Interface.Common.LabelledInput();
            this.labelledInput1 = new Clinic.Interface.Common.LabelledInput();
            this.labelledInput2 = new Clinic.Interface.Common.LabelledInput();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            this.flowLayoutPanelPatient.SuspendLayout();
            this.groupBoxDoctor.SuspendLayout();
            this.flowLayoutPanelDoctor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).BeginInit();
            this.flowLayoutPanelVisitDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.24146F));
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxPatient, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxDoctor, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewVisits, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(494, 390);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.flowLayoutPanelPatient);
            this.groupBoxPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPatient.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(488, 67);
            this.groupBoxPatient.TabIndex = 0;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // flowLayoutPanelPatient
            // 
            this.flowLayoutPanelPatient.Controls.Add(this.labelledInputPatientName);
            this.flowLayoutPanelPatient.Controls.Add(this.labelledInputPatientLastName);
            this.flowLayoutPanelPatient.Controls.Add(this.labelledInputEvidenceNumber);
            this.flowLayoutPanelPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPatient.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelPatient.Name = "flowLayoutPanelPatient";
            this.flowLayoutPanelPatient.Size = new System.Drawing.Size(482, 48);
            this.flowLayoutPanelPatient.TabIndex = 0;
            // 
            // labelledInputPatientName
            // 
            this.labelledInputPatientName.Input = "";
            this.labelledInputPatientName.Label = "First name";
            this.labelledInputPatientName.Location = new System.Drawing.Point(3, 3);
            this.labelledInputPatientName.Name = "labelledInputPatientName";
            this.labelledInputPatientName.Size = new System.Drawing.Size(112, 44);
            this.labelledInputPatientName.TabIndex = 0;
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.flowLayoutPanelDoctor);
            this.groupBoxDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDoctor.Location = new System.Drawing.Point(3, 76);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(488, 71);
            this.groupBoxDoctor.TabIndex = 1;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "Doctor";
            // 
            // flowLayoutPanelDoctor
            // 
            this.flowLayoutPanelDoctor.Controls.Add(this.labelledInputDoctorFirstName);
            this.flowLayoutPanelDoctor.Controls.Add(this.labelledInputDoctorLastName);
            this.flowLayoutPanelDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDoctor.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelDoctor.Name = "flowLayoutPanelDoctor";
            this.flowLayoutPanelDoctor.Size = new System.Drawing.Size(482, 52);
            this.flowLayoutPanelDoctor.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanelVisitDetails);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visit details";
            // 
            // labelledInputPatientLastName
            // 
            this.labelledInputPatientLastName.Input = "";
            this.labelledInputPatientLastName.Label = "Last name";
            this.labelledInputPatientLastName.Location = new System.Drawing.Point(121, 3);
            this.labelledInputPatientLastName.Name = "labelledInputPatientLastName";
            this.labelledInputPatientLastName.Size = new System.Drawing.Size(112, 44);
            this.labelledInputPatientLastName.TabIndex = 1;
            // 
            // labelledInputEvidenceNumber
            // 
            this.labelledInputEvidenceNumber.Input = "";
            this.labelledInputEvidenceNumber.Label = "Evidence number";
            this.labelledInputEvidenceNumber.Location = new System.Drawing.Point(239, 3);
            this.labelledInputEvidenceNumber.Name = "labelledInputEvidenceNumber";
            this.labelledInputEvidenceNumber.Size = new System.Drawing.Size(112, 44);
            this.labelledInputEvidenceNumber.TabIndex = 2;
            // 
            // labelledInputDoctorFirstName
            // 
            this.labelledInputDoctorFirstName.Input = "";
            this.labelledInputDoctorFirstName.Label = "First name";
            this.labelledInputDoctorFirstName.Location = new System.Drawing.Point(3, 3);
            this.labelledInputDoctorFirstName.Name = "labelledInputDoctorFirstName";
            this.labelledInputDoctorFirstName.Size = new System.Drawing.Size(112, 44);
            this.labelledInputDoctorFirstName.TabIndex = 2;
            // 
            // labelledInputDoctorLastName
            // 
            this.labelledInputDoctorLastName.Input = "";
            this.labelledInputDoctorLastName.Label = "Last name";
            this.labelledInputDoctorLastName.Location = new System.Drawing.Point(121, 3);
            this.labelledInputDoctorLastName.Name = "labelledInputDoctorLastName";
            this.labelledInputDoctorLastName.Size = new System.Drawing.Size(112, 44);
            this.labelledInputDoctorLastName.TabIndex = 3;
            // 
            // dataGridViewVisits
            // 
            this.dataGridViewVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVisits.Location = new System.Drawing.Point(3, 228);
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.Size = new System.Drawing.Size(488, 159);
            this.dataGridViewVisits.TabIndex = 3;
            // 
            // flowLayoutPanelVisitDetails
            // 
            this.flowLayoutPanelVisitDetails.Controls.Add(this.labelledInputStatus);
            this.flowLayoutPanelVisitDetails.Controls.Add(this.labelledInput1);
            this.flowLayoutPanelVisitDetails.Controls.Add(this.labelledInput2);
            this.flowLayoutPanelVisitDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelVisitDetails.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelVisitDetails.Name = "flowLayoutPanelVisitDetails";
            this.flowLayoutPanelVisitDetails.Size = new System.Drawing.Size(482, 50);
            this.flowLayoutPanelVisitDetails.TabIndex = 0;
            // 
            // labelledInputStatus
            // 
            this.labelledInputStatus.Input = "";
            this.labelledInputStatus.Label = "Status";
            this.labelledInputStatus.Location = new System.Drawing.Point(3, 3);
            this.labelledInputStatus.Name = "labelledInputStatus";
            this.labelledInputStatus.Size = new System.Drawing.Size(112, 44);
            this.labelledInputStatus.TabIndex = 0;
            // 
            // labelledInput1
            // 
            this.labelledInput1.Input = "";
            this.labelledInput1.Label = "Registration date";
            this.labelledInput1.Location = new System.Drawing.Point(121, 3);
            this.labelledInput1.Name = "labelledInput1";
            this.labelledInput1.Size = new System.Drawing.Size(112, 44);
            this.labelledInput1.TabIndex = 1;
            // 
            // labelledInput2
            // 
            this.labelledInput2.Input = "";
            this.labelledInput2.Label = "Visit date";
            this.labelledInput2.Location = new System.Drawing.Point(239, 3);
            this.labelledInput2.Name = "labelledInput2";
            this.labelledInput2.Size = new System.Drawing.Size(112, 44);
            this.labelledInput2.TabIndex = 2;
            // 
            // BrowseVisitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 390);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "BrowseVisitsForm";
            this.Text = "BrowseVisitsForm";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.groupBoxPatient.ResumeLayout(false);
            this.flowLayoutPanelPatient.ResumeLayout(false);
            this.groupBoxDoctor.ResumeLayout(false);
            this.flowLayoutPanelDoctor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).EndInit();
            this.flowLayoutPanelVisitDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPatient;
        private Common.LabelledInput labelledInputPatientName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDoctor;
        private Common.LabelledInput labelledInputPatientLastName;
        private Common.LabelledInput labelledInputEvidenceNumber;
        private Common.LabelledInput labelledInputDoctorFirstName;
        private Common.LabelledInput labelledInputDoctorLastName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVisitDetails;
        private System.Windows.Forms.DataGridView dataGridViewVisits;
        private Common.LabelledInput labelledInputStatus;
        private Common.LabelledInput labelledInput1;
        private Common.LabelledInput labelledInput2;
    }
}