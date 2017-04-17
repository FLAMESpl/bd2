namespace Clinic.Interface.Registrator
{
    partial class PatientFilters
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelledInputName = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputSurname = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputPESEL = new Clinic.Interface.Common.LabelledInput();
            this.groupBox.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.tableLayoutPanel);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(397, 70);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Patient";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.Controls.Add(this.labelledInputPESEL, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.labelledInputSurname, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelledInputName, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(391, 51);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelledInputName
            // 
            this.labelledInputName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelledInputName.Input = "";
            this.labelledInputName.Label = "Name";
            this.labelledInputName.Location = new System.Drawing.Point(3, 3);
            this.labelledInputName.Name = "labelledInputName";
            this.labelledInputName.Size = new System.Drawing.Size(139, 44);
            this.labelledInputName.TabIndex = 0;
            // 
            // labelledInputSurname
            // 
            this.labelledInputSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelledInputSurname.Input = "";
            this.labelledInputSurname.Label = "Surname";
            this.labelledInputSurname.Location = new System.Drawing.Point(148, 3);
            this.labelledInputSurname.Name = "labelledInputSurname";
            this.labelledInputSurname.Size = new System.Drawing.Size(139, 44);
            this.labelledInputSurname.TabIndex = 1;
            // 
            // labelledInputPESEL
            // 
            this.labelledInputPESEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelledInputPESEL.Input = "";
            this.labelledInputPESEL.Label = "PESEL";
            this.labelledInputPESEL.Location = new System.Drawing.Point(293, 3);
            this.labelledInputPESEL.Name = "labelledInputPESEL";
            this.labelledInputPESEL.Size = new System.Drawing.Size(95, 44);
            this.labelledInputPESEL.TabIndex = 2;
            // 
            // PatientsFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "PatientsFilters";
            this.Size = new System.Drawing.Size(397, 70);
            this.groupBox.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Common.LabelledInput labelledInputPESEL;
        private Common.LabelledInput labelledInputSurname;
        private Common.LabelledInput labelledInputName;
    }
}
