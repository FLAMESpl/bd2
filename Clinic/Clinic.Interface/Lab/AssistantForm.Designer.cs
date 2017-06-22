namespace Clinic.Interface.Lab
{
    partial class AssistantForm
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
            this.dataGridViewTests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTests
            // 
            this.dataGridViewTests.AllowUserToAddRows = false;
            this.dataGridViewTests.AllowUserToDeleteRows = false;
            this.dataGridViewTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTests.Location = new System.Drawing.Point(11, 15);
            this.dataGridViewTests.Name = "dataGridViewTests";
            this.dataGridViewTests.ReadOnly = true;
            this.dataGridViewTests.Size = new System.Drawing.Size(515, 237);
            this.dataGridViewTests.TabIndex = 0;
            // 
            // AssistantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 367);
            this.Controls.Add(this.dataGridViewTests);
            this.Name = "AssistantForm";
            this.Text = "AssistantForm";
            this.Load += new System.EventHandler(this.AssistantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTests;
    }
}