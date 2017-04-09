namespace Clinic.Interface.Registrator
{
    partial class MatchingPatients
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelInputs = new System.Windows.Forms.FlowLayoutPanel();
            this.labelledInputFirstName = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputLastName = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputEvidenceNumber = new Clinic.Interface.Common.LabelledInput();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.flowLayoutPanelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelInputs, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.buttonAddPatient, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.38279F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(476, 337);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // flowLayoutPanelInputs
            // 
            this.flowLayoutPanelInputs.Controls.Add(this.labelledInputFirstName);
            this.flowLayoutPanelInputs.Controls.Add(this.labelledInputLastName);
            this.flowLayoutPanelInputs.Controls.Add(this.labelledInputEvidenceNumber);
            this.flowLayoutPanelInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelInputs.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelInputs.Name = "flowLayoutPanelInputs";
            this.flowLayoutPanelInputs.Size = new System.Drawing.Size(470, 49);
            this.flowLayoutPanelInputs.TabIndex = 0;
            // 
            // labelledInputFirstName
            // 
            this.labelledInputFirstName.Input = "";
            this.labelledInputFirstName.Label = "First name";
            this.labelledInputFirstName.Location = new System.Drawing.Point(3, 3);
            this.labelledInputFirstName.Name = "labelledInputFirstName";
            this.labelledInputFirstName.Size = new System.Drawing.Size(133, 44);
            this.labelledInputFirstName.TabIndex = 0;
            // 
            // labelledInputLastName
            // 
            this.labelledInputLastName.Input = "";
            this.labelledInputLastName.Label = "Last name";
            this.labelledInputLastName.Location = new System.Drawing.Point(142, 3);
            this.labelledInputLastName.Name = "labelledInputLastName";
            this.labelledInputLastName.Size = new System.Drawing.Size(143, 44);
            this.labelledInputLastName.TabIndex = 1;
            // 
            // labelledInputEvidenceNumber
            // 
            this.labelledInputEvidenceNumber.Input = "";
            this.labelledInputEvidenceNumber.Label = "Evidence number";
            this.labelledInputEvidenceNumber.Location = new System.Drawing.Point(291, 3);
            this.labelledInputEvidenceNumber.Name = "labelledInputEvidenceNumber";
            this.labelledInputEvidenceNumber.Size = new System.Drawing.Size(149, 44);
            this.labelledInputEvidenceNumber.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 236);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAddPatient.Location = new System.Drawing.Point(3, 58);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(122, 34);
            this.buttonAddPatient.TabIndex = 3;
            this.buttonAddPatient.Text = "Add patient";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // MatchingPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "MatchingPatients";
            this.Size = new System.Drawing.Size(476, 337);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.flowLayoutPanelInputs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInputs;
        private Common.LabelledInput labelledInputFirstName;
        private Common.LabelledInput labelledInputLastName;
        private Common.LabelledInput labelledInputEvidenceNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddPatient;
    }
}
