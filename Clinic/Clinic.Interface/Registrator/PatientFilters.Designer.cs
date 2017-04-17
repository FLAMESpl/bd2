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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelledInputPESEL = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputSurname = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputName = new Clinic.Interface.Common.LabelledInput();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Controls.Add(this.labelledInputPESEL, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.labelledInputSurname, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelledInputName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonClear, 3, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(456, 50);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonClear.Location = new System.Drawing.Point(409, 24);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(44, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelledInputPESEL
            // 
            this.labelledInputPESEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelledInputPESEL.Input = "";
            this.labelledInputPESEL.Label = "PESEL";
            this.labelledInputPESEL.Location = new System.Drawing.Point(309, 3);
            this.labelledInputPESEL.Name = "labelledInputPESEL";
            this.labelledInputPESEL.Size = new System.Drawing.Size(94, 44);
            this.labelledInputPESEL.TabIndex = 2;
            // 
            // labelledInputSurname
            // 
            this.labelledInputSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelledInputSurname.Input = "";
            this.labelledInputSurname.Label = "Surname";
            this.labelledInputSurname.Location = new System.Drawing.Point(156, 3);
            this.labelledInputSurname.Name = "labelledInputSurname";
            this.labelledInputSurname.Size = new System.Drawing.Size(147, 44);
            this.labelledInputSurname.TabIndex = 1;
            // 
            // labelledInputName
            // 
            this.labelledInputName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelledInputName.Input = "";
            this.labelledInputName.Label = "Name";
            this.labelledInputName.Location = new System.Drawing.Point(3, 3);
            this.labelledInputName.Name = "labelledInputName";
            this.labelledInputName.Size = new System.Drawing.Size(147, 44);
            this.labelledInputName.TabIndex = 0;
            // 
            // PatientFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "PatientFilters";
            this.Size = new System.Drawing.Size(456, 50);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Common.LabelledInput labelledInputPESEL;
        private Common.LabelledInput labelledInputSurname;
        private Common.LabelledInput labelledInputName;
        private System.Windows.Forms.Button buttonClear;
    }
}
