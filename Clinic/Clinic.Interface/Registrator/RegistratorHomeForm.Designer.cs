namespace Clinic.Interface.Registrator
{
    partial class RegistratorHomeForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.groupBoxPatients = new System.Windows.Forms.GroupBox();
            this.matchingPatients1 = new Clinic.Interface.Registrator.MatchingPatients();
            this.matchingDoctors1 = new Clinic.Interface.Registrator.MatchingDoctors();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxDoctor.SuspendLayout();
            this.groupBoxPatients.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.1831F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.8169F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(731, 276);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 469F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBoxDoctor, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxPatients, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(933, 193);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.matchingDoctors1);
            this.groupBoxDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDoctor.Location = new System.Drawing.Point(472, 3);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(458, 187);
            this.groupBoxDoctor.TabIndex = 1;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "Doctor";
            // 
            // groupBoxPatients
            // 
            this.groupBoxPatients.Controls.Add(this.matchingPatients1);
            this.groupBoxPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPatients.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPatients.Name = "groupBoxPatients";
            this.groupBoxPatients.Size = new System.Drawing.Size(463, 187);
            this.groupBoxPatients.TabIndex = 0;
            this.groupBoxPatients.TabStop = false;
            this.groupBoxPatients.Text = "Patient";
            // 
            // matchingPatients1
            // 
            this.matchingPatients1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchingPatients1.Location = new System.Drawing.Point(3, 16);
            this.matchingPatients1.Name = "matchingPatients1";
            this.matchingPatients1.Size = new System.Drawing.Size(457, 168);
            this.matchingPatients1.TabIndex = 0;
            // 
            // matchingDoctors1
            // 
            this.matchingDoctors1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchingDoctors1.Location = new System.Drawing.Point(3, 16);
            this.matchingDoctors1.Name = "matchingDoctors1";
            this.matchingDoctors1.Size = new System.Drawing.Size(452, 168);
            this.matchingDoctors1.TabIndex = 0;
            // 
            // RegistratorHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 276);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RegistratorHomeForm";
            this.Text = "FormRegistrator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBoxDoctor.ResumeLayout(false);
            this.groupBoxPatients.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.GroupBox groupBoxPatients;
        private MatchingDoctors matchingDoctors1;
        private MatchingPatients matchingPatients1;
    }
}