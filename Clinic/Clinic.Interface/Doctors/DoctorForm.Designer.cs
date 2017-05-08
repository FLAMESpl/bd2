namespace Clinic.Interface.Doctors
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.sourceDailyVisists = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataGridVisits = new System.Windows.Forms.DataGridView();
            this.visitHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolButtonRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.sourceDailyVisists)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceDailyVisists
            // 
            this.sourceDailyVisists.DataSource = typeof(Clinic.Facades.Visits.DailyVisit);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolButtonRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(505, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridVisits
            // 
            this.dataGridVisits.AutoGenerateColumns = false;
            this.dataGridVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitHourDataGridViewTextBoxColumn,
            this.patientDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridVisits.DataSource = this.sourceDailyVisists;
            this.dataGridVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVisits.Location = new System.Drawing.Point(0, 25);
            this.dataGridVisits.Name = "dataGridVisits";
            this.dataGridVisits.Size = new System.Drawing.Size(505, 285);
            this.dataGridVisits.TabIndex = 1;
            // 
            // visitHourDataGridViewTextBoxColumn
            // 
            this.visitHourDataGridViewTextBoxColumn.DataPropertyName = "VisitHour";
            this.visitHourDataGridViewTextBoxColumn.HeaderText = "VisitHour";
            this.visitHourDataGridViewTextBoxColumn.Name = "visitHourDataGridViewTextBoxColumn";
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "Patient";
            this.patientDataGridViewTextBoxColumn.HeaderText = "Patient";
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // toolButtonRefresh
            // 
            this.toolButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonRefresh.Image")));
            this.toolButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonRefresh.Name = "toolButtonRefresh";
            this.toolButtonRefresh.Size = new System.Drawing.Size(50, 22);
            this.toolButtonRefresh.Text = "Refresh";
            this.toolButtonRefresh.Click += new System.EventHandler(this.toolButtonRefresh_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 310);
            this.Controls.Add(this.dataGridVisits);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DoctorForm";
            this.Text = "Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.sourceDailyVisists)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sourceDailyVisists;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolButtonRefresh;
        private System.Windows.Forms.DataGridView dataGridVisits;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}