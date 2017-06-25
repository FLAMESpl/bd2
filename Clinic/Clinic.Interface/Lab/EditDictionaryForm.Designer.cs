namespace Clinic.Interface.Lab
{
    partial class EditDictionaryForm
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
            this.labelledTextBoxName = new Clinic.Interface.Common.LabelledTextBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.radioButtonPhysical = new System.Windows.Forms.RadioButton();
            this.radioButtonLaboratory = new System.Windows.Forms.RadioButton();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelledTextBoxCode = new Clinic.Interface.Common.LabelledTextBox();
            this.groupBoxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelledTextBoxName
            // 
            this.labelledTextBoxName.Input = "";
            this.labelledTextBoxName.Label = "Name";
            this.labelledTextBoxName.Location = new System.Drawing.Point(18, 60);
            this.labelledTextBoxName.Name = "labelledTextBoxName";
            this.labelledTextBoxName.Size = new System.Drawing.Size(246, 46);
            this.labelledTextBoxName.TabIndex = 1;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.radioButtonPhysical);
            this.groupBoxType.Controls.Add(this.radioButtonLaboratory);
            this.groupBoxType.Location = new System.Drawing.Point(18, 122);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(246, 74);
            this.groupBoxType.TabIndex = 2;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Test type";
            // 
            // radioButtonPhysical
            // 
            this.radioButtonPhysical.AutoSize = true;
            this.radioButtonPhysical.Location = new System.Drawing.Point(17, 19);
            this.radioButtonPhysical.Name = "radioButtonPhysical";
            this.radioButtonPhysical.Size = new System.Drawing.Size(64, 17);
            this.radioButtonPhysical.TabIndex = 1;
            this.radioButtonPhysical.TabStop = true;
            this.radioButtonPhysical.Text = "Physical";
            this.radioButtonPhysical.UseVisualStyleBackColor = true;
            // 
            // radioButtonLaboratory
            // 
            this.radioButtonLaboratory.AutoSize = true;
            this.radioButtonLaboratory.Location = new System.Drawing.Point(17, 42);
            this.radioButtonLaboratory.Name = "radioButtonLaboratory";
            this.radioButtonLaboratory.Size = new System.Drawing.Size(75, 17);
            this.radioButtonLaboratory.TabIndex = 0;
            this.radioButtonLaboratory.TabStop = true;
            this.radioButtonLaboratory.Text = "Laboratory";
            this.radioButtonLaboratory.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(35, 215);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(80, 22);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(150, 215);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 22);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelledTextBoxCode
            // 
            this.labelledTextBoxCode.Input = "";
            this.labelledTextBoxCode.Label = "Code";
            this.labelledTextBoxCode.Location = new System.Drawing.Point(18, 12);
            this.labelledTextBoxCode.Name = "labelledTextBoxCode";
            this.labelledTextBoxCode.Size = new System.Drawing.Size(246, 46);
            this.labelledTextBoxCode.TabIndex = 5;
            // 
            // EditDictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelledTextBoxCode);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.labelledTextBoxName);
            this.Name = "EditDictionaryForm";
            this.Text = "Edit dictionary";
            this.Load += new System.EventHandler(this.EditDictionaryForm_Load);
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Common.LabelledTextBox labelledTextBoxName;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.RadioButton radioButtonPhysical;
        private System.Windows.Forms.RadioButton radioButtonLaboratory;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private Common.LabelledTextBox labelledTextBoxCode;
    }
}