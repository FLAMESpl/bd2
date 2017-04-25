namespace Clinic.Interface.Registrator
{
    partial class PatientForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelPatientDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.labelledInputFirstName = new Clinic.Interface.Common.LabelledTextBox();
            this.labelledInputLastName = new Clinic.Interface.Common.LabelledTextBox();
            this.labelledInputEvidenceNumber = new Clinic.Interface.Common.LabelledTextBox();
            this.dataGridViewAddresses = new System.Windows.Forms.DataGridView();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceAddresses = new System.Windows.Forms.BindingSource(this.components);
            this.doneCancelDialog = new Clinic.Interface.Common.DoneCancelDialog();
            this.tableLayoutPanel.SuspendLayout();
            this.flowLayoutPanelPatientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAddresses)).BeginInit();
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
            this.tableLayoutPanel.Size = new System.Drawing.Size(450, 269);
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
            this.flowLayoutPanelPatientDetails.Size = new System.Drawing.Size(444, 50);
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
            this.dataGridViewAddresses.AutoGenerateColumns = false;
            this.dataGridViewAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddresses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseNumberDataGridViewTextBoxColumn,
            this.flatNumberDataGridViewTextBoxColumn});
            this.dataGridViewAddresses.DataSource = this.bindingSourceAddresses;
            this.dataGridViewAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAddresses.Location = new System.Drawing.Point(3, 59);
            this.dataGridViewAddresses.Name = "dataGridViewAddresses";
            this.dataGridViewAddresses.Size = new System.Drawing.Size(444, 168);
            this.dataGridViewAddresses.TabIndex = 1;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // houseNumberDataGridViewTextBoxColumn
            // 
            this.houseNumberDataGridViewTextBoxColumn.DataPropertyName = "HouseNumber";
            this.houseNumberDataGridViewTextBoxColumn.HeaderText = "HouseNumber";
            this.houseNumberDataGridViewTextBoxColumn.Name = "houseNumberDataGridViewTextBoxColumn";
            // 
            // flatNumberDataGridViewTextBoxColumn
            // 
            this.flatNumberDataGridViewTextBoxColumn.DataPropertyName = "FlatNumber";
            this.flatNumberDataGridViewTextBoxColumn.HeaderText = "FlatNumber";
            this.flatNumberDataGridViewTextBoxColumn.Name = "flatNumberDataGridViewTextBoxColumn";
            // 
            // bindingSourceAddresses
            // 
            this.bindingSourceAddresses.DataSource = typeof(Clinic.Data.Address);
            // 
            // doneCancelDialog
            // 
            this.doneCancelDialog.Dock = System.Windows.Forms.DockStyle.Right;
            this.doneCancelDialog.Location = new System.Drawing.Point(208, 233);
            this.doneCancelDialog.Name = "doneCancelDialog";
            this.doneCancelDialog.Size = new System.Drawing.Size(239, 33);
            this.doneCancelDialog.TabIndex = 2;
            // 
            // UpdatePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 269);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "UpdatePatientForm";
            this.Text = "Patient";
            this.tableLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanelPatientDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAddresses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPatientDetails;
        private Common.LabelledTextBox labelledInputFirstName;
        private Common.LabelledTextBox labelledInputLastName;
        private Common.LabelledTextBox labelledInputEvidenceNumber;
        private System.Windows.Forms.DataGridView dataGridViewAddresses;
        private Common.DoneCancelDialog doneCancelDialog;
        private System.Windows.Forms.BindingSource bindingSourceAddresses;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatNumberDataGridViewTextBoxColumn;
    }
}