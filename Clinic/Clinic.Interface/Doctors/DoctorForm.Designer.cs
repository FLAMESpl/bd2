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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDoctor = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbCalendar = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.gbVisits = new System.Windows.Forms.GroupBox();
            this.datgridVisits = new System.Windows.Forms.DataGridView();
            this.visitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowCurrent = new System.Windows.Forms.Button();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sourceDailyVisists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyVisitBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbCalendar.SuspendLayout();
            this.gbVisits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datgridVisits)).BeginInit();
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
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.gbVisits);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 488);
            this.panel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 99);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePickerDoctor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 73);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a date:";
            // 
            // dateTimePickerDoctor
            // 
            this.dateTimePickerDoctor.Location = new System.Drawing.Point(12, 31);
            this.dateTimePickerDoctor.Name = "dateTimePickerDoctor";
            this.dateTimePickerDoctor.ShowCheckBox = true;
            this.dateTimePickerDoctor.Size = new System.Drawing.Size(228, 20);
            this.dateTimePickerDoctor.TabIndex = 0;
            this.dateTimePickerDoctor.CloseUp += new System.EventHandler(this.dateTimePickerDoctor_CloseUp);
            this.dateTimePickerDoctor.ValueChanged += new System.EventHandler(this.dateTimePickerDoctor_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbCalendar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 73);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbCalendar
            // 
            this.gbCalendar.Controls.Add(this.monthCalendar1);
            this.gbCalendar.Location = new System.Drawing.Point(0, 0);
            this.gbCalendar.Name = "gbCalendar";
            this.gbCalendar.Size = new System.Drawing.Size(742, 192);
            this.gbCalendar.TabIndex = 0;
            this.gbCalendar.TabStop = false;
            this.gbCalendar.Text = "Calendar";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(4, 1);
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar1.Location = new System.Drawing.Point(3, 16);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.dateSelected);
            // 
            // gbVisits
            // 
            this.gbVisits.Controls.Add(this.datgridVisits);
            this.gbVisits.Location = new System.Drawing.Point(0, 105);
            this.gbVisits.Name = "gbVisits";
            this.gbVisits.Size = new System.Drawing.Size(742, 383);
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
            this.datgridVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datgridVisits.Size = new System.Drawing.Size(736, 364);
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
            this.visitHourDataGridViewTextBoxColumn.HeaderText = "Visit Time";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 488);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 90);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(241, 41);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.refreshCurrentVisitsShowed);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(250, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Details and actions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clickShowDetailsAndActions);
            // 
            // btnShowCurrent
            // 
            this.btnShowCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowCurrent.Location = new System.Drawing.Point(497, 3);
            this.btnShowCurrent.Name = "btnShowCurrent";
            this.btnShowCurrent.Size = new System.Drawing.Size(242, 41);
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
            this.btnFinalize.Size = new System.Drawing.Size(241, 37);
            this.btnFinalize.TabIndex = 5;
            this.btnFinalize.Text = "Finalize Visit(s)";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalizeVisits_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(250, 50);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(241, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel Visit(s)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelVisits_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(257, 500);
            this.Name = "DoctorForm";
            this.Text = "Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.sourceDailyVisists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyVisitBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbCalendar.ResumeLayout(false);
            this.gbVisits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datgridVisits)).EndInit();
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
        private System.Windows.Forms.Button btnShowCurrent;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoctor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}