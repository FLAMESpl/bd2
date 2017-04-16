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
            this.groupBoxPatients = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddVisit = new System.Windows.Forms.Button();
            this.buttonSearchAndUpdate = new System.Windows.Forms.Button();
            this.matchingPatients = new Clinic.Interface.Registrator.MatchingPatients();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxPatients.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.75426F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.245742F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(473, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 469F));
            this.tableLayoutPanel2.Controls.Add(this.groupBoxPatients, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(467, 366);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxPatients
            // 
            this.groupBoxPatients.Controls.Add(this.matchingPatients);
            this.groupBoxPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPatients.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPatients.Name = "groupBoxPatients";
            this.groupBoxPatients.Size = new System.Drawing.Size(463, 360);
            this.groupBoxPatients.TabIndex = 0;
            this.groupBoxPatients.TabStop = false;
            this.groupBoxPatients.Text = "Patient";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonAddVisit);
            this.flowLayoutPanel1.Controls.Add(this.buttonSearchAndUpdate);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 375);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(467, 33);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonAddVisit
            // 
            this.buttonAddVisit.Location = new System.Drawing.Point(3, 3);
            this.buttonAddVisit.Name = "buttonAddVisit";
            this.buttonAddVisit.Size = new System.Drawing.Size(164, 23);
            this.buttonAddVisit.TabIndex = 0;
            this.buttonAddVisit.Text = "Add visit";
            this.buttonAddVisit.UseVisualStyleBackColor = true;
            this.buttonAddVisit.Click += new System.EventHandler(this.buttonAddVisit_Click);
            // 
            // buttonSearchAndUpdate
            // 
            this.buttonSearchAndUpdate.Location = new System.Drawing.Point(173, 3);
            this.buttonSearchAndUpdate.Name = "buttonSearchAndUpdate";
            this.buttonSearchAndUpdate.Size = new System.Drawing.Size(151, 23);
            this.buttonSearchAndUpdate.TabIndex = 1;
            this.buttonSearchAndUpdate.Text = "Search and update visits";
            this.buttonSearchAndUpdate.UseVisualStyleBackColor = true;
            // 
            // matchingPatients
            // 
            this.matchingPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchingPatients.Location = new System.Drawing.Point(3, 16);
            this.matchingPatients.Name = "matchingPatients";
            this.matchingPatients.Size = new System.Drawing.Size(457, 341);
            this.matchingPatients.TabIndex = 0;
            // 
            // RegistratorHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RegistratorHomeForm";
            this.Text = "Registrator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBoxPatients.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxPatients;
        private MatchingPatients matchingPatients;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAddVisit;
        private System.Windows.Forms.Button buttonSearchAndUpdate;
    }
}