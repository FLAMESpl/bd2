using Clinic.Facades.Visits;

namespace Clinic.Interface.Registrator
{
    partial class VisitForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitForm));
            this.bindingSourceDailyVisit = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelDoctors = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.listBoxDoctors = new System.Windows.Forms.ListBox();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewDailyVisits = new System.Windows.Forms.DataGridView();
            this.visitHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Reserve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolButtonRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDailyVisit)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelDoctors.SuspendLayout();
            this.groupBoxDoctor.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDailyVisits)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSourceDailyVisit
            // 
            this.bindingSourceDailyVisit.DataSource = typeof(Clinic.Facades.Visits.DailyVisit);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelDoctors, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxPatient, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(656, 425);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelDoctors
            // 
            this.tableLayoutPanelDoctors.ColumnCount = 2;
            this.tableLayoutPanelDoctors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelDoctors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDoctors.Controls.Add(this.groupBoxDoctor, 0, 0);
            this.tableLayoutPanelDoctors.Controls.Add(this.groupBoxDate, 1, 0);
            this.tableLayoutPanelDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDoctors.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanelDoctors.Name = "tableLayoutPanelDoctors";
            this.tableLayoutPanelDoctors.RowCount = 1;
            this.tableLayoutPanelDoctors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDoctors.Size = new System.Drawing.Size(650, 186);
            this.tableLayoutPanelDoctors.TabIndex = 0;
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.listBoxDoctors);
            this.groupBoxDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDoctor.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(194, 180);
            this.groupBoxDoctor.TabIndex = 2;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "Doctor";
            // 
            // listBoxDoctors
            // 
            this.listBoxDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDoctors.FormattingEnabled = true;
            this.listBoxDoctors.Location = new System.Drawing.Point(3, 16);
            this.listBoxDoctors.Name = "listBoxDoctors";
            this.listBoxDoctors.Size = new System.Drawing.Size(188, 161);
            this.listBoxDoctors.TabIndex = 0;
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.monthCalendar);
            this.groupBoxDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDate.Location = new System.Drawing.Point(203, 3);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(444, 180);
            this.groupBoxDate.TabIndex = 3;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Visit date";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.monthCalendar.Location = new System.Drawing.Point(3, 15);
            this.monthCalendar.MaxSelectionCount = 31;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPatient.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(650, 51);
            this.groupBoxPatient.TabIndex = 2;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewDailyVisits);
            this.panel1.Controls.Add(this.toolStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 170);
            this.panel1.TabIndex = 3;
            // 
            // dataGridViewDailyVisits
            // 
            this.dataGridViewDailyVisits.AllowUserToAddRows = false;
            this.dataGridViewDailyVisits.AllowUserToDeleteRows = false;
            this.dataGridViewDailyVisits.AutoGenerateColumns = false;
            this.dataGridViewDailyVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDailyVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitHourDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.patientDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.Description,
            this.Edit,
            this.Reserve,
            this.Cancel,
            this.Delete});
            this.dataGridViewDailyVisits.DataSource = this.bindingSourceDailyVisit;
            this.dataGridViewDailyVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDailyVisits.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewDailyVisits.Name = "dataGridViewDailyVisits";
            this.dataGridViewDailyVisits.ReadOnly = true;
            this.dataGridViewDailyVisits.Size = new System.Drawing.Size(650, 145);
            this.dataGridViewDailyVisits.TabIndex = 2;
            this.dataGridViewDailyVisits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDailyVisits_CellContentClick);
            // 
            // visitHourDataGridViewTextBoxColumn
            // 
            this.visitHourDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.visitHourDataGridViewTextBoxColumn.DataPropertyName = "VisitHour";
            dataGridViewCellStyle2.Format = "f";
            dataGridViewCellStyle2.NullValue = null;
            this.visitHourDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.visitHourDataGridViewTextBoxColumn.HeaderText = "Date";
            this.visitHourDataGridViewTextBoxColumn.Name = "visitHourDataGridViewTextBoxColumn";
            this.visitHourDataGridViewTextBoxColumn.ReadOnly = true;
            this.visitHourDataGridViewTextBoxColumn.Width = 200;
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorDataGridViewTextBoxColumn.Width = 150;
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "Patient";
            this.patientDataGridViewTextBoxColumn.HeaderText = "Patient";
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            this.patientDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 50;
            // 
            // Reserve
            // 
            this.Reserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Reserve.HeaderText = "";
            this.Reserve.Name = "Reserve";
            this.Reserve.ReadOnly = true;
            this.Reserve.Text = "Reserve";
            this.Reserve.UseColumnTextForButtonValue = true;
            this.Reserve.Width = 50;
            // 
            // Cancel
            // 
            this.Cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cancel.HeaderText = "";
            this.Cancel.Name = "Cancel";
            this.Cancel.ReadOnly = true;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseColumnTextForButtonValue = true;
            this.Cancel.Width = 50;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolButtonRefresh});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(650, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolButtonRefresh
            // 
            this.toolButtonRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonRefresh.Image")));
            this.toolButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonRefresh.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
            this.toolButtonRefresh.Name = "toolButtonRefresh";
            this.toolButtonRefresh.Size = new System.Drawing.Size(50, 22);
            this.toolButtonRefresh.Text = "Refresh";
            this.toolButtonRefresh.Click += new System.EventHandler(this.toolButtonRefresh_Click);
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 425);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "VisitForm";
            this.Text = "Visists";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDailyVisit)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelDoctors.ResumeLayout(false);
            this.groupBoxDoctor.ResumeLayout(false);
            this.groupBoxDate.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDailyVisits)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDoctors;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.BindingSource bindingSourceDailyVisit;
        private System.Windows.Forms.ListBox listBoxDoctors;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDailyVisits;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolButtonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Reserve;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}