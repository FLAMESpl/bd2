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
            this.sourceDailyVisists = new System.Windows.Forms.BindingSource(this.components);
            this.dailyVisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbVisits = new System.Windows.Forms.GroupBox();
            this.datgridVisits = new System.Windows.Forms.DataGridView();
            this.visitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCalendar = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowCurrent = new System.Windows.Forms.Button();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sourceDailyVisists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyVisitBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbVisits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgridVisits)).BeginInit();
            this.gbCalendar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceDailyVisists
            // 
            this.sourceDailyVisists.DataSource = typeof(Clinic.Facades.Visits.DailyVisit);
            // 
            // dailyVisitBindingSource
            // 
            this.dailyVisitBindingSource.DataSource = typeof(Clinic.Facades.Visits.DailyVisit);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbVisits);
            this.panel1.Controls.Add(this.gbCalendar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 459);
            this.panel1.TabIndex = 5;
            // 
            // gbVisits
            // 
            this.gbVisits.Controls.Add(this.datgridVisits);
            this.gbVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVisits.Location = new System.Drawing.Point(0, 192);
            this.gbVisits.Name = "gbVisits";
            this.gbVisits.Size = new System.Drawing.Size(498, 267);
            this.gbVisits.TabIndex = 1;
            this.gbVisits.TabStop = false;
            this.gbVisits.Text = "Visits for this day";
            // 
            // datgridVisits
            // 
            this.datgridVisits.AllowUserToAddRows = false;
            this.datgridVisits.AllowUserToDeleteRows = false;
            this.datgridVisits.AutoGenerateColumns = false;
            this.datgridVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgridVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitIdDataGridViewTextBoxColumn,
            this.visitHourDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.patientDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.datgridVisits.DataSource = this.sourceDailyVisists;
            this.datgridVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datgridVisits.Location = new System.Drawing.Point(3, 16);
            this.datgridVisits.Name = "datgridVisits";
            this.datgridVisits.ReadOnly = true;
            this.datgridVisits.Size = new System.Drawing.Size(492, 248);
            this.datgridVisits.TabIndex = 0;
            // 
            // visitIdDataGridViewTextBoxColumn
            // 
            this.visitIdDataGridViewTextBoxColumn.DataPropertyName = "VisitId";
            this.visitIdDataGridViewTextBoxColumn.HeaderText = "VisitId";
            this.visitIdDataGridViewTextBoxColumn.Name = "visitIdDataGridViewTextBoxColumn";
            this.visitIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.visitIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // visitHourDataGridViewTextBoxColumn
            // 
            this.visitHourDataGridViewTextBoxColumn.DataPropertyName = "VisitHour";
            this.visitHourDataGridViewTextBoxColumn.HeaderText = "VisitHour";
            this.visitHourDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.visitHourDataGridViewTextBoxColumn.Name = "visitHourDataGridViewTextBoxColumn";
            this.visitHourDataGridViewTextBoxColumn.ReadOnly = true;
            this.visitHourDataGridViewTextBoxColumn.Width = 150;
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "Patient";
            this.patientDataGridViewTextBoxColumn.HeaderText = "Patient";
            this.patientDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            this.patientDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gbCalendar
            // 
            this.gbCalendar.Controls.Add(this.monthCalendar1);
            this.gbCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCalendar.Location = new System.Drawing.Point(0, 0);
            this.gbCalendar.Name = "gbCalendar";
            this.gbCalendar.Size = new System.Drawing.Size(498, 192);
            this.gbCalendar.TabIndex = 0;
            this.gbCalendar.TabStop = false;
            this.gbCalendar.Text = "Calendar";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar1.Location = new System.Drawing.Point(3, 16);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.dateSelected);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnShowCurrent, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFinalize, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 459);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 90);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(160, 41);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.refreshCurrentVisitsShowed);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(169, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Details and actions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clickShowDetailsAndActions);
            // 
            // btnShowCurrent
            // 
            this.btnShowCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowCurrent.Location = new System.Drawing.Point(335, 3);
            this.btnShowCurrent.Name = "btnShowCurrent";
            this.btnShowCurrent.Size = new System.Drawing.Size(160, 41);
            this.btnShowCurrent.TabIndex = 4;
            this.btnShowCurrent.Text = "Show visits at this moment";
            this.btnShowCurrent.UseVisualStyleBackColor = true;
            this.btnShowCurrent.Click += new System.EventHandler(this.clickShowVisitsAtThisMoment);
            // 
            // btnFinalize
            // 
            this.btnFinalize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFinalize.Location = new System.Drawing.Point(3, 50);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(160, 37);
            this.btnFinalize.TabIndex = 5;
            this.btnFinalize.Text = "Finalize Visit(s)";
            this.btnFinalize.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(169, 50);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel Visit(s)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(257, 500);
            this.Name = "DoctorForm";
            this.Text = "Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.sourceDailyVisists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyVisitBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbVisits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datgridVisits)).EndInit();
            this.gbCalendar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sourceDailyVisists;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbVisits;
        private System.Windows.Forms.GroupBox gbCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView datgridVisits;
        private System.Windows.Forms.BindingSource dailyVisitBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnShowCurrent;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnCancel;
    }
}