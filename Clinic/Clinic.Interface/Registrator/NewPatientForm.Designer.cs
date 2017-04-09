namespace Clinic.Interface.Registrator
{
    partial class NewPatientForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelPatientDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.labelledInputFirstName = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputLastName = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputEvidenceNumber = new Clinic.Interface.Common.LabelledInput();
            this.dataGridViewAddresses = new System.Windows.Forms.DataGridView();
            this.doneCancelDialog = new Clinic.Interface.Common.DoneCancelDialog();
            this.tableLayoutPanel.SuspendLayout();
            this.flowLayoutPanelPatientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelPatientDetails, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewAddresses, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.doneCancelDialog, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(366, 269);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // flowLayoutPanelPatientDetails
            // 
            this.flowLayoutPanelPatientDetails.Controls.Add(this.labelledInputFirstName);
            this.flowLayoutPanelPatientDetails.Controls.Add(this.labelledInputLastName);
            this.flowLayoutPanelPatientDetails.Controls.Add(this.labelledInputEvidenceNumber);
            this.flowLayoutPanelPatientDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPatientDetails.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelPatientDetails.Name = "flowLayoutPanelPatientDetails";
            this.flowLayoutPanelPatientDetails.Size = new System.Drawing.Size(360, 50);
            this.flowLayoutPanelPatientDetails.TabIndex = 0;
            // 
            // labelledInputFirstName
            // 
            this.labelledInputFirstName.Input = "";
            this.labelledInputFirstName.Label = "First name";
            this.labelledInputFirstName.Location = new System.Drawing.Point(3, 3);
            this.labelledInputFirstName.Name = "labelledInputFirstName";
            this.labelledInputFirstName.Size = new System.Drawing.Size(112, 44);
            this.labelledInputFirstName.TabIndex = 0;
            // 
            // labelledInputLastName
            // 
            this.labelledInputLastName.Input = "";
            this.labelledInputLastName.Label = "Last name";
            this.labelledInputLastName.Location = new System.Drawing.Point(121, 3);
            this.labelledInputLastName.Name = "labelledInputLastName";
            this.labelledInputLastName.Size = new System.Drawing.Size(112, 44);
            this.labelledInputLastName.TabIndex = 1;
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
            // dataGridViewAddresses
            // 
            this.dataGridViewAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAddresses.Location = new System.Drawing.Point(3, 59);
            this.dataGridViewAddresses.Name = "dataGridViewAddresses";
            this.dataGridViewAddresses.Size = new System.Drawing.Size(360, 168);
            this.dataGridViewAddresses.TabIndex = 1;
            // 
            // doneCancelDialog
            // 
            this.doneCancelDialog.Dock = System.Windows.Forms.DockStyle.Right;
            this.doneCancelDialog.Location = new System.Drawing.Point(124, 233);
            this.doneCancelDialog.Name = "doneCancelDialog";
            this.doneCancelDialog.Size = new System.Drawing.Size(239, 33);
            this.doneCancelDialog.TabIndex = 2;
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 269);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "NewPatientForm";
            this.Text = "NewPatientForm";
            this.tableLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanelPatientDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPatientDetails;
        private Common.LabelledInput labelledInputFirstName;
        private Common.LabelledInput labelledInputLastName;
        private Common.LabelledInput labelledInputEvidenceNumber;
        private System.Windows.Forms.DataGridView dataGridViewAddresses;
        private Common.DoneCancelDialog doneCancelDialog;
    }
}